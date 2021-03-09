namespace SFMcube2sphere
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pLeft = new System.Windows.Forms.PictureBox();
            this.pFront = new System.Windows.Forms.PictureBox();
            this.pRight = new System.Windows.Forms.PictureBox();
            this.pBack = new System.Windows.Forms.PictureBox();
            this.pBottom = new System.Windows.Forms.PictureBox();
            this.pTop = new System.Windows.Forms.PictureBox();
            this.lBottom = new System.Windows.Forms.Label();
            this.lLeft = new System.Windows.Forms.Label();
            this.lFront = new System.Windows.Forms.Label();
            this.lRight = new System.Windows.Forms.Label();
            this.lBack = new System.Windows.Forms.Label();
            this.lTop = new System.Windows.Forms.Label();
            this.RenderButton = new System.Windows.Forms.Button();
            this.XRES = new System.Windows.Forms.TextBox();
            this.YRES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.openSFM = new System.Windows.Forms.OpenFileDialog();
            this.AABox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTop)).BeginInit();
            this.AABox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLeft.Location = new System.Drawing.Point(34, 130);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(100, 100);
            this.pLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLeft.TabIndex = 0;
            this.pLeft.TabStop = false;
            this.pLeft.Click += new System.EventHandler(this.pLeft_Click);
            this.pLeft.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pLeft.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // pFront
            // 
            this.pFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFront.Location = new System.Drawing.Point(140, 130);
            this.pFront.Name = "pFront";
            this.pFront.Size = new System.Drawing.Size(100, 100);
            this.pFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pFront.TabIndex = 1;
            this.pFront.TabStop = false;
            this.pFront.Click += new System.EventHandler(this.pFront_Click);
            this.pFront.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pFront.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // pRight
            // 
            this.pRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRight.Location = new System.Drawing.Point(246, 130);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(100, 100);
            this.pRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pRight.TabIndex = 1;
            this.pRight.TabStop = false;
            this.pRight.Click += new System.EventHandler(this.pRight_Click);
            this.pRight.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pRight.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // pBack
            // 
            this.pBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBack.Location = new System.Drawing.Point(352, 130);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(100, 100);
            this.pBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBack.TabIndex = 1;
            this.pBack.TabStop = false;
            this.pBack.Click += new System.EventHandler(this.pBack_Click);
            this.pBack.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pBack.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // pBottom
            // 
            this.pBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBottom.Location = new System.Drawing.Point(140, 236);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(100, 100);
            this.pBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBottom.TabIndex = 1;
            this.pBottom.TabStop = false;
            this.pBottom.Click += new System.EventHandler(this.pBottom_Click);
            this.pBottom.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pBottom.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // pTop
            // 
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Location = new System.Drawing.Point(140, 24);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(100, 100);
            this.pTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTop.TabIndex = 1;
            this.pTop.TabStop = false;
            this.pTop.Click += new System.EventHandler(this.pTop_Click);
            this.pTop.MouseLeave += new System.EventHandler(this.p_MouseLeave);
            this.pTop.MouseHover += new System.EventHandler(this.p_MouseHover);
            // 
            // lBottom
            // 
            this.lBottom.AutoSize = true;
            this.lBottom.Location = new System.Drawing.Point(137, 323);
            this.lBottom.Name = "lBottom";
            this.lBottom.Size = new System.Drawing.Size(40, 13);
            this.lBottom.TabIndex = 2;
            this.lBottom.Text = "Bottom";
            // 
            // lLeft
            // 
            this.lLeft.AutoSize = true;
            this.lLeft.Location = new System.Drawing.Point(31, 217);
            this.lLeft.Name = "lLeft";
            this.lLeft.Size = new System.Drawing.Size(25, 13);
            this.lLeft.TabIndex = 2;
            this.lLeft.Text = "Left";
            // 
            // lFront
            // 
            this.lFront.AutoSize = true;
            this.lFront.Location = new System.Drawing.Point(140, 217);
            this.lFront.Name = "lFront";
            this.lFront.Size = new System.Drawing.Size(31, 13);
            this.lFront.TabIndex = 2;
            this.lFront.Text = "Front";
            // 
            // lRight
            // 
            this.lRight.AutoSize = true;
            this.lRight.Location = new System.Drawing.Point(246, 217);
            this.lRight.Name = "lRight";
            this.lRight.Size = new System.Drawing.Size(32, 13);
            this.lRight.TabIndex = 2;
            this.lRight.Text = "Right";
            // 
            // lBack
            // 
            this.lBack.AutoSize = true;
            this.lBack.Location = new System.Drawing.Point(352, 217);
            this.lBack.Name = "lBack";
            this.lBack.Size = new System.Drawing.Size(32, 13);
            this.lBack.TabIndex = 2;
            this.lBack.Text = "Back";
            // 
            // lTop
            // 
            this.lTop.AutoSize = true;
            this.lTop.Location = new System.Drawing.Point(140, 111);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(26, 13);
            this.lTop.TabIndex = 2;
            this.lTop.Text = "Top";
            // 
            // RenderButton
            // 
            this.RenderButton.Enabled = false;
            this.RenderButton.Font = new System.Drawing.Font("Motorwerk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenderButton.Location = new System.Drawing.Point(281, 303);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(147, 33);
            this.RenderButton.TabIndex = 3;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // XRES
            // 
            this.XRES.Location = new System.Drawing.Point(281, 270);
            this.XRES.Name = "XRES";
            this.XRES.Size = new System.Drawing.Size(65, 20);
            this.XRES.TabIndex = 4;
            this.XRES.Text = "2000";
            this.XRES.TextChanged += new System.EventHandler(this.XRES_TextChanged);
            // 
            // YRES
            // 
            this.YRES.Location = new System.Drawing.Point(355, 269);
            this.YRES.Name = "YRES";
            this.YRES.Size = new System.Drawing.Size(73, 20);
            this.YRES.TabIndex = 5;
            this.YRES.Text = "1000";
            this.YRES.TextChanged += new System.EventHandler(this.XRES_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output Resolution";
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "png";
            this.openFile.FileName = "ImageSequence";
            this.openFile.Filter = "Image Files|*.png";
            this.openFile.Title = "Select Image Sequence";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.FileName = "myPanorama";
            this.saveFile.Title = "Select Save Location";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load SFMToolkit Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openSFM
            // 
            this.openSFM.FileName = "RenderedMovie000000";
            this.openSFM.Filter = "png files|*.png";
            this.openSFM.Title = "Select SFMToolkit movie";
            this.openSFM.FileOk += new System.ComponentModel.CancelEventHandler(this.openSFM_FileOk);
            // 
            // AABox
            // 
            this.AABox.Controls.Add(this.radioButton4);
            this.AABox.Controls.Add(this.radioButton3);
            this.AABox.Controls.Add(this.radioButton2);
            this.AABox.Controls.Add(this.radioButton1);
            this.AABox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AABox.Location = new System.Drawing.Point(35, 236);
            this.AABox.Name = "AABox";
            this.AABox.Size = new System.Drawing.Size(99, 100);
            this.AABox.TabIndex = 8;
            this.AABox.TabStop = false;
            this.AABox.Text = "Anti Aliasing";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 67);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Tag = "./shader64x.frag";
            this.radioButton4.Text = "64x MSAA";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Tag = "./shader16x.frag";
            this.radioButton3.Text = "16x MSAA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "./shader4x.frag";
            this.radioButton2.Text = "4x  MSAA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "./shader.frag";
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 374);
            this.Controls.Add(this.AABox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YRES);
            this.Controls.Add(this.XRES);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.lBack);
            this.Controls.Add(this.lRight);
            this.Controls.Add(this.lTop);
            this.Controls.Add(this.lFront);
            this.Controls.Add(this.lLeft);
            this.Controls.Add(this.lBottom);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pBottom);
            this.Controls.Add(this.pFront);
            this.Controls.Add(this.pLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Panorama Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTop)).EndInit();
            this.AABox.ResumeLayout(false);
            this.AABox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pLeft;
        private System.Windows.Forms.PictureBox pFront;
        private System.Windows.Forms.PictureBox pRight;
        private System.Windows.Forms.PictureBox pBack;
        private System.Windows.Forms.PictureBox pBottom;
        private System.Windows.Forms.PictureBox pTop;
        private System.Windows.Forms.Label lBottom;
        private System.Windows.Forms.Label lLeft;
        private System.Windows.Forms.Label lFront;
        private System.Windows.Forms.Label lRight;
        private System.Windows.Forms.Label lBack;
        private System.Windows.Forms.Label lTop;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.TextBox XRES;
        private System.Windows.Forms.TextBox YRES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openSFM;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox AABox;
    }
}

