namespace ImageEffect
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            btnApply = new Button();
            rbStandart = new RadioButton();
            rbGrey = new RadioButton();
            rbBlur = new RadioButton();
            tbSlider = new TrackBar();
            pbImage = new PictureBox();
            browserDialog = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)tbSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(418, 12);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(147, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(418, 167);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(147, 23);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // rbStandart
            // 
            rbStandart.AutoSize = true;
            rbStandart.Location = new Point(418, 41);
            rbStandart.Name = "rbStandart";
            rbStandart.Size = new Size(69, 19);
            rbStandart.TabIndex = 2;
            rbStandart.TabStop = true;
            rbStandart.Text = "Standart";
            rbStandart.UseVisualStyleBackColor = true;
            rbStandart.CheckedChanged += rbStandart_CheckedChanged;
            // 
            // rbGrey
            // 
            rbGrey.AutoSize = true;
            rbGrey.Location = new Point(418, 91);
            rbGrey.Name = "rbGrey";
            rbGrey.Size = new Size(49, 19);
            rbGrey.TabIndex = 3;
            rbGrey.TabStop = true;
            rbGrey.Text = "Grey";
            rbGrey.UseVisualStyleBackColor = true;
            rbGrey.CheckedChanged += rbGrey_CheckedChanged;
            // 
            // rbBlur
            // 
            rbBlur.AutoSize = true;
            rbBlur.Location = new Point(418, 66);
            rbBlur.Name = "rbBlur";
            rbBlur.Size = new Size(46, 19);
            rbBlur.TabIndex = 4;
            rbBlur.TabStop = true;
            rbBlur.Text = "Blur";
            rbBlur.UseVisualStyleBackColor = true;
            rbBlur.CheckedChanged += rbBlur_CheckedChanged;
            // 
            // tbSlider
            // 
            tbSlider.Location = new Point(418, 116);
            tbSlider.Maximum = 20;
            tbSlider.Name = "tbSlider";
            tbSlider.RightToLeft = RightToLeft.Yes;
            tbSlider.Size = new Size(147, 45);
            tbSlider.TabIndex = 5;
            tbSlider.TickStyle = TickStyle.Both;
            tbSlider.Value = 20;
            tbSlider.Scroll += tbSlider_Scroll;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 12);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(400, 300);
            pbImage.TabIndex = 6;
            pbImage.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 321);
            Controls.Add(pbImage);
            Controls.Add(tbSlider);
            Controls.Add(rbBlur);
            Controls.Add(rbGrey);
            Controls.Add(rbStandart);
            Controls.Add(btnApply);
            Controls.Add(btnBrowse);
            Name = "MainForm";
            Text = "Image Effect";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)tbSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnApply;
        private RadioButton rbStandart;
        private RadioButton rbGrey;
        private RadioButton rbBlur;
        private TrackBar tbSlider;
        private PictureBox pbImage;
        private FolderBrowserDialog browserDialog;
    }
}