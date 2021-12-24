namespace WindowsFormsApplication17
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Tpipe = new System.Windows.Forms.PictureBox();
            this.Bpipe = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bpipe)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(1, 441);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(400, 42);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird.BackgroundImage")));
            this.bird.Location = new System.Drawing.Point(60, 174);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(81, 60);
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // Tpipe
            // 
            this.Tpipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tpipe.BackgroundImage")));
            this.Tpipe.Location = new System.Drawing.Point(275, 0);
            this.Tpipe.Name = "Tpipe";
            this.Tpipe.Size = new System.Drawing.Size(96, 137);
            this.Tpipe.TabIndex = 2;
            this.Tpipe.TabStop = false;
            // 
            // Bpipe
            // 
            this.Bpipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bpipe.BackgroundImage")));
            this.Bpipe.Location = new System.Drawing.Point(133, 350);
            this.Bpipe.Name = "Bpipe";
            this.Bpipe.Size = new System.Drawing.Size(93, 120);
            this.Bpipe.TabIndex = 3;
            this.Bpipe.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(93, 441);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(34, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = " 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(400, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Bpipe);
            this.Controls.Add(this.Tpipe);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bpipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox Tpipe;
        private System.Windows.Forms.PictureBox Bpipe;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label label1;
    }
}

