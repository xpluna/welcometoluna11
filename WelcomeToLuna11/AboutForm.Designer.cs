namespace WelcomeToLuna11
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.okayButton_about = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discordAboutLink = new System.Windows.Forms.LinkLabel();
            this.ourWebsiteLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okayButton_about
            // 
            this.okayButton_about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okayButton_about.Location = new System.Drawing.Point(153, 203);
            this.okayButton_about.Name = "okayButton_about";
            this.okayButton_about.Size = new System.Drawing.Size(75, 23);
            this.okayButton_about.TabIndex = 0;
            this.okayButton_about.Text = "Okay!";
            this.okayButton_about.UseVisualStyleBackColor = true;
            this.okayButton_about.Click += new System.EventHandler(this.okayButton_about_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // discordAboutLink
            // 
            this.discordAboutLink.AutoSize = true;
            this.discordAboutLink.Location = new System.Drawing.Point(12, 175);
            this.discordAboutLink.Name = "discordAboutLink";
            this.discordAboutLink.Size = new System.Drawing.Size(66, 13);
            this.discordAboutLink.TabIndex = 3;
            this.discordAboutLink.TabStop = true;
            this.discordAboutLink.Text = "Our Discord!";
            this.discordAboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordAboutLink_LinkClicked);
            // 
            // ourWebsiteLink
            // 
            this.ourWebsiteLink.AutoSize = true;
            this.ourWebsiteLink.Location = new System.Drawing.Point(84, 175);
            this.ourWebsiteLink.Name = "ourWebsiteLink";
            this.ourWebsiteLink.Size = new System.Drawing.Size(69, 13);
            this.ourWebsiteLink.TabIndex = 3;
            this.ourWebsiteLink.TabStop = true;
            this.ourWebsiteLink.Text = "Our Website!";
            this.ourWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ourWebsiteLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 238);
            this.Controls.Add(this.ourWebsiteLink);
            this.Controls.Add(this.discordAboutLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okayButton_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Luna11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okayButton_about;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel discordAboutLink;
        private System.Windows.Forms.LinkLabel ourWebsiteLink;
    }
}