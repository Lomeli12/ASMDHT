
namespace ASMDHT
{
    partial class AboutDialog
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label infoBox;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.infoBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(115, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(120, 120);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            this.logoImage.Click += new System.EventHandler(this.LogoImageClick);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 145);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(318, 217);
            this.infoBox.TabIndex = 1;
            this.infoBox.Text = resources.GetString("infoBox.Text");
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 371);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.logoImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
