namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.IniitalImge = new System.Windows.Forms.PictureBox();
            this.NoiseLevelSliderR = new System.Windows.Forms.TrackBar();
            this.resultImage = new System.Windows.Forms.PictureBox();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.dostepneBajty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDecipheredFile = new System.Windows.Forms.Label();
            this.messagePathChooseButton = new System.Windows.Forms.Button();
            this.SliderBLabel = new System.Windows.Forms.Label();
            this.SliderGLabel = new System.Windows.Forms.Label();
            this.SliderRLabel = new System.Windows.Forms.Label();
            this.NoiseLevelSliderB = new System.Windows.Forms.TrackBar();
            this.NoiseLevelSliderG = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IniitalImge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderG)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.BackColor = System.Drawing.Color.Turquoise;
            this.OpenFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenFileButton.Location = new System.Drawing.Point(12, 47);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(185, 38);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open bmp file";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // IniitalImge
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.IniitalImge, true);
            this.IniitalImge.Location = new System.Drawing.Point(3, 26);
            this.IniitalImge.Name = "IniitalImge";
            this.IniitalImge.Size = new System.Drawing.Size(500, 500);
            this.IniitalImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IniitalImge.TabIndex = 1;
            this.IniitalImge.TabStop = false;
            this.IniitalImge.Click += new System.EventHandler(this.IniitalImge_Click);
            // 
            // NoiseLevelSliderR
            // 
            this.NoiseLevelSliderR.AutoSize = false;
            this.NoiseLevelSliderR.BackColor = System.Drawing.Color.White;
            this.NoiseLevelSliderR.LargeChange = 1;
            this.NoiseLevelSliderR.Location = new System.Drawing.Point(8, 23);
            this.NoiseLevelSliderR.Maximum = 8;
            this.NoiseLevelSliderR.Name = "NoiseLevelSliderR";
            this.NoiseLevelSliderR.Size = new System.Drawing.Size(121, 30);
            this.NoiseLevelSliderR.TabIndex = 2;
            this.NoiseLevelSliderR.Value = 1;
            this.NoiseLevelSliderR.ValueChanged += new System.EventHandler(this.NoiseLevelSliderR_ValueChanged);
            // 
            // resultImage
            // 
            this.resultImage.Location = new System.Drawing.Point(509, 26);
            this.resultImage.Name = "resultImage";
            this.resultImage.Size = new System.Drawing.Size(500, 500);
            this.resultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultImage.TabIndex = 4;
            this.resultImage.TabStop = false;
            // 
            // CipherButton
            // 
            this.CipherButton.BackColor = System.Drawing.Color.Turquoise;
            this.CipherButton.FlatAppearance.BorderSize = 0;
            this.CipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CipherButton.Location = new System.Drawing.Point(5, 215);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(83, 25);
            this.CipherButton.TabIndex = 5;
            this.CipherButton.Text = "Encode";
            this.CipherButton.UseVisualStyleBackColor = false;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // DecipherButton
            // 
            this.DecipherButton.BackColor = System.Drawing.Color.Turquoise;
            this.DecipherButton.FlatAppearance.BorderSize = 0;
            this.DecipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DecipherButton.Location = new System.Drawing.Point(91, 215);
            this.DecipherButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(91, 25);
            this.DecipherButton.TabIndex = 6;
            this.DecipherButton.Text = "Decode";
            this.DecipherButton.UseVisualStyleBackColor = false;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // dostepneBajty
            // 
            this.dostepneBajty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dostepneBajty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dostepneBajty.Location = new System.Drawing.Point(5, 183);
            this.dostepneBajty.Name = "dostepneBajty";
            this.dostepneBajty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dostepneBajty.Size = new System.Drawing.Size(177, 29);
            this.dostepneBajty.TabIndex = 8;
            this.dostepneBajty.Text = "0 / 0 B";
            this.dostepneBajty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dostepneBajty.Click += new System.EventHandler(this.AvailableBites_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "File to encode:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDecipheredFile);
            this.panel1.Controls.Add(this.messagePathChooseButton);
            this.panel1.Controls.Add(this.SliderBLabel);
            this.panel1.Controls.Add(this.SliderGLabel);
            this.panel1.Controls.Add(this.SliderRLabel);
            this.panel1.Controls.Add(this.NoiseLevelSliderB);
            this.panel1.Controls.Add(this.NoiseLevelSliderG);
            this.panel1.Controls.Add(this.dostepneBajty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NoiseLevelSliderR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CipherButton);
            this.panel1.Controls.Add(this.DecipherButton);
            this.panel1.Location = new System.Drawing.Point(15, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 280);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // labelDecipheredFile
            // 
            this.labelDecipheredFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDecipheredFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecipheredFile.Location = new System.Drawing.Point(5, 243);
            this.labelDecipheredFile.Name = "labelDecipheredFile";
            this.labelDecipheredFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDecipheredFile.Size = new System.Drawing.Size(177, 29);
            this.labelDecipheredFile.TabIndex = 20;
            this.labelDecipheredFile.Text = "0 / 0 B";
            this.labelDecipheredFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // messagePathChooseButton
            // 
            this.messagePathChooseButton.BackColor = System.Drawing.Color.Turquoise;
            this.messagePathChooseButton.FlatAppearance.BorderSize = 0;
            this.messagePathChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messagePathChooseButton.Location = new System.Drawing.Point(5, 151);
            this.messagePathChooseButton.Name = "messagePathChooseButton";
            this.messagePathChooseButton.Size = new System.Drawing.Size(177, 29);
            this.messagePathChooseButton.TabIndex = 19;
            this.messagePathChooseButton.Text = "Open file";
            this.messagePathChooseButton.UseVisualStyleBackColor = false;
            this.messagePathChooseButton.Click += new System.EventHandler(this.MessagePathChooseButton_Click);
            // 
            // SliderBLabel
            // 
            this.SliderBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SliderBLabel.Location = new System.Drawing.Point(135, 95);
            this.SliderBLabel.Name = "SliderBLabel";
            this.SliderBLabel.Size = new System.Drawing.Size(47, 30);
            this.SliderBLabel.TabIndex = 18;
            this.SliderBLabel.Text = "B: 1";
            this.SliderBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SliderGLabel
            // 
            this.SliderGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SliderGLabel.Location = new System.Drawing.Point(135, 59);
            this.SliderGLabel.Name = "SliderGLabel";
            this.SliderGLabel.Size = new System.Drawing.Size(47, 30);
            this.SliderGLabel.TabIndex = 17;
            this.SliderGLabel.Text = "G: 1";
            this.SliderGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SliderRLabel
            // 
            this.SliderRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SliderRLabel.Location = new System.Drawing.Point(135, 29);
            this.SliderRLabel.Name = "SliderRLabel";
            this.SliderRLabel.Size = new System.Drawing.Size(47, 30);
            this.SliderRLabel.TabIndex = 16;
            this.SliderRLabel.Text = "R: 1";
            this.SliderRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoiseLevelSliderB
            // 
            this.NoiseLevelSliderB.AutoSize = false;
            this.NoiseLevelSliderB.BackColor = System.Drawing.Color.White;
            this.NoiseLevelSliderB.LargeChange = 1;
            this.NoiseLevelSliderB.Location = new System.Drawing.Point(8, 95);
            this.NoiseLevelSliderB.Maximum = 8;
            this.NoiseLevelSliderB.Name = "NoiseLevelSliderB";
            this.NoiseLevelSliderB.Size = new System.Drawing.Size(121, 30);
            this.NoiseLevelSliderB.TabIndex = 15;
            this.NoiseLevelSliderB.Value = 1;
            this.NoiseLevelSliderB.ValueChanged += new System.EventHandler(this.NoiseLevelSliderB_ValueChanged);
            // 
            // NoiseLevelSliderG
            // 
            this.NoiseLevelSliderG.AutoSize = false;
            this.NoiseLevelSliderG.BackColor = System.Drawing.Color.White;
            this.NoiseLevelSliderG.LargeChange = 1;
            this.NoiseLevelSliderG.Location = new System.Drawing.Point(8, 59);
            this.NoiseLevelSliderG.Maximum = 8;
            this.NoiseLevelSliderG.Name = "NoiseLevelSliderG";
            this.NoiseLevelSliderG.Size = new System.Drawing.Size(121, 30);
            this.NoiseLevelSliderG.TabIndex = 14;
            this.NoiseLevelSliderG.Value = 1;
            this.NoiseLevelSliderG.ValueChanged += new System.EventHandler(this.NoiseLevelSliderG_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.IniitalImge);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.resultImage);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1016, 562);
            this.flowLayoutPanel2.TabIndex = 15;
            this.flowLayoutPanel2.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Before encoding";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(509, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "After encoding:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bitmap to encode/decode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1234, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OpenFileButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Steganography MGTB";
            ((System.ComponentModel.ISupportInitialize)(this.IniitalImge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevelSliderG)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.PictureBox IniitalImge;
        private System.Windows.Forms.TrackBar NoiseLevelSliderR;
        private System.Windows.Forms.PictureBox resultImage;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label dostepneBajty;
        private System.Windows.Forms.TrackBar NoiseLevelSliderB;
        private System.Windows.Forms.TrackBar NoiseLevelSliderG;
        private System.Windows.Forms.Label SliderBLabel;
        private System.Windows.Forms.Label SliderGLabel;
        private System.Windows.Forms.Label SliderRLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button messagePathChooseButton;
        public System.Windows.Forms.Label labelDecipheredFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label3;
    }
}

