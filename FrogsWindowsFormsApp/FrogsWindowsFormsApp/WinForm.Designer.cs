namespace FrogsWindowsFormsApp
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.winPictureBox = new System.Windows.Forms.PictureBox();
            this.winTextLabel = new System.Windows.Forms.Label();
            this.countMotionsWinLabel = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winPictureBox
            // 
            this.winPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("winPictureBox.Image")));
            this.winPictureBox.InitialImage = null;
            this.winPictureBox.Location = new System.Drawing.Point(9, 9);
            this.winPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.winPictureBox.Name = "winPictureBox";
            this.winPictureBox.Size = new System.Drawing.Size(613, 356);
            this.winPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.winPictureBox.TabIndex = 0;
            this.winPictureBox.TabStop = false;
            // 
            // winTextLabel
            // 
            this.winTextLabel.AutoSize = true;
            this.winTextLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winTextLabel.Location = new System.Drawing.Point(12, 369);
            this.winTextLabel.Name = "winTextLabel";
            this.winTextLabel.Size = new System.Drawing.Size(514, 25);
            this.winTextLabel.TabIndex = 1;
            this.winTextLabel.Text = "Поздравляем, вы победили! Сделанных ходов - ";
            // 
            // countMotionsWinLabel
            // 
            this.countMotionsWinLabel.AutoSize = true;
            this.countMotionsWinLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countMotionsWinLabel.Location = new System.Drawing.Point(564, 369);
            this.countMotionsWinLabel.Name = "countMotionsWinLabel";
            this.countMotionsWinLabel.Size = new System.Drawing.Size(24, 25);
            this.countMotionsWinLabel.TabIndex = 2;
            this.countMotionsWinLabel.Text = "0";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoreLabel.Location = new System.Drawing.Point(1, 409);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(571, 19);
            this.bestScoreLabel.TabIndex = 3;
            this.bestScoreLabel.Text = "Лучший результат для прохождения игры 24 хода, попробуйте еще разок";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.countMotionsWinLabel);
            this.Controls.Add(this.winTextLabel);
            this.Controls.Add(this.winPictureBox);
            this.Name = "WinForm";
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox winPictureBox;
        private System.Windows.Forms.Label winTextLabel;
        private System.Windows.Forms.Label countMotionsWinLabel;
        private System.Windows.Forms.Label bestScoreLabel;
    }
}