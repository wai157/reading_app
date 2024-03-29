﻿
namespace PresentationLayer
{
    partial class FormEditBook
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
            this.components = new System.ComponentModel.Container();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelectCover = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(628, 448);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(160, 40);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.buttonDelete);
            this.panelMain.Controls.Add(this.buttonConfirm);
            this.panelMain.Controls.Add(this.buttonSelectCover);
            this.panelMain.Controls.Add(this.comboBoxGenre);
            this.panelMain.Controls.Add(this.textBoxDescription);
            this.panelMain.Controls.Add(this.textBoxAuthor);
            this.panelMain.Controls.Add(this.textBoxName);
            this.panelMain.Controls.Add(this.labelDescription);
            this.panelMain.Controls.Add(this.labelGenres);
            this.panelMain.Controls.Add(this.labelAuthor);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.pictureBoxCover);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 500);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PresentationLayer.Properties.Resources._665049;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "    Sách của bạn sẽ cần được kiểm duyệt trước khi thực hiện các thay đổi.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(522, 448);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelectCover
            // 
            this.buttonSelectCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonSelectCover.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonSelectCover.Location = new System.Drawing.Point(12, 226);
            this.buttonSelectCover.Name = "buttonSelectCover";
            this.buttonSelectCover.Size = new System.Drawing.Size(156, 30);
            this.buttonSelectCover.TabIndex = 9;
            this.buttonSelectCover.Text = "Chọn bìa sách";
            this.buttonSelectCover.UseVisualStyleBackColor = false;
            this.buttonSelectCover.Click += new System.EventHandler(this.buttonSelectCover_Click);
            this.buttonSelectCover.Validated += new System.EventHandler(this.buttonSelectCover_Validated);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(286, 94);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(200, 31);
            this.comboBoxGenre.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(286, 135);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(480, 300);
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(480, 300);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(480, 300);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.Validated += new System.EventHandler(this.textBoxDescription_Validated);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(286, 53);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(480, 32);
            this.textBoxAuthor.TabIndex = 6;
            this.textBoxAuthor.Validated += new System.EventHandler(this.textBoxAuthor_Validated);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(286, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(480, 32);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(172, 135);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(121, 31);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Nội dung:";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenres.Location = new System.Drawing.Point(172, 94);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(110, 31);
            this.labelGenres.TabIndex = 3;
            this.labelGenres.Text = "Thể loại:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(172, 53);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(98, 31);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Tác giả:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(172, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(117, 31);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Tên sách:";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(156, 208);
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 539);
            this.Name = "FormEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditBook_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSelectCover;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
    }
}