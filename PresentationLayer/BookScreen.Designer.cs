﻿
namespace PresentationLayer
{
    partial class BookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookScreen));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRate = new System.Windows.Forms.Button();
            this.linkLabelReport = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelFollowed = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.btdFollow = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.linkLabelGenre = new System.Windows.Forms.LinkLabel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageTableOfContent = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelChapters = new System.Windows.Forms.FlowLayoutPanel();
            this.header1 = new PresentationLayer.Header();
            this.buttonAddChap = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageTableOfContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.header1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(128, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 612);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonRate);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelReport);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEdit);
            this.splitContainer1.Panel1.Controls.Add(this.labelRating);
            this.splitContainer1.Panel1.Controls.Add(this.labelFollowed);
            this.splitContainer1.Panel1.Controls.Add(this.labelViews);
            this.splitContainer1.Panel1.Controls.Add(this.btdFollow);
            this.splitContainer1.Panel1.Controls.Add(this.btnRead);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxCover);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 612);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonRate
            // 
            this.buttonRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonRate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonRate.Location = new System.Drawing.Point(64, 454);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 40);
            this.buttonRate.TabIndex = 17;
            this.buttonRate.Text = "đánh giá";
            this.buttonRate.UseVisualStyleBackColor = false;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // linkLabelReport
            // 
            this.linkLabelReport.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.linkLabelReport.AutoSize = true;
            this.linkLabelReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelReport.LinkColor = System.Drawing.Color.Black;
            this.linkLabelReport.Location = new System.Drawing.Point(24, 585);
            this.linkLabelReport.Name = "linkLabelReport";
            this.linkLabelReport.Size = new System.Drawing.Size(101, 19);
            this.linkLabelReport.TabIndex = 6;
            this.linkLabelReport.TabStop = true;
            this.linkLabelReport.Text = "Báo cáo truyện";
            this.linkLabelReport.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelReport.Click += new System.EventHandler(this.linkLabelReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::PresentationLayer.Properties.Resources.edit_246;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(16, 20);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(32, 32);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonChangeGeneralInfo_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(60, 429);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(101, 19);
            this.labelRating.TabIndex = 5;
            this.labelRating.Text = "Đánh giá: 5.0/5";
            // 
            // labelFollowed
            // 
            this.labelFollowed.AutoSize = true;
            this.labelFollowed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFollowed.Location = new System.Drawing.Point(60, 405);
            this.labelFollowed.Name = "labelFollowed";
            this.labelFollowed.Size = new System.Drawing.Size(99, 19);
            this.labelFollowed.TabIndex = 4;
            this.labelFollowed.Text = "Lượt theo dõi: ";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViews.Location = new System.Drawing.Point(60, 381);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(69, 19);
            this.labelViews.TabIndex = 3;
            this.labelViews.Text = "Lượt đọc:";
            // 
            // btdFollow
            // 
            this.btdFollow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btdFollow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.btdFollow.Location = new System.Drawing.Point(176, 500);
            this.btdFollow.Name = "btdFollow";
            this.btdFollow.Size = new System.Drawing.Size(144, 48);
            this.btdFollow.TabIndex = 2;
            this.btdFollow.Text = "Theo dõi";
            this.btdFollow.UseVisualStyleBackColor = false;
            this.btdFollow.Click += new System.EventHandler(this.btdFollow_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.btnRead.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.btnRead.Location = new System.Drawing.Point(64, 500);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(106, 48);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Đọc";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(64, 20);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(256, 341);
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Controls.Add(this.tabPageTableOfContent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.AutoScroll = true;
            this.tabPageAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageAbout.Controls.Add(this.linkLabelAuthor);
            this.tabPageAbout.Controls.Add(this.linkLabelGenre);
            this.tabPageAbout.Controls.Add(this.labelDescription);
            this.tabPageAbout.Controls.Add(this.labelGenres);
            this.tabPageAbout.Controls.Add(this.labelAuthor);
            this.tabPageAbout.Controls.Add(this.labelName);
            this.tabPageAbout.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAbout.Location = new System.Drawing.Point(4, 32);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(628, 576);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "Giới thiệu";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAuthor.LinkColor = System.Drawing.Color.Black;
            this.linkLabelAuthor.Location = new System.Drawing.Point(83, 103);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(105, 25);
            this.linkLabelAuthor.TabIndex = 5;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "linkLabel1";
            this.linkLabelAuthor.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // linkLabelGenre
            // 
            this.linkLabelGenre.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.linkLabelGenre.AutoSize = true;
            this.linkLabelGenre.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGenre.LinkColor = System.Drawing.Color.Black;
            this.linkLabelGenre.Location = new System.Drawing.Point(90, 139);
            this.linkLabelGenre.Name = "linkLabelGenre";
            this.linkLabelGenre.Size = new System.Drawing.Size(105, 25);
            this.linkLabelGenre.TabIndex = 4;
            this.linkLabelGenre.TabStop = true;
            this.linkLabelGenre.Text = "linkLabel1";
            this.linkLabelGenre.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelGenre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGenre_LinkClicked);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(6, 175);
            this.labelDescription.MaximumSize = new System.Drawing.Size(602, 0);
            this.labelDescription.MinimumSize = new System.Drawing.Size(602, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelDescription.Size = new System.Drawing.Size(602, 510);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenres.Location = new System.Drawing.Point(6, 139);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(91, 25);
            this.labelGenres.TabIndex = 2;
            this.labelGenres.Text = "Thể loại:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(6, 103);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(84, 25);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Tác giả:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 3);
            this.labelName.MaximumSize = new System.Drawing.Size(605, 100);
            this.labelName.MinimumSize = new System.Drawing.Size(605, 100);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(5);
            this.labelName.Size = new System.Drawing.Size(605, 100);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Lorem Ipsum";
            // 
            // tabPageTableOfContent
            // 
            this.tabPageTableOfContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageTableOfContent.Controls.Add(this.flowLayoutPanelChapters);
            this.tabPageTableOfContent.Location = new System.Drawing.Point(4, 32);
            this.tabPageTableOfContent.Name = "tabPageTableOfContent";
            this.tabPageTableOfContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTableOfContent.Size = new System.Drawing.Size(628, 576);
            this.tabPageTableOfContent.TabIndex = 1;
            this.tabPageTableOfContent.Text = "Mục lục";
            // 
            // flowLayoutPanelChapters
            // 
            this.flowLayoutPanelChapters.AutoScroll = true;
            this.flowLayoutPanelChapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.flowLayoutPanelChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChapters.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelChapters.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelChapters.Name = "flowLayoutPanelChapters";
            this.flowLayoutPanelChapters.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanelChapters.Size = new System.Drawing.Size(622, 570);
            this.flowLayoutPanelChapters.TabIndex = 0;
            // 
            // header1
            // 
            this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.header1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1280, 72);
            this.header1.TabIndex = 0;
            // 
            // buttonAddChap
            // 
            this.buttonAddChap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonAddChap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddChap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonAddChap.Location = new System.Drawing.Point(3, 0);
            this.buttonAddChap.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonAddChap.Name = "buttonAddChap";
            this.buttonAddChap.Size = new System.Drawing.Size(595, 30);
            this.buttonAddChap.TabIndex = 18;
            this.buttonAddChap.Text = "+";
            this.buttonAddChap.UseVisualStyleBackColor = false;
            this.buttonAddChap.Click += new System.EventHandler(this.buttonAddChap_Click);
            // 
            // labelError
            // 
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(332, 76);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(126, 47);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Không tìm thấy sách!";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.Name = "BookScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.tabPageTableOfContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btdFollow;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private Header header1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabPage tabPageTableOfContent;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelFollowed;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChapters;
        private System.Windows.Forms.Button buttonAddChap;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.LinkLabel linkLabelGenre;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.LinkLabel linkLabelReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Label labelError;
    }
}
