﻿
namespace PresentationLayer
{
    partial class UserProfileScreen
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.flowLayoutPanelLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelUpload = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonFollowed = new System.Windows.Forms.Button();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.panelAccountInfo = new System.Windows.Forms.Panel();
            this.buttonChangeGeneralInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelLogInInfo = new System.Windows.Forms.Label();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.labelGeneralInfo = new System.Windows.Forms.Label();
            this.header1 = new PresentationLayer.Header();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.header1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.buttonUpload);
            this.panel1.Controls.Add(this.flowLayoutPanelLibrary);
            this.panel1.Controls.Add(this.flowLayoutPanelHistory);
            this.panel1.Controls.Add(this.flowLayoutPanelUpload);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonHistory);
            this.panel1.Controls.Add(this.buttonFollowed);
            this.panel1.Controls.Add(this.buttonAccountInfo);
            this.panel1.Controls.Add(this.panelAccountInfo);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.panel1.Location = new System.Drawing.Point(128, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 612);
            this.panel1.TabIndex = 1;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonUpload.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(0, 253);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(256, 50);
            this.buttonUpload.TabIndex = 17;
            this.buttonUpload.Text = "Truyện đã đăng";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // flowLayoutPanelLibrary
            // 
            this.flowLayoutPanelLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelLibrary.Enabled = false;
            this.flowLayoutPanelLibrary.Location = new System.Drawing.Point(256, 0);
            this.flowLayoutPanelLibrary.Name = "flowLayoutPanelLibrary";
            this.flowLayoutPanelLibrary.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanelLibrary.Size = new System.Drawing.Size(768, 612);
            this.flowLayoutPanelLibrary.TabIndex = 16;
            this.flowLayoutPanelLibrary.Visible = false;
            // 
            // flowLayoutPanelHistory
            // 
            this.flowLayoutPanelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelHistory.Enabled = false;
            this.flowLayoutPanelHistory.Location = new System.Drawing.Point(256, 0);
            this.flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            this.flowLayoutPanelHistory.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanelHistory.Size = new System.Drawing.Size(768, 612);
            this.flowLayoutPanelHistory.TabIndex = 15;
            this.flowLayoutPanelHistory.Visible = false;
            // 
            // flowLayoutPanelUpload
            // 
            this.flowLayoutPanelUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelUpload.Enabled = false;
            this.flowLayoutPanelUpload.Location = new System.Drawing.Point(256, 0);
            this.flowLayoutPanelUpload.Name = "flowLayoutPanelUpload";
            this.flowLayoutPanelUpload.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanelUpload.Size = new System.Drawing.Size(768, 612);
            this.flowLayoutPanelUpload.TabIndex = 17;
            this.flowLayoutPanelUpload.Visible = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 512);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(256, 50);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Đăng xuất";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonHistory.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.Location = new System.Drawing.Point(0, 197);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(256, 50);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "Lịch sử đọc";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonFollowed
            // 
            this.buttonFollowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonFollowed.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFollowed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFollowed.Location = new System.Drawing.Point(0, 141);
            this.buttonFollowed.Name = "buttonFollowed";
            this.buttonFollowed.Size = new System.Drawing.Size(256, 50);
            this.buttonFollowed.TabIndex = 2;
            this.buttonFollowed.Text = "Tủ đọc";
            this.buttonFollowed.UseVisualStyleBackColor = false;
            this.buttonFollowed.Click += new System.EventHandler(this.buttonFollowed_Click);
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonAccountInfo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAccountInfo.Location = new System.Drawing.Point(0, 85);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(256, 50);
            this.buttonAccountInfo.TabIndex = 1;
            this.buttonAccountInfo.Text = "Thông tin tài khoản";
            this.buttonAccountInfo.UseVisualStyleBackColor = false;
            this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
            // 
            // panelAccountInfo
            // 
            this.panelAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAccountInfo.Controls.Add(this.buttonChangeGeneralInfo);
            this.panelAccountInfo.Controls.Add(this.buttonSave);
            this.panelAccountInfo.Controls.Add(this.textBoxConfirmNewPassword);
            this.panelAccountInfo.Controls.Add(this.textBoxNewPassword);
            this.panelAccountInfo.Controls.Add(this.textBoxCurrentPassword);
            this.panelAccountInfo.Controls.Add(this.labelChangePassword);
            this.panelAccountInfo.Controls.Add(this.labelEmail);
            this.panelAccountInfo.Controls.Add(this.labelUsername);
            this.panelAccountInfo.Controls.Add(this.labelDOB);
            this.panelAccountInfo.Controls.Add(this.labelSex);
            this.panelAccountInfo.Controls.Add(this.labelName);
            this.panelAccountInfo.Controls.Add(this.pictureBoxAvatar);
            this.panelAccountInfo.Controls.Add(this.labelLogInInfo);
            this.panelAccountInfo.Controls.Add(this.labelAvatar);
            this.panelAccountInfo.Controls.Add(this.labelGeneralInfo);
            this.panelAccountInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAccountInfo.Location = new System.Drawing.Point(256, 0);
            this.panelAccountInfo.Name = "panelAccountInfo";
            this.panelAccountInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelAccountInfo.Size = new System.Drawing.Size(768, 612);
            this.panelAccountInfo.TabIndex = 0;
            // 
            // buttonChangeGeneralInfo
            // 
            this.buttonChangeGeneralInfo.BackgroundImage = global::PresentationLayer.Properties.Resources.edit_246;
            this.buttonChangeGeneralInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChangeGeneralInfo.Location = new System.Drawing.Point(255, 16);
            this.buttonChangeGeneralInfo.Name = "buttonChangeGeneralInfo";
            this.buttonChangeGeneralInfo.Size = new System.Drawing.Size(32, 32);
            this.buttonChangeGeneralInfo.TabIndex = 14;
            this.buttonChangeGeneralInfo.UseVisualStyleBackColor = true;
            this.buttonChangeGeneralInfo.Click += new System.EventHandler(this.buttonChangeGeneralInfo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonSave.Location = new System.Drawing.Point(292, 560);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(149, 522);
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(218, 32);
            this.textBoxConfirmNewPassword.TabIndex = 12;
            this.textBoxConfirmNewPassword.Text = "Xác nhận mật khẩu mới";
            this.textBoxConfirmNewPassword.GotFocus += new System.EventHandler(this.textBox_RemoveText);
            this.textBoxConfirmNewPassword.LostFocus += new System.EventHandler(this.textBoxConfirmNewPassword_AddText);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNewPassword.Location = new System.Drawing.Point(149, 483);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(218, 32);
            this.textBoxNewPassword.TabIndex = 11;
            this.textBoxNewPassword.Text = "Mật khẩu mới";
            this.textBoxNewPassword.GotFocus += new System.EventHandler(this.textBox_RemoveText);
            this.textBoxNewPassword.LostFocus += new System.EventHandler(this.textBoxNewPassword_AddText);
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(149, 445);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(218, 32);
            this.textBoxCurrentPassword.TabIndex = 10;
            this.textBoxCurrentPassword.Text = "Mật khẩu hiện tại";
            this.textBoxCurrentPassword.GotFocus += new System.EventHandler(this.textBox_RemoveText);
            this.textBoxCurrentPassword.LostFocus += new System.EventHandler(this.textBoxCurrentPassword_AddText);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.Location = new System.Drawing.Point(16, 448);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(137, 25);
            this.labelChangePassword.TabIndex = 9;
            this.labelChangePassword.Text = "Đổi mật khẩu:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(16, 413);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(75, 25);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email: ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(16, 378);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(152, 25);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Tên đăng nhập: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(16, 236);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(112, 25);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Ngày sinh: ";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(16, 271);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(102, 25);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "Giới tính: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 201);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Họ và tên: ";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.White;
            this.pictureBoxAvatar.BackgroundImage = global::PresentationLayer.Properties.Resources._634011;
            this.pictureBoxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(141, 63);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelLogInInfo
            // 
            this.labelLogInInfo.AutoSize = true;
            this.labelLogInInfo.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInInfo.Location = new System.Drawing.Point(13, 316);
            this.labelLogInInfo.Margin = new System.Windows.Forms.Padding(3);
            this.labelLogInInfo.Name = "labelLogInInfo";
            this.labelLogInInfo.Padding = new System.Windows.Forms.Padding(10);
            this.labelLogInInfo.Size = new System.Drawing.Size(314, 59);
            this.labelLogInInfo.TabIndex = 2;
            this.labelLogInInfo.Text = "Thông tin đăng nhập";
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvatar.Location = new System.Drawing.Point(15, 65);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(130, 25);
            this.labelAvatar.TabIndex = 1;
            this.labelAvatar.Text = "Ảnh đại diện:";
            // 
            // labelGeneralInfo
            // 
            this.labelGeneralInfo.AutoSize = true;
            this.labelGeneralInfo.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneralInfo.Location = new System.Drawing.Point(13, 3);
            this.labelGeneralInfo.Margin = new System.Windows.Forms.Padding(3);
            this.labelGeneralInfo.Name = "labelGeneralInfo";
            this.labelGeneralInfo.Padding = new System.Windows.Forms.Padding(10);
            this.labelGeneralInfo.Size = new System.Drawing.Size(257, 59);
            this.labelGeneralInfo.TabIndex = 0;
            this.labelGeneralInfo.Text = "Thông tin chung";
            // 
            // header1
            // 
            this.header1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.header1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1280, 72);
            this.header1.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UserProfileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.Name = "UserProfileScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelAccountInfo.ResumeLayout(false);
            this.panelAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private Header header1;
        private System.Windows.Forms.Panel panelAccountInfo;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonFollowed;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.Label labelGeneralInfo;
        private System.Windows.Forms.Label labelLogInInfo;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button buttonChangeGeneralInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLibrary;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUpload;
    }
}
