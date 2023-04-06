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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonUserProfile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::PresentationLayer.Properties.Resources._1871564_200;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(12, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(47, 47);
            this.buttonHome.TabIndex = 8;
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonUserProfile
            // 
            this.buttonUserProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUserProfile.BackgroundImage = global::PresentationLayer.Properties.Resources.user;
            this.buttonUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserProfile.Location = new System.Drawing.Point(1128, 12);
            this.buttonUserProfile.Name = "buttonUserProfile";
            this.buttonUserProfile.Size = new System.Drawing.Size(47, 47);
            this.buttonUserProfile.TabIndex = 10;
            this.buttonUserProfile.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = global::PresentationLayer.Properties.Resources.free_search_icon_free_vector;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Location = new System.Drawing.Point(977, 11);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(47, 47);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearch.Location = new System.Drawing.Point(256, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(768, 47);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = " Tìm Kiếm";
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
    }
}