namespace Windows_Background_Web_View
{
    partial class Settings
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
            this.InstallButton = new System.Windows.Forms.Button();
            this.RemoveInstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(12, 12);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(148, 48);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install to startup";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveInstall
            // 
            this.RemoveInstall.Location = new System.Drawing.Point(166, 12);
            this.RemoveInstall.Name = "RemoveInstall";
            this.RemoveInstall.Size = new System.Drawing.Size(167, 48);
            this.RemoveInstall.TabIndex = 1;
            this.RemoveInstall.Text = "Remove from startup";
            this.RemoveInstall.UseVisualStyleBackColor = true;
            this.RemoveInstall.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 71);
            this.Controls.Add(this.RemoveInstall);
            this.Controls.Add(this.InstallButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button RemoveInstall;
    }
}