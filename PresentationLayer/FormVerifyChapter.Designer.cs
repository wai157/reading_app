
namespace PresentationLayer
{
    partial class FormChapterVerification
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonUnverify = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonUnverify);
            this.panelMain.Controls.Add(this.buttonVerify);
            this.panelMain.Controls.Add(this.textBoxContent);
            this.panelMain.Controls.Add(this.labelContent);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.labelNo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 565);
            this.panelMain.TabIndex = 0;
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Cambria", 20F);
            this.labelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNo.Location = new System.Drawing.Point(12, 12);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(151, 32);
            this.labelNo.TabIndex = 2;
            this.labelNo.Text = "Chương số: ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 20F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.Location = new System.Drawing.Point(12, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Tiêu đề: ";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Cambria", 20F);
            this.labelContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelContent.Location = new System.Drawing.Point(12, 94);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(132, 32);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "Nội dung: ";
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.textBoxContent.Font = new System.Drawing.Font("Cambria", 16F);
            this.textBoxContent.Location = new System.Drawing.Point(150, 94);
            this.textBoxContent.MaximumSize = new System.Drawing.Size(638, 459);
            this.textBoxContent.MinimumSize = new System.Drawing.Size(638, 459);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(638, 459);
            this.textBoxContent.TabIndex = 9;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonVerify.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonVerify.Font = new System.Drawing.Font("Cambria", 16F);
            this.buttonVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonVerify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVerify.Location = new System.Drawing.Point(18, 427);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(108, 60);
            this.buttonVerify.TabIndex = 10;
            this.buttonVerify.Text = "Duyệt";
            this.buttonVerify.UseVisualStyleBackColor = false;
            // 
            // buttonUnverify
            // 
            this.buttonUnverify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonUnverify.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonUnverify.Font = new System.Drawing.Font("Cambria", 16F);
            this.buttonUnverify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonUnverify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUnverify.Location = new System.Drawing.Point(18, 493);
            this.buttonUnverify.Name = "buttonUnverify";
            this.buttonUnverify.Size = new System.Drawing.Size(108, 60);
            this.buttonUnverify.TabIndex = 11;
            this.buttonUnverify.Text = "Không Duyệt";
            this.buttonUnverify.UseVisualStyleBackColor = false;
            // 
            // FormChapterVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChapterVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm duyệt chương";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChapterVerification_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonUnverify;
    }
}