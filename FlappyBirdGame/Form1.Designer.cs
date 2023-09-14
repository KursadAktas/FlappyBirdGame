namespace FlappyBirdGame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcbFlappyBird = new PictureBox();
            pcpBoruAlt = new PictureBox();
            pcbBoruUst = new PictureBox();
            pcbZemin = new PictureBox();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pcbBoruAlt2 = new PictureBox();
            pcbBoruUst2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcpBoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbZemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruAlt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruUst2).BeginInit();
            SuspendLayout();
            // 
            // pcbFlappyBird
            // 
            pcbFlappyBird.Image = (Image)resources.GetObject("pcbFlappyBird.Image");
            pcbFlappyBird.Location = new Point(69, 159);
            pcbFlappyBird.Name = "pcbFlappyBird";
            pcbFlappyBird.Size = new Size(77, 64);
            pcbFlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFlappyBird.TabIndex = 0;
            pcbFlappyBird.TabStop = false;
            // 
            // pcpBoruAlt
            // 
            pcpBoruAlt.Image = (Image)resources.GetObject("pcpBoruAlt.Image");
            pcpBoruAlt.Location = new Point(337, 276);
            pcpBoruAlt.Name = "pcpBoruAlt";
            pcpBoruAlt.Size = new Size(52, 127);
            pcpBoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            pcpBoruAlt.TabIndex = 1;
            pcpBoruAlt.TabStop = false;
            // 
            // pcbBoruUst
            // 
            pcbBoruUst.Image = (Image)resources.GetObject("pcbBoruUst.Image");
            pcbBoruUst.Location = new Point(423, 1);
            pcbBoruUst.Name = "pcbBoruUst";
            pcbBoruUst.Size = new Size(51, 126);
            pcbBoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBoruUst.TabIndex = 2;
            pcbBoruUst.TabStop = false;
            // 
            // pcbZemin
            // 
            pcbZemin.Image = (Image)resources.GetObject("pcbZemin.Image");
            pcbZemin.Location = new Point(-1, 399);
            pcbZemin.Name = "pcbZemin";
            pcbZemin.Size = new Size(802, 39);
            pcbZemin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbZemin.TabIndex = 3;
            pcbZemin.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(-1, 1);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(29, 46);
            lblScore.TabIndex = 4;
            lblScore.Text = " ";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // pcbBoruAlt2
            // 
            pcbBoruAlt2.Image = (Image)resources.GetObject("pcbBoruAlt2.Image");
            pcbBoruAlt2.Location = new Point(518, 260);
            pcbBoruAlt2.Name = "pcbBoruAlt2";
            pcbBoruAlt2.Size = new Size(52, 143);
            pcbBoruAlt2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBoruAlt2.TabIndex = 5;
            pcbBoruAlt2.TabStop = false;
            pcbBoruAlt2.Click += pictureBox1_Click;
            // 
            // pcbBoruUst2
            // 
            pcbBoruUst2.Image = (Image)resources.GetObject("pcbBoruUst2.Image");
            pcbBoruUst2.Location = new Point(660, 1);
            pcbBoruUst2.Name = "pcbBoruUst2";
            pcbBoruUst2.Size = new Size(51, 140);
            pcbBoruUst2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBoruUst2.TabIndex = 6;
            pcbBoruUst2.TabStop = false;
            pcbBoruUst2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pcbBoruUst2);
            Controls.Add(pcbBoruAlt2);
            Controls.Add(pcbFlappyBird);
            Controls.Add(lblScore);
            Controls.Add(pcbZemin);
            Controls.Add(pcbBoruUst);
            Controls.Add(pcpBoruAlt);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)pcbFlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcpBoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbZemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruAlt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBoruUst2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFlappyBird;
        private PictureBox pcpBoruAlt;
        private PictureBox pcbBoruUst;
        private PictureBox pcbZemin;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pcbBoruAlt2;
        private PictureBox pcbBoruUst2;
    }
}