
namespace Uni_Companion
{
    partial class startPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.pictureSignUp = new System.Windows.Forms.PictureBox();
            this.pictureSignIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSignUp
            // 
            this.pictureSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureSignUp.Image")));
            this.pictureSignUp.Location = new System.Drawing.Point(917, 12);
            this.pictureSignUp.Name = "pictureSignUp";
            this.pictureSignUp.Size = new System.Drawing.Size(97, 49);
            this.pictureSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSignUp.TabIndex = 0;
            this.pictureSignUp.TabStop = false;
            this.pictureSignUp.Click += new System.EventHandler(this.pictureSignUp_Click);
            // 
            // pictureSignIn
            // 
            this.pictureSignIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureSignIn.Image")));
            this.pictureSignIn.Location = new System.Drawing.Point(1061, 12);
            this.pictureSignIn.Name = "pictureSignIn";
            this.pictureSignIn.Size = new System.Drawing.Size(100, 49);
            this.pictureSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSignIn.TabIndex = 2;
            this.pictureSignIn.TabStop = false;
            this.pictureSignIn.Click += new System.EventHandler(this.pictureSignIn_Click);
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 663);
            this.Controls.Add(this.pictureSignIn);
            this.Controls.Add(this.pictureSignUp);
            this.DoubleBuffered = true;
            this.Name = "startPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uni Companion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSignIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSignUp;
        private System.Windows.Forms.PictureBox pictureSignIn;
    }
}