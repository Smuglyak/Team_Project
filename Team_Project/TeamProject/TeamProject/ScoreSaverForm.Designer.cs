namespace TeamProject
{
    partial class ScoreSaverForm
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
            this.viewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.backToGameButton = new System.Windows.Forms.Button();
            this.scoreSaverLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(32, 145);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(213, 32);
            this.viewButton.TabIndex = 17;
            this.viewButton.Text = "Open Player Records File";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(89, 183);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 32);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save Score";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backToGameButton
            // 
            this.backToGameButton.Location = new System.Drawing.Point(92, 259);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(83, 31);
            this.backToGameButton.TabIndex = 19;
            this.backToGameButton.Text = "Back to Game";
            this.backToGameButton.UseVisualStyleBackColor = true;
            // 
            // scoreSaverLabel
            // 
            this.scoreSaverLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreSaverLabel.Location = new System.Drawing.Point(64, 18);
            this.scoreSaverLabel.Name = "scoreSaverLabel";
            this.scoreSaverLabel.Size = new System.Drawing.Size(148, 23);
            this.scoreSaverLabel.TabIndex = 21;
            this.scoreSaverLabel.Text = "Save Your Score";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(32, 221);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(213, 32);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Close Player Records File";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ScoreSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.scoreSaverLabel);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.viewButton);
            this.Name = "ScoreSaverForm";
            this.Text = "Records List";
            this.Controls.SetChildIndex(this.viewButton, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.backToGameButton, 0);
            this.Controls.SetChildIndex(this.scoreSaverLabel, 0);
            this.Controls.SetChildIndex(this.closeButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backToGameButton;
        private System.Windows.Forms.Label scoreSaverLabel;
        private System.Windows.Forms.Button closeButton;
    }
}