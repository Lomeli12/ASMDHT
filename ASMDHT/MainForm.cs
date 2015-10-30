﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ASMDHT {
    public partial class MainForm : Form {
        SMDH smdhFile;
        Image small, large;
        int imageType = 0;
        
        public MainForm() {
            InitializeComponent();
            smdhFile = new SMDH();
            small = this.smallIcon.Image;
            large = this.largeIcon.Image;
        }
        
        void OpenSMDHDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!String.IsNullOrWhiteSpace(this.openSMDHDialog.FileName)) {
                this.smallIcon.Image = small;
                this.largeIcon.Image = large;
                
                this.previewIcon.Image = large;
                this.titlePreview.Text = "";
                this.authorPreview.Text = "";
                this.descripPreview.Text = "";
                this.smdhFile.Load(this.openSMDHDialog.FileName);
                this.smallIcon.Image = this.smdhFile.SmallIcon;
                this.largeIcon.Image = this.smdhFile.BigIcon;
                
                this.appAuthor.Text = this.smdhFile.GetPublisher((int)this.appTitleNumber.Value - 1);
                this.appTitle.Text = this.smdhFile.GetShortDescription((int)this.appTitleNumber.Value - 1);
                this.appDescription.Text = this.smdhFile.GetLongDescription((int)this.appTitleNumber.Value - 1);
                this.previewIcon.Image = this.smdhFile.BigIcon;
                this.titlePreview.Text = this.appTitle.Text;
                this.authorPreview.Text = this.appAuthor.Text;
                this.descripPreview.Text = this.appDescription.Text;
            }
        }
        void SaveSMDHFileFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            this.smdhFile.SmallIcon = new Bitmap(this.smallIcon.Image);
            this.smdhFile.BigIcon = new Bitmap(this.largeIcon.Image);
            this.smdhFile.SetPublisher((int)this.appTitleNumber.Value - 1, this.appAuthor.Text);
            this.smdhFile.SetShortDescription((int)this.appTitleNumber.Value - 1, this.appTitle.Text);
            this.smdhFile.SetLongDescription((int)this.appTitleNumber.Value - 1, this.appDescription.Text);
            this.smdhFile.Save(this.saveSMDHFile.FileName);
        }
        
        void OpenSMDHClick(object sender, EventArgs e) {
            this.openSMDHDialog.ShowDialog();
        }
        void SaveSMDHClick(object sender, EventArgs e) {
            this.saveSMDHFile.ShowDialog();
        }
        
        void AppTitleTextChanged(object sender, EventArgs e) {
            this.titlePreview.Text = this.appTitle.Text;
        }
        
        void AppAuthorTextChanged(object sender, EventArgs e) {
            this.authorPreview.Text = this.appAuthor.Text;
        }
        
        void AppDescriptionTextChanged(object sender, EventArgs e) {
            this.descripPreview.Text = this.appDescription.Text;
        }
        
        void OpenIconDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            if (imageType == 1) {
                this.largeIcon.Image = (Image) new Bitmap(openIconDialog.FileName);
                this.previewIcon.Image = this.largeIcon.Image;
            } else this.smallIcon.Image = (Image) new Bitmap(openIconDialog.FileName);
        }
        
        void ExportImageFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            if (imageType == 1) new Bitmap(this.largeIcon.Image, 48, 48).Save(this.exportImage.FileName);
            else this.smallIcon.Image.Save(this.exportImage.FileName);
        }
        
        void ExportSmallIconClick(object sender, EventArgs e) {
            this.imageType = 0;
            this.exportImage.ShowDialog();
        }
        
        void ExportLargeIconClick(object sender, EventArgs e) {
            this.imageType = 1;
            this.exportImage.ShowDialog();
        }
        
        void ImportSmallIconClick(object sender, EventArgs e) {
            this.imageType = 0;
            this.openIconDialog.ShowDialog();
        }
        
        void ImportLargeIconClick(object sender, EventArgs e) {
            this.imageType = 1;
            this.openIconDialog.ShowDialog();
        }
        void AboutBtnClick(object sender, EventArgs e) {
            new AboutDialog().ShowDialog();
        }
    }
}