using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SFMcube2sphere
{
    public partial class RenderForm : Form
    {
        string FileName;
        int Frames, W, H;
        Form1 form;
        Thread t;

        public RenderForm(string filename, int width, int height,Form1 parent)
        {
            FileName = filename;
            InitializeComponent();
            W = width;
            H= height;
            form = parent;
            progressBar1.Maximum = Frames = form.Sequences.Min(x=>x.Count);
            DialogResult = DialogResult.OK;
        }

        private void RenderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        private void RenderForm_Load(object sender, EventArgs e)
        {
            (t = new Thread(Render)).Start();
        }

        void Render()
        {
            Renderer.Start(W,H);
            for (int frame = 0; frame < Frames; frame++)
            {
                Invoke((MethodInvoker)delegate { progressBar1.Value = frame; });
                string[] bitmaps = new string[6];
                for (int i = 0; i < 6; i++)
                    bitmaps[i] = form.Sequences[i][frame];

                Renderer.RenderImages(bitmaps, FileName + frame.ToString("D6") + ".png");
            }
            Renderer.Stop();

            Invoke((MethodInvoker)delegate
            {
                  Close();
            });
        }
    }
}
