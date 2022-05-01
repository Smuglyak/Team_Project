namespace TeamProject
{
    partial class ScoreViewerForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.backToGameButton = new System.Windows.Forms.Button();
            this.viewScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(42, 195);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(87, 30);
            this.nextButton.TabIndex = 21;
            this.nextButton.Text = "Next Score";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(32, 147);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(213, 32);
            this.viewButton.TabIndex = 22;
            this.viewButton.Text = "Open Player Records File";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // backToGameButton
            // 
            this.backToGameButton.Location = new System.Drawing.Point(144, 195);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(83, 31);
            this.backToGameButton.TabIndex = 23;
            this.backToGameButton.Text = "Back to Game";
            this.backToGameButton.UseVisualStyleBackColor = true;
            this.backToGameButton.Click += new System.EventHandler(this.backToGameButton_Click);
            // 
            // viewScoreLabel
            // 
            this.viewScoreLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewScoreLabel.Location = new System.Drawing.Point(43, 26);
            this.viewScoreLabel.Name = "viewScoreLabel";
            this.viewScoreLabel.Size = new System.Drawing.Size(184, 23);
            this.viewScoreLabel.TabIndex = 24;
            this.viewScoreLabel.Text = "View Previous Scores";
            // 
            // ScoreViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 248);
            this.Controls.Add(this.viewScoreLabel);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.nextButton);
            this.Name = "ScoreViewerForm";
            this.Text = "View Records";
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.viewButton, 0);
            this.Controls.SetChildIndex(this.backToGameButton, 0);
            this.Controls.SetChildIndex(this.viewScoreLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button backToGameButton;
        private System.Windows.Forms.Label viewScoreLabel;
    }
}