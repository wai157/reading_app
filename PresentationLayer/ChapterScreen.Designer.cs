
namespace PresentationLayer
{
    partial class ChapterScreen
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContent = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.header1 = new PresentationLayer.Header();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.buttonBack);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.header1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::PresentationLayer.Properties.Resources.back_vector_icon_256;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(65, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(47, 47);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelContent);
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(128, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 612);
            this.panel1.TabIndex = 1;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(20, 70);
            this.labelContent.MaximumSize = new System.Drawing.Size(984, 0);
            this.labelContent.MinimumSize = new System.Drawing.Size(984, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(10);
            this.labelContent.Size = new System.Drawing.Size(984, 82);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "Line1\nLine2";
            // 
            // panelLine
            // 
            this.panelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLine.Location = new System.Drawing.Point(128, 66);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(768, 1);
            this.panelLine.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(20, 3);
            this.labelTitle.MaximumSize = new System.Drawing.Size(984, 0);
            this.labelTitle.MinimumSize = new System.Drawing.Size(984, 60);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelTitle.Size = new System.Drawing.Size(984, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ChapterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.Name = "ChapterScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Header header1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBack;
    }
}
