﻿
namespace PresentationLayer
{
    partial class FormEditChap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteChap = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNo = new System.Windows.Forms.MaskedTextBox();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(403, 132);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(160, 40);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.buttonDeleteChap);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.labelFile);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.maskedTextBoxNo);
            this.panel1.Controls.Add(this.labelNo);
            this.panel1.Controls.Add(this.labelContent);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 181);
            this.panel1.TabIndex = 1;
            // 
            // buttonDeleteChap
            // 
            this.buttonDeleteChap.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteChap.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteChap.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteChap.Location = new System.Drawing.Point(317, 132);
            this.buttonDeleteChap.Name = "buttonDeleteChap";
            this.buttonDeleteChap.Size = new System.Drawing.Size(80, 40);
            this.buttonDeleteChap.TabIndex = 15;
            this.buttonDeleteChap.Text = "Xóa";
            this.buttonDeleteChap.UseVisualStyleBackColor = false;
            this.buttonDeleteChap.Click += new System.EventHandler(this.buttonDeleteChap_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonDel.Location = new System.Drawing.Point(244, 92);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(30, 30);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "X";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Visible = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.labelFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFile.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(163, 92);
            this.labelFile.MaximumSize = new System.Drawing.Size(300, 30);
            this.labelFile.MinimumSize = new System.Drawing.Size(2, 30);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(2, 30);
            this.labelFile.TabIndex = 13;
            this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFile.Visible = false;
            this.labelFile.Validated += new System.EventHandler(this.labelFile_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.buttonAdd.Location = new System.Drawing.Point(163, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Chọn tệp ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(163, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(380, 32);
            this.textBoxTitle.TabIndex = 10;
            this.textBoxTitle.Validated += new System.EventHandler(this.textBoxTitle_Validated);
            // 
            // maskedTextBoxNo
            // 
            this.maskedTextBoxNo.AllowPromptAsInput = false;
            this.maskedTextBoxNo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNo.Location = new System.Drawing.Point(163, 8);
            this.maskedTextBoxNo.Mask = "00000000";
            this.maskedTextBoxNo.Name = "maskedTextBoxNo";
            this.maskedTextBoxNo.PromptChar = ' ';
            this.maskedTextBoxNo.Size = new System.Drawing.Size(100, 32);
            this.maskedTextBoxNo.TabIndex = 9;
            this.maskedTextBoxNo.ValidatingType = typeof(int);
            this.maskedTextBoxNo.Click += new System.EventHandler(this.maskedTextBoxNo_RemoveText);
            this.maskedTextBoxNo.Validated += new System.EventHandler(this.maskedTextBoxNo_Validated);
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(12, 9);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(145, 31);
            this.labelNo.TabIndex = 8;
            this.labelNo.Text = "Chương số: ";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(12, 91);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(128, 31);
            this.labelContent.TabIndex = 7;
            this.labelContent.Text = "Nội dung: ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 31);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Tiêu đề: ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormEditChap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditChap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa chương";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditChap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNo;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonDeleteChap;
    }
}