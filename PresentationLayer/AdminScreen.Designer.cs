
namespace PresentationLayer
{
    partial class AdminScreen
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
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.header1 = new PresentationLayer.Header();
            this.tabPageBookReport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedBookId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageBookReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.buttonAddBook);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.header1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 17;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBook.BackgroundImage = global::PresentationLayer.Properties.Resources._111365_200;
            this.buttonAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBook.Location = new System.Drawing.Point(69, 12);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(47, 47);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(128, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 612);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPageBookReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.AutoScroll = true;
            this.tabPageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.tabPageBooks.Controls.Add(this.flowLayoutPanelBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 34);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1016, 574);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Sách";
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Padding = new System.Windows.Forms.Padding(19, 10, 0, 16);
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(1010, 568);
            this.flowLayoutPanelBooks.TabIndex = 0;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.AutoScroll = true;
            this.tabPageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.tabPageUsers.Controls.Add(this.flowLayoutPanelAccounts);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 34);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1016, 574);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Người dùng";
            // 
            // flowLayoutPanelAccounts
            // 
            this.flowLayoutPanelAccounts.AutoScroll = true;
            this.flowLayoutPanelAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAccounts.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelAccounts.Name = "flowLayoutPanelAccounts";
            this.flowLayoutPanelAccounts.Padding = new System.Windows.Forms.Padding(25, 10, 0, 15);
            this.flowLayoutPanelAccounts.Size = new System.Drawing.Size(1010, 568);
            this.flowLayoutPanelAccounts.TabIndex = 0;
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
            // tabPageBookReport
            // 
            this.tabPageBookReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.tabPageBookReport.Controls.Add(this.buttonDelete);
            this.tabPageBookReport.Controls.Add(this.buttonView);
            this.tabPageBookReport.Controls.Add(this.dataGridView1);
            this.tabPageBookReport.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookReport.Name = "tabPageBookReport";
            this.tabPageBookReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookReport.Size = new System.Drawing.Size(1016, 574);
            this.tabPageBookReport.TabIndex = 2;
            this.tabPageBookReport.Text = "Báo cáo sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportId,
            this.CreateAccountId,
            this.ReportedBookId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reportId
            // 
            this.reportId.HeaderText = "Id";
            this.reportId.Name = "reportId";
            this.reportId.ReadOnly = true;
            // 
            // CreateAccountId
            // 
            this.CreateAccountId.HeaderText = "Id người dùng";
            this.CreateAccountId.Name = "CreateAccountId";
            this.CreateAccountId.ReadOnly = true;
            // 
            // ReportedBookId
            // 
            this.ReportedBookId.ActiveLinkColor = System.Drawing.Color.Black;
            this.ReportedBookId.HeaderText = "Id sách";
            this.ReportedBookId.LinkColor = System.Drawing.Color.Black;
            this.ReportedBookId.Name = "ReportedBookId";
            this.ReportedBookId.ReadOnly = true;
            this.ReportedBookId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReportedBookId.TrackVisitedState = false;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(935, 509);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 40);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "Xem";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(854, 509);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 40);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageBookReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBooks;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAccounts;
        private System.Windows.Forms.TabPage tabPageBookReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAccountId;
        private System.Windows.Forms.DataGridViewLinkColumn ReportedBookId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonView;
    }
}
