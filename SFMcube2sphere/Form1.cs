using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace SFMcube2sphere
{
    public partial class Form1 : Form
    {
        public PictureBox SelectedBox;
        public Label SelectedLabel;
        public int SelectedFace;

        public PictureBox[] boxorder;
        public Label[] labelorder;

        public List<string>[] Sequences = new List<string>[6] {
            null,null,null,null,null,null
        };


        public Form1()
        {
            InitializeComponent();
            labelorder = new Label[]{ lFront, lBottom, lRight, lBack, lTop, lLeft };
            boxorder = new PictureBox[]{ pRight, pLeft, pTop, pBottom, pFront, pBack };
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            var s = sender as PictureBox;
            if (s != null)
                s.BorderStyle = BorderStyle.Fixed3D;
        }

        private void p_MouseLeave(object sender, EventArgs e)
        {
            var s = sender as PictureBox;
            if (s != null)
                s.BorderStyle = BorderStyle.FixedSingle;
        }

        private void XRES_TextChanged(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            if (s != null)
                s.Text = Regex.Replace(s.Text, "[^0-9]","");
        }

        private void pFront_Click(object sender, EventArgs e)
        {
            SelectedBox = pFront;
            SelectedLabel = lFront;
            SelectedFace = 4;
            openFile.ShowDialog();
        }


        private void pBottom_Click(object sender, EventArgs e)
        {
            SelectedBox = pBottom;
            SelectedFace = 3;
            SelectedLabel = lBottom;
            openFile.ShowDialog();
        }

        private void pRight_Click(object sender, EventArgs e)
        {
            SelectedBox = pRight;
            SelectedFace = 0;
            SelectedLabel = lRight;
            openFile.ShowDialog();
        }

        private void pBack_Click(object sender, EventArgs e)
        {
            SelectedBox = pBack;
            SelectedFace = 5;
            SelectedLabel = lBack;
            openFile.ShowDialog();
        }

        private void pTop_Click(object sender, EventArgs e)
        {
            SelectedBox = pTop;
            SelectedFace = 2;
            SelectedLabel = lTop;
            openFile.ShowDialog();
        }

        private void pLeft_Click(object sender, EventArgs e)
        {
            SelectedBox = pLeft;
            SelectedFace = 1;
            SelectedLabel = lLeft;
            openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            SelectedBox.Image = Image.FromFile(openFile.FileName);
            LoadSequence(openFile.FileName);
        }

        string[] GetSequence(string FileName)
        {
            string Prefix = Regex.Replace(Path.GetFileNameWithoutExtension(FileName), @"\d+$", "");

            return Directory.GetFiles(Path.GetDirectoryName(FileName), Prefix + "*.png");
        }


        void LoadSequence(string FileName)
        {
            Sequences[SelectedFace] = GetSequence(FileName).ToList();
            SelectedLabel.Text = "Frames: "+Sequences[SelectedFace].Count;

            if (!Sequences.Contains(null))
                RenderButton.Enabled = true;
        }

        private void RenderButton_Click(object sender, EventArgs e) => saveFile.ShowDialog();
        private void saveFile_FileOk(object sender, CancelEventArgs e) => Render(saveFile.FileName, int.Parse(XRES.Text), int.Parse(YRES.Text));
        private void button1_Click(object sender, EventArgs e) => openSFM.ShowDialog();


        void Render(string FileName, int Width, int Height)
        {
            PixelFormat format = boxorder[0].Image.PixelFormat;
            for(int i = 1; i < boxorder.Length; i++)
                if(boxorder[i].Image.PixelFormat != format)
                {
                    MessageBox.Show("These images have different pixel formats.","Reeeeee!!!!!!", MessageBoxButtons.OK);

                    return;
                }

            RenderButton.Enabled = false;
            try {
                new RenderForm(FileName, Width, Height, this).Show();
            }
            catch
            {

            }
        }

        private void openSFM_FileOk(object sender, CancelEventArgs e)
        {
            int[] frameorder = { 4,1,0,5,3,2 };

            string[] files = GetSequence(openSFM.FileName);
            int frames = files.Length / 6;
            int i = 0;
            Sequences = new List<string>[] { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };

            while (i < files.Length - 1)
                Sequences[frameorder[i / frames]].Add(files[i++]);


            for (i = 0; i < 6; i++)
            {
                if (Sequences[i].Count == 0) Sequences[i] = null;
                else {
                    Console.WriteLine(Sequences[i].First());
                    boxorder[i].Image = Image.FromFile(Sequences[i].First());
                    labelorder[i].Text = "Frames: " + Sequences[i].Count();
                }
            }


            if (!Sequences.Contains(null))
                RenderButton.Enabled = true;
        }


    }
}
