
namespace PresentationLayer
{
    partial class MainScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelHotBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAllBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAllBooks = new System.Windows.Forms.Label();
            this.labelHot = new System.Windows.Forms.Label();
            this.header1 = new PresentationLayer.Header();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelMain.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.flowLayoutPanelHotBooks);
            this.panel2.Controls.Add(this.flowLayoutPanelAllBooks);
            this.panel2.Controls.Add(this.labelAllBooks);
            this.panel2.Controls.Add(this.labelHot);
            this.panel2.Location = new System.Drawing.Point(128, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 612);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanelHotBooks
            // 
            this.flowLayoutPanelHotBooks.AutoSize = true;
            this.flowLayoutPanelHotBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelHotBooks.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanelHotBooks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelHotBooks.MaximumSize = new System.Drawing.Size(1024, 0);
            this.flowLayoutPanelHotBooks.Name = "flowLayoutPanelHotBooks";
            this.flowLayoutPanelHotBooks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanelHotBooks.Size = new System.Drawing.Size(20, 0);
            this.flowLayoutPanelHotBooks.TabIndex = 29;
            // 
            // flowLayoutPanelAllBooks
            // 
            this.flowLayoutPanelAllBooks.AutoSize = true;
            this.flowLayoutPanelAllBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAllBooks.Location = new System.Drawing.Point(0, 367);
            this.flowLayoutPanelAllBooks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanelAllBooks.MaximumSize = new System.Drawing.Size(1024, 0);
            this.flowLayoutPanelAllBooks.Name = "flowLayoutPanelAllBooks";
            this.flowLayoutPanelAllBooks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 16);
            this.flowLayoutPanelAllBooks.Size = new System.Drawing.Size(20, 16);
            this.flowLayoutPanelAllBooks.TabIndex = 28;
            // 
            // labelAllBooks
            // 
            this.labelAllBooks.AutoSize = true;
            this.labelAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelAllBooks.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllBooks.Location = new System.Drawing.Point(3, 305);
            this.labelAllBooks.Margin = new System.Windows.Forms.Padding(3);
            this.labelAllBooks.Name = "labelAllBooks";
            this.labelAllBooks.Padding = new System.Windows.Forms.Padding(10);
            this.labelAllBooks.Size = new System.Drawing.Size(215, 59);
            this.labelAllBooks.TabIndex = 27;
            this.labelAllBooks.Text = "Tất cả truyện";
            // 
            // labelHot
            // 
            this.labelHot.AutoSize = true;
            this.labelHot.BackColor = System.Drawing.Color.Transparent;
            this.labelHot.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHot.Location = new System.Drawing.Point(3, 3);
            this.labelHot.Margin = new System.Windows.Forms.Padding(3);
            this.labelHot.Name = "labelHot";
            this.labelHot.Padding = new System.Windows.Forms.Padding(10);
            this.labelHot.Size = new System.Drawing.Size(213, 59);
            this.labelHot.TabIndex = 3;
            this.labelHot.Text = "Truyện HOT";
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
            this.header1.TabIndex = 15;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHot;
        private Header header1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAllBooks;
        private System.Windows.Forms.Label labelAllBooks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHotBooks;
    }
}
