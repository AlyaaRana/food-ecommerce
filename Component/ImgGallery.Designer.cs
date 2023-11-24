namespace multipledashboard.Component
{
    partial class ImgGallery
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_gallery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gallery)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_gallery
            // 
            this.pb_gallery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_gallery.Location = new System.Drawing.Point(0, 0);
            this.pb_gallery.Name = "pb_gallery";
            this.pb_gallery.Size = new System.Drawing.Size(257, 258);
            this.pb_gallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gallery.TabIndex = 0;
            this.pb_gallery.TabStop = false;
            this.pb_gallery.Click += new System.EventHandler(this.pb_gallery_Click);
            // 
            // ImgGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_gallery);
            this.Name = "ImgGallery";
            this.Size = new System.Drawing.Size(257, 258);
            ((System.ComponentModel.ISupportInitialize)(this.pb_gallery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gallery;
    }
}
