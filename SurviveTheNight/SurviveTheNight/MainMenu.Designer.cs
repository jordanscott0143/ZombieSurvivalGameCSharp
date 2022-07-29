
namespace SurviveTheNight
{
    partial class MainMenu
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
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.buttonPlayForm = new System.Windows.Forms.Button();
            this.buttonHighScore = new System.Windows.Forms.Button();
            this.buttonHelpForm = new System.Windows.Forms.Button();
            this.buttonAboutForm = new System.Windows.Forms.Button();
            this.labelNames = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.AutoSize = true;
            this.labelMenuTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMenuTitle.Location = new System.Drawing.Point(167, 92);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(410, 53);
            this.labelMenuTitle.TabIndex = 0;
            this.labelMenuTitle.Text = "Survive The Night";
            // 
            // buttonPlayForm
            // 
            this.buttonPlayForm.BackColor = System.Drawing.Color.Brown;
            this.buttonPlayForm.Location = new System.Drawing.Point(218, 222);
            this.buttonPlayForm.Name = "buttonPlayForm";
            this.buttonPlayForm.Size = new System.Drawing.Size(321, 51);
            this.buttonPlayForm.TabIndex = 1;
            this.buttonPlayForm.Text = "Play game";
            this.buttonPlayForm.UseVisualStyleBackColor = false;
            this.buttonPlayForm.Click += new System.EventHandler(this.buttonPlayForm_Click);
            // 
            // buttonHighScore
            // 
            this.buttonHighScore.BackColor = System.Drawing.Color.Brown;
            this.buttonHighScore.Location = new System.Drawing.Point(218, 279);
            this.buttonHighScore.Name = "buttonHighScore";
            this.buttonHighScore.Size = new System.Drawing.Size(321, 51);
            this.buttonHighScore.TabIndex = 2;
            this.buttonHighScore.Text = "High Score";
            this.buttonHighScore.UseVisualStyleBackColor = false;
            this.buttonHighScore.Click += new System.EventHandler(this.buttonHighScore_Click);
            // 
            // buttonHelpForm
            // 
            this.buttonHelpForm.BackColor = System.Drawing.Color.Brown;
            this.buttonHelpForm.Location = new System.Drawing.Point(218, 336);
            this.buttonHelpForm.Name = "buttonHelpForm";
            this.buttonHelpForm.Size = new System.Drawing.Size(321, 51);
            this.buttonHelpForm.TabIndex = 3;
            this.buttonHelpForm.Text = "Help";
            this.buttonHelpForm.UseVisualStyleBackColor = false;
            this.buttonHelpForm.Click += new System.EventHandler(this.buttonHelpForm_Click);
            // 
            // buttonAboutForm
            // 
            this.buttonAboutForm.BackColor = System.Drawing.Color.Brown;
            this.buttonAboutForm.Location = new System.Drawing.Point(218, 393);
            this.buttonAboutForm.Name = "buttonAboutForm";
            this.buttonAboutForm.Size = new System.Drawing.Size(321, 51);
            this.buttonAboutForm.TabIndex = 4;
            this.buttonAboutForm.Text = "About";
            this.buttonAboutForm.UseVisualStyleBackColor = false;
            this.buttonAboutForm.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(307, 171);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(165, 17);
            this.labelNames.TabIndex = 5;
            this.labelNames.Text = "By. Jordan and Sheridan";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Brown;
            this.buttonExit.Location = new System.Drawing.Point(218, 450);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(321, 51);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.buttonAboutForm);
            this.Controls.Add(this.buttonHelpForm);
            this.Controls.Add(this.buttonHighScore);
            this.Controls.Add(this.buttonPlayForm);
            this.Controls.Add(this.labelMenuTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuTitle;
        private System.Windows.Forms.Button buttonPlayForm;
        private System.Windows.Forms.Button buttonHighScore;
        private System.Windows.Forms.Button buttonHelpForm;
        private System.Windows.Forms.Button buttonAboutForm;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Button buttonExit;
    }
}