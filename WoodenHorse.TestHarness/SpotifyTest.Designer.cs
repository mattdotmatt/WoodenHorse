namespace WoodenHorse.TestHarness
{
    partial class SpotifyTest
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
            this.btnSpotify = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSpotify
            // 
            this.btnSpotify.Location = new System.Drawing.Point(13, 13);
            this.btnSpotify.Name = "btnSpotify";
            this.btnSpotify.Size = new System.Drawing.Size(75, 23);
            this.btnSpotify.TabIndex = 0;
            this.btnSpotify.Text = "Test Spotify";
            this.btnSpotify.UseVisualStyleBackColor = true;
            this.btnSpotify.Click += new System.EventHandler(this.btnSpotify_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(13, 43);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(267, 218);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // SpotifyTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSpotify);
            this.Name = "SpotifyTest";
            this.Text = "SpotifyTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpotify;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}