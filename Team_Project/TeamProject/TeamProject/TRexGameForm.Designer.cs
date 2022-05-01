namespace TeamProject
{
    partial class tRexGameForm
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
            this.floorPictureBox = new System.Windows.Forms.PictureBox();
            this.tRexPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // floorPictureBox
            // 
            this.floorPictureBox.BackColor = System.Drawing.Color.Black;
            this.floorPictureBox.Location = new System.Drawing.Point(-8, 278);
            this.floorPictureBox.Name = "floorPictureBox";
            this.floorPictureBox.Size = new System.Drawing.Size(772, 50);
            this.floorPictureBox.TabIndex = 0;
            this.floorPictureBox.TabStop = false;
            // 
            // tRexPictureBox
            // 
            this.tRexPictureBox.Image = global::TeamProject.Properties.Resources.running;
            this.tRexPictureBox.Location = new System.Drawing.Point(56, 236);
            this.tRexPictureBox.Name = "tRexPictureBox";
            this.tRexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.tRexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tRexPictureBox.TabIndex = 1;
            this.tRexPictureBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TeamProject.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(673, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TeamProject.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(475, 246);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(654, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(62, 20);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 20;
            this.scoreTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(13, 13);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(0, 20);
            this.gameOverLabel.TabIndex = 5;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(287, 67);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(0, 22);
            this.startLabel.TabIndex = 6;
            // 
            // tRexGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(748, 321);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.floorPictureBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tRexPictureBox);
            this.Name = "tRexGameForm";
            this.Tag = "obstacle";
            this.Text = "T-Rex Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.floorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floorPictureBox;
        private System.Windows.Forms.PictureBox tRexPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label startLabel;
    }
}

