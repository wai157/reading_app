﻿
namespace PresentationLayer
{
    partial class Header
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonUserProfile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Controls.Add(this.buttonAddBook);
            this.panel1.Controls.Add(this.buttonNotification);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonUserProfile);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 72);
            this.panel1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Cambria", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearch.Location = new System.Drawing.Point(256, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(724, 48);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = " Tìm Kiếm";
            this.textBoxSearch.GotFocus += new System.EventHandler(this.textBoxSearch_RemoveText);
            this.textBoxSearch.LostFocus += new System.EventHandler(this.textBoxSearch_AddText);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLogIn.BackColor = System.Drawing.Color.White;
            this.buttonLogIn.BackgroundImage = global::PresentationLayer.Properties.Resources.login;
            this.buttonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogIn.Location = new System.Drawing.Point(1128, 11);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(47, 47);
            this.buttonLogIn.TabIndex = 5;
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBook.BackgroundImage = global::PresentationLayer.Properties.Resources._111365_200;
            this.buttonAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBook.Location = new System.Drawing.Point(65, 12);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(47, 47);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonNotification
            // 
            this.buttonNotification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNotification.BackgroundImage = global::PresentationLayer.Properties.Resources.bell1;
            this.buttonNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNotification.Location = new System.Drawing.Point(1075, 12);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(47, 47);
            this.buttonNotification.TabIndex = 4;
            this.buttonNotification.UseVisualStyleBackColor = true;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::PresentationLayer.Properties.Resources.Home;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(12, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(47, 47);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonUserProfile
            // 
            this.buttonUserProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            this.buttonUserProfile.BackgroundImage = global::PresentationLayer.Properties.Resources.user;
            this.buttonUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserProfile.Location = new System.Drawing.Point(1128, 12);
            this.buttonUserProfile.Name = "buttonUserProfile";
            this.buttonUserProfile.Size = new System.Drawing.Size(47, 47);
            this.buttonUserProfile.TabIndex = 3;
            this.buttonUserProfile.UseVisualStyleBackColor = false;
            this.buttonUserProfile.Click += new System.EventHandler(this.buttonUserProfile_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            this.buttonSearch.BackgroundImage = global::PresentationLayer.Properties.Resources.free_search_icon_free_vector;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Location = new System.Drawing.Point(977, 11);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(47, 47);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1280, 72);
            this.Load += new System.EventHandler(this.Header_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonUserProfile;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonLogIn;
    }
}
