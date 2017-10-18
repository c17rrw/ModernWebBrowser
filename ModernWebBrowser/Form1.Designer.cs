namespace ModernWebBrowser
{
    partial class webBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(webBrowser));
            this.addressBar = new System.Windows.Forms.TextBox();
            this.webDisplay = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(429, 82);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(608, 20);
            this.addressBar.TabIndex = 1;
            // 
            // webDisplay
            // 
            this.webDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.webDisplay.Location = new System.Drawing.Point(292, 118);
            this.webDisplay.Multiline = true;
            this.webDisplay.Name = "webDisplay";
            this.webDisplay.ReadOnly = true;
            this.webDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.webDisplay.Size = new System.Drawing.Size(1021, 649);
            this.webDisplay.TabIndex = 2;
            this.webDisplay.Visible = false;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.Location = new System.Drawing.Point(378, 79);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(35, 25);
            this.homeButton.TabIndex = 3;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(1053, 82);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 20);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Go";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1134, 82);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 20);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1463, 810);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.webDisplay);
            this.Controls.Add(this.addressBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "webBrowser";
            this.Text = "Heriot Watt Web Broswer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.TextBox webDisplay;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

