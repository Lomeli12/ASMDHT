
namespace ASMDHT
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button openSMDH;
        private System.Windows.Forms.Button saveSMDH;
        private System.Windows.Forms.PictureBox bannerBox;
        private System.Windows.Forms.PictureBox smallIcon;
        private System.Windows.Forms.PictureBox largeIcon;
        private System.Windows.Forms.TextBox appTitle;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Label appAuthorLabel;
        private System.Windows.Forms.TextBox appAuthor;
        private System.Windows.Forms.Label appDescripLabel;
        private System.Windows.Forms.TextBox appDescription;
        private System.Windows.Forms.PictureBox previewIcon;
        private System.Windows.Forms.ContextMenuStrip smallRightClick;
        private System.Windows.Forms.ToolStripMenuItem importSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem exportSmallIcon;
        private System.Windows.Forms.OpenFileDialog openSMDHDialog;
        private System.Windows.Forms.OpenFileDialog openIconDialog;
        private System.Windows.Forms.SaveFileDialog saveSMDHFile;
        private System.Windows.Forms.NumericUpDown appTitleNumber;
        private System.Windows.Forms.Label titleNumberLabel;
        private System.Windows.Forms.TextBox titlePreview;
        private System.Windows.Forms.TextBox descripPreview;
        private System.Windows.Forms.TextBox authorPreview;
        private System.Windows.Forms.SaveFileDialog exportImage;
        private System.Windows.Forms.ContextMenuStrip largeRightClick;
        private System.Windows.Forms.ToolStripMenuItem importLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem exportLargeIcon;
        private System.Windows.Forms.Button aboutBtn;
        
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
        public void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openSMDH = new System.Windows.Forms.Button();
            this.saveSMDH = new System.Windows.Forms.Button();
            this.bannerBox = new System.Windows.Forms.PictureBox();
            this.smallIcon = new System.Windows.Forms.PictureBox();
            this.smallRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIcon = new System.Windows.Forms.PictureBox();
            this.largeRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.appTitle = new System.Windows.Forms.TextBox();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.appAuthorLabel = new System.Windows.Forms.Label();
            this.appAuthor = new System.Windows.Forms.TextBox();
            this.appDescripLabel = new System.Windows.Forms.Label();
            this.appDescription = new System.Windows.Forms.TextBox();
            this.previewIcon = new System.Windows.Forms.PictureBox();
            this.openSMDHDialog = new System.Windows.Forms.OpenFileDialog();
            this.openIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSMDHFile = new System.Windows.Forms.SaveFileDialog();
            this.appTitleNumber = new System.Windows.Forms.NumericUpDown();
            this.titleNumberLabel = new System.Windows.Forms.Label();
            this.titlePreview = new System.Windows.Forms.TextBox();
            this.descripPreview = new System.Windows.Forms.TextBox();
            this.authorPreview = new System.Windows.Forms.TextBox();
            this.exportImage = new System.Windows.Forms.SaveFileDialog();
            this.aboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallIcon)).BeginInit();
            this.smallRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largeIcon)).BeginInit();
            this.largeRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appTitleNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // openSMDH
            // 
            this.openSMDH.Location = new System.Drawing.Point(422, 144);
            this.openSMDH.Name = "openSMDH";
            this.openSMDH.Size = new System.Drawing.Size(86, 44);
            this.openSMDH.TabIndex = 5;
            this.openSMDH.Text = "Open SMDH";
            this.openSMDH.UseVisualStyleBackColor = true;
            this.openSMDH.Click += new System.EventHandler(this.OpenSMDHClick);
            // 
            // saveSMDH
            // 
            this.saveSMDH.Location = new System.Drawing.Point(514, 144);
            this.saveSMDH.Name = "saveSMDH";
            this.saveSMDH.Size = new System.Drawing.Size(86, 44);
            this.saveSMDH.TabIndex = 6;
            this.saveSMDH.Text = "Save SMDH";
            this.saveSMDH.UseVisualStyleBackColor = true;
            this.saveSMDH.Click += new System.EventHandler(this.SaveSMDHClick);
            // 
            // bannerBox
            // 
            this.bannerBox.Image = ((System.Drawing.Image)(resources.GetObject("bannerBox.Image")));
            this.bannerBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("bannerBox.InitialImage")));
            this.bannerBox.Location = new System.Drawing.Point(12, 12);
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.Size = new System.Drawing.Size(588, 126);
            this.bannerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannerBox.TabIndex = 2;
            this.bannerBox.TabStop = false;
            // 
            // smallIcon
            // 
            this.smallIcon.ContextMenuStrip = this.smallRightClick;
            this.smallIcon.Image = ((System.Drawing.Image)(resources.GetObject("smallIcon.Image")));
            this.smallIcon.Location = new System.Drawing.Point(422, 194);
            this.smallIcon.Name = "smallIcon";
            this.smallIcon.Size = new System.Drawing.Size(48, 48);
            this.smallIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smallIcon.TabIndex = 3;
            this.smallIcon.TabStop = false;
            // 
            // smallRightClick
            // 
            this.smallRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.smallRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSmallIcon,
            this.exportSmallIcon});
            this.smallRightClick.Name = "iconRightClick";
            this.smallRightClick.Size = new System.Drawing.Size(139, 56);
            // 
            // importSmallIcon
            // 
            this.importSmallIcon.Name = "importSmallIcon";
            this.importSmallIcon.Size = new System.Drawing.Size(138, 26);
            this.importSmallIcon.Text = "Import...";
            this.importSmallIcon.Click += new System.EventHandler(this.ImportSmallIconClick);
            // 
            // exportSmallIcon
            // 
            this.exportSmallIcon.Name = "exportSmallIcon";
            this.exportSmallIcon.Size = new System.Drawing.Size(138, 26);
            this.exportSmallIcon.Text = "Export...";
            this.exportSmallIcon.Click += new System.EventHandler(this.ExportSmallIconClick);
            // 
            // largeIcon
            // 
            this.largeIcon.ContextMenuStrip = this.largeRightClick;
            this.largeIcon.Image = ((System.Drawing.Image)(resources.GetObject("largeIcon.Image")));
            this.largeIcon.Location = new System.Drawing.Point(504, 194);
            this.largeIcon.Name = "largeIcon";
            this.largeIcon.Size = new System.Drawing.Size(96, 96);
            this.largeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.largeIcon.TabIndex = 4;
            this.largeIcon.TabStop = false;
            // 
            // largeRightClick
            // 
            this.largeRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.largeRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importLargeIcon,
            this.exportLargeIcon});
            this.largeRightClick.Name = "iconRightClick";
            this.largeRightClick.Size = new System.Drawing.Size(139, 56);
            // 
            // importLargeIcon
            // 
            this.importLargeIcon.Name = "importLargeIcon";
            this.importLargeIcon.Size = new System.Drawing.Size(138, 26);
            this.importLargeIcon.Text = "Import...";
            this.importLargeIcon.Click += new System.EventHandler(this.ImportLargeIconClick);
            // 
            // exportLargeIcon
            // 
            this.exportLargeIcon.Name = "exportLargeIcon";
            this.exportLargeIcon.Size = new System.Drawing.Size(138, 26);
            this.exportLargeIcon.Text = "Export...";
            this.exportLargeIcon.Click += new System.EventHandler(this.ExportLargeIconClick);
            // 
            // appTitle
            // 
            this.appTitle.Location = new System.Drawing.Point(12, 172);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(286, 22);
            this.appTitle.TabIndex = 1;
            this.appTitle.TextChanged += new System.EventHandler(this.AppTitleTextChanged);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.Location = new System.Drawing.Point(12, 150);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(100, 19);
            this.appTitleLabel.TabIndex = 99;
            this.appTitleLabel.Text = "App Title:";
            // 
            // appAuthorLabel
            // 
            this.appAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appAuthorLabel.Location = new System.Drawing.Point(12, 197);
            this.appAuthorLabel.Name = "appAuthorLabel";
            this.appAuthorLabel.Size = new System.Drawing.Size(100, 19);
            this.appAuthorLabel.TabIndex = 99;
            this.appAuthorLabel.Text = "App Author:";
            // 
            // appAuthor
            // 
            this.appAuthor.Location = new System.Drawing.Point(12, 219);
            this.appAuthor.Name = "appAuthor";
            this.appAuthor.Size = new System.Drawing.Size(286, 22);
            this.appAuthor.TabIndex = 3;
            this.appAuthor.TextChanged += new System.EventHandler(this.AppAuthorTextChanged);
            // 
            // appDescripLabel
            // 
            this.appDescripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDescripLabel.Location = new System.Drawing.Point(12, 244);
            this.appDescripLabel.Name = "appDescripLabel";
            this.appDescripLabel.Size = new System.Drawing.Size(135, 19);
            this.appDescripLabel.TabIndex = 99;
            this.appDescripLabel.Text = "App Description:";
            // 
            // appDescription
            // 
            this.appDescription.Location = new System.Drawing.Point(12, 266);
            this.appDescription.Multiline = true;
            this.appDescription.Name = "appDescription";
            this.appDescription.Size = new System.Drawing.Size(486, 70);
            this.appDescription.TabIndex = 4;
            this.appDescription.TextChanged += new System.EventHandler(this.AppDescriptionTextChanged);
            // 
            // previewIcon
            // 
            this.previewIcon.BackColor = System.Drawing.Color.Fuchsia;
            this.previewIcon.Image = ((System.Drawing.Image)(resources.GetObject("previewIcon.Image")));
            this.previewIcon.Location = new System.Drawing.Point(27, 27);
            this.previewIcon.Name = "previewIcon";
            this.previewIcon.Size = new System.Drawing.Size(97, 97);
            this.previewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewIcon.TabIndex = 11;
            this.previewIcon.TabStop = false;
            // 
            // openSMDHDialog
            // 
            this.openSMDHDialog.Filter = "SMDH Files|*.smdh|All Files|*.*";
            this.openSMDHDialog.Title = "Open SMDH File";
            this.openSMDHDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenSMDHDialogFileOk);
            // 
            // openIconDialog
            // 
            this.openIconDialog.Filter = "PNG Image|*.png|All Files|*.*";
            this.openIconDialog.Title = "Open PNG Icon";
            this.openIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenIconDialogFileOk);
            // 
            // saveSMDHFile
            // 
            this.saveSMDHFile.DefaultExt = "smdh";
            this.saveSMDHFile.Filter = "SMDH Files|*.smdh";
            this.saveSMDHFile.Title = "Save SMDH File";
            this.saveSMDHFile.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveSMDHFileFileOk);
            // 
            // appTitleNumber
            // 
            this.appTitleNumber.Location = new System.Drawing.Point(304, 172);
            this.appTitleNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.appTitleNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appTitleNumber.Name = "appTitleNumber";
            this.appTitleNumber.Size = new System.Drawing.Size(112, 22);
            this.appTitleNumber.TabIndex = 2;
            this.appTitleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appTitleNumber.ValueChanged += new System.EventHandler(this.AppTitleNumberValueChanged);
            // 
            // titleNumberLabel
            // 
            this.titleNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNumberLabel.Location = new System.Drawing.Point(304, 150);
            this.titleNumberLabel.Name = "titleNumberLabel";
            this.titleNumberLabel.Size = new System.Drawing.Size(100, 19);
            this.titleNumberLabel.TabIndex = 13;
            this.titleNumberLabel.Text = "Title Number:";
            // 
            // titlePreview
            // 
            this.titlePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.titlePreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlePreview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titlePreview.Enabled = false;
            this.titlePreview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePreview.Location = new System.Drawing.Point(147, 23);
            this.titlePreview.Name = "titlePreview";
            this.titlePreview.ReadOnly = true;
            this.titlePreview.Size = new System.Drawing.Size(439, 23);
            this.titlePreview.TabIndex = 99;
            // 
            // descripPreview
            // 
            this.descripPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.descripPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripPreview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.descripPreview.Enabled = false;
            this.descripPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripPreview.Location = new System.Drawing.Point(147, 50);
            this.descripPreview.Multiline = true;
            this.descripPreview.Name = "descripPreview";
            this.descripPreview.ReadOnly = true;
            this.descripPreview.Size = new System.Drawing.Size(439, 59);
            this.descripPreview.TabIndex = 99;
            // 
            // authorPreview
            // 
            this.authorPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.authorPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorPreview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.authorPreview.Enabled = false;
            this.authorPreview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorPreview.Location = new System.Drawing.Point(300, 108);
            this.authorPreview.Name = "authorPreview";
            this.authorPreview.ReadOnly = true;
            this.authorPreview.Size = new System.Drawing.Size(286, 23);
            this.authorPreview.TabIndex = 99;
            this.authorPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exportImage
            // 
            this.exportImage.DefaultExt = "png";
            this.exportImage.Filter = "PNG Image|*.png|All Files|*.*";
            this.exportImage.Title = "Export Icon";
            this.exportImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportImageFileOk);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(504, 309);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(96, 27);
            this.aboutBtn.TabIndex = 7;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.AboutBtnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 351);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.authorPreview);
            this.Controls.Add(this.descripPreview);
            this.Controls.Add(this.titlePreview);
            this.Controls.Add(this.titleNumberLabel);
            this.Controls.Add(this.appTitleNumber);
            this.Controls.Add(this.previewIcon);
            this.Controls.Add(this.appDescripLabel);
            this.Controls.Add(this.appDescription);
            this.Controls.Add(this.appAuthorLabel);
            this.Controls.Add(this.appAuthor);
            this.Controls.Add(this.appTitleLabel);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.largeIcon);
            this.Controls.Add(this.smallIcon);
            this.Controls.Add(this.bannerBox);
            this.Controls.Add(this.saveSMDH);
            this.Controls.Add(this.openSMDH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ASMDHT";
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallIcon)).EndInit();
            this.smallRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.largeIcon)).EndInit();
            this.largeRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appTitleNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
