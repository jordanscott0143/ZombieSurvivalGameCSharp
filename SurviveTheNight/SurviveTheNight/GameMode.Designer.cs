
namespace SurviveTheNight
{
    partial class GameMode
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
            this.buttonEasyMode = new System.Windows.Forms.Button();
            this.buttonHardMode = new System.Windows.Forms.Button();
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEasyMode
            // 
            this.buttonEasyMode.Location = new System.Drawing.Point(143, 319);
            this.buttonEasyMode.Name = "buttonEasyMode";
            this.buttonEasyMode.Size = new System.Drawing.Size(222, 38);
            this.buttonEasyMode.TabIndex = 0;
            this.buttonEasyMode.Text = "Easy Mode";
            this.buttonEasyMode.UseVisualStyleBackColor = true;
            this.buttonEasyMode.Click += new System.EventHandler(this.buttonEasyMode_Click);
            // 
            // buttonHardMode
            // 
            this.buttonHardMode.Location = new System.Drawing.Point(416, 319);
            this.buttonHardMode.Name = "buttonHardMode";
            this.buttonHardMode.Size = new System.Drawing.Size(239, 38);
            this.buttonHardMode.TabIndex = 1;
            this.buttonHardMode.Text = "Hard Mode";
            this.buttonHardMode.UseVisualStyleBackColor = true;
            this.buttonHardMode.Click += new System.EventHandler(this.buttonHardMode_Click);
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.AutoSize = true;
            this.labelMenuTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMenuTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMenuTitle.Location = new System.Drawing.Point(63, 157);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(684, 55);
            this.labelMenuTitle.TabIndex = 8;
            this.labelMenuTitle.Text = "Survive The Night Game Mode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.labelMenuTitle);
            this.Controls.Add(this.buttonHardMode);
            this.Controls.Add(this.buttonEasyMode);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEasyMode;
        private System.Windows.Forms.Button buttonHardMode;
        private System.Windows.Forms.Label labelMenuTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}