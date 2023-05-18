
namespace PresentationLayer
{
    partial class FormBookReportView
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
            this.labelContent = new System.Windows.Forms.Label();
            this.labelReportedBookId = new System.Windows.Forms.Label();
            this.labelCreateAccountId = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.labelContent);
            this.panelMain.Controls.Add(this.labelReportedBookId);
            this.panelMain.Controls.Add(this.labelCreateAccountId);
            this.panelMain.Controls.Add(this.textBoxContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(610, 450);
            this.panelMain.TabIndex = 3;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(12, 79);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(99, 25);
            this.labelContent.TabIndex = 10;
            this.labelContent.Text = "Nội dung:";
            // 
            // labelReportedBookId
            // 
            this.labelReportedBookId.AutoSize = true;
            this.labelReportedBookId.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportedBookId.Location = new System.Drawing.Point(12, 44);
            this.labelReportedBookId.Name = "labelReportedBookId";
            this.labelReportedBookId.Size = new System.Drawing.Size(86, 25);
            this.labelReportedBookId.TabIndex = 9;
            this.labelReportedBookId.Text = "Id sách: ";
            // 
            // labelCreateAccountId
            // 
            this.labelCreateAccountId.AutoSize = true;
            this.labelCreateAccountId.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccountId.Location = new System.Drawing.Point(12, 9);
            this.labelCreateAccountId.Name = "labelCreateAccountId";
            this.labelCreateAccountId.Size = new System.Drawing.Size(130, 25);
            this.labelCreateAccountId.TabIndex = 8;
            this.labelCreateAccountId.Text = "Id người tạo: ";
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.textBoxContent.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContent.Location = new System.Drawing.Point(117, 79);
            this.textBoxContent.MaximumSize = new System.Drawing.Size(480, 320);
            this.textBoxContent.MinimumSize = new System.Drawing.Size(480, 320);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(480, 320);
            this.textBoxContent.TabIndex = 7;
            // 
            // FormBookReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 489);
            this.Name = "FormBookReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sách";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelReportedBookId;
        private System.Windows.Forms.Label labelCreateAccountId;
    }
}