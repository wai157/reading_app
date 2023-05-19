
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageBookReport = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewBookReport = new System.Windows.Forms.Button();
            this.dataGridViewBookReports = new System.Windows.Forms.DataGridView();
            this.reportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedBookId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPageBookVerifications = new System.Windows.Forms.TabPage();
            this.buttonVerifyAll = new System.Windows.Forms.Button();
            this.buttonViewVerify = new System.Windows.Forms.Button();
            this.dGVUnverifiedBooks = new System.Windows.Forms.DataGridView();
            this.header1 = new PresentationLayer.Header();
            this.dataGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageBookReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookReports)).BeginInit();
            this.tabPageBookVerifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnverifiedBooks)).BeginInit();
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
            this.panelMain.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
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
            this.tabControl1.Controls.Add(this.tabPageBookVerifications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageBooks.Controls.Add(this.flowLayoutPanelBooks);
            this.tabPageBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
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
            this.tabPageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageUsers.Controls.Add(this.flowLayoutPanelAccounts);
            this.tabPageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
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
            // tabPageBookReport
            // 
            this.tabPageBookReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageBookReport.Controls.Add(this.buttonDelete);
            this.tabPageBookReport.Controls.Add(this.buttonViewBookReport);
            this.tabPageBookReport.Controls.Add(this.dataGridViewBookReports);
            this.tabPageBookReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.tabPageBookReport.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookReport.Name = "tabPageBookReport";
            this.tabPageBookReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookReport.Size = new System.Drawing.Size(1016, 574);
            this.tabPageBookReport.TabIndex = 2;
            this.tabPageBookReport.Text = "Báo cáo sách";
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
            // buttonViewBookReport
            // 
            this.buttonViewBookReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonViewBookReport.Location = new System.Drawing.Point(935, 509);
            this.buttonViewBookReport.Name = "buttonViewBookReport";
            this.buttonViewBookReport.Size = new System.Drawing.Size(75, 40);
            this.buttonViewBookReport.TabIndex = 1;
            this.buttonViewBookReport.Text = "Xem";
            this.buttonViewBookReport.UseVisualStyleBackColor = false;
            this.buttonViewBookReport.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridViewBookReports
            // 
            this.dataGridViewBookReports.AllowUserToAddRows = false;
            this.dataGridViewBookReports.AllowUserToDeleteRows = false;
            this.dataGridViewBookReports.AllowUserToResizeColumns = false;
            this.dataGridViewBookReports.AllowUserToResizeRows = false;
            this.dataGridViewBookReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.dataGridViewBookReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportId,
            this.CreateAccountId,
            this.ReportedBookId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookReports.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewBookReports.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookReports.MultiSelect = false;
            this.dataGridViewBookReports.Name = "dataGridViewBookReports";
            this.dataGridViewBookReports.ReadOnly = true;
            this.dataGridViewBookReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBookReports.RowTemplate.Height = 30;
            this.dataGridViewBookReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookReports.Size = new System.Drawing.Size(1010, 500);
            this.dataGridViewBookReports.TabIndex = 0;
            this.dataGridViewBookReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reportId
            // 
            this.reportId.HeaderText = "Id";
            this.reportId.Name = "reportId";
            this.reportId.ReadOnly = true;
            // 
            // CreateAccountId
            // 
            this.CreateAccountId.HeaderText = "Tên người dùng";
            this.CreateAccountId.Name = "CreateAccountId";
            this.CreateAccountId.ReadOnly = true;
            // 
            // ReportedBookId
            // 
            this.ReportedBookId.ActiveLinkColor = System.Drawing.Color.Black;
            this.ReportedBookId.HeaderText = "Tên sách";
            this.ReportedBookId.LinkColor = System.Drawing.Color.Black;
            this.ReportedBookId.Name = "ReportedBookId";
            this.ReportedBookId.ReadOnly = true;
            this.ReportedBookId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReportedBookId.TrackVisitedState = false;
            // 
            // tabPageBookVerifications
            // 
            this.tabPageBookVerifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageBookVerifications.Controls.Add(this.buttonVerifyAll);
            this.tabPageBookVerifications.Controls.Add(this.buttonViewVerify);
            this.tabPageBookVerifications.Controls.Add(this.dGVUnverifiedBooks);
            this.tabPageBookVerifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.tabPageBookVerifications.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookVerifications.Name = "tabPageBookVerifications";
            this.tabPageBookVerifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookVerifications.Size = new System.Drawing.Size(1016, 574);
            this.tabPageBookVerifications.TabIndex = 3;
            this.tabPageBookVerifications.Text = "Kiểm duyệt truyện";
            // 
            // buttonVerifyAll
            // 
            this.buttonVerifyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonVerifyAll.Location = new System.Drawing.Point(779, 509);
            this.buttonVerifyAll.Name = "buttonVerifyAll";
            this.buttonVerifyAll.Size = new System.Drawing.Size(150, 40);
            this.buttonVerifyAll.TabIndex = 3;
            this.buttonVerifyAll.Text = "Duyệt tất cả";
            this.buttonVerifyAll.UseVisualStyleBackColor = false;
            this.buttonVerifyAll.Click += new System.EventHandler(this.buttonVerifyAll_Click);
            // 
            // buttonViewVerify
            // 
            this.buttonViewVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonViewVerify.Location = new System.Drawing.Point(935, 509);
            this.buttonViewVerify.Name = "buttonViewVerify";
            this.buttonViewVerify.Size = new System.Drawing.Size(75, 40);
            this.buttonViewVerify.TabIndex = 2;
            this.buttonViewVerify.Text = "Xem";
            this.buttonViewVerify.UseVisualStyleBackColor = false;
            this.buttonViewVerify.Click += new System.EventHandler(this.buttonViewVerify_Click);
            // 
            // dGVUnverifiedBooks
            // 
            this.dGVUnverifiedBooks.AllowUserToAddRows = false;
            this.dGVUnverifiedBooks.AllowUserToDeleteRows = false;
            this.dGVUnverifiedBooks.AllowUserToResizeColumns = false;
            this.dGVUnverifiedBooks.AllowUserToResizeRows = false;
            this.dGVUnverifiedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUnverifiedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.dGVUnverifiedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUnverifiedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewId,
            this.dataGridViewUsername,
            this.dataGridViewBookName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUnverifiedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVUnverifiedBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGVUnverifiedBooks.Location = new System.Drawing.Point(3, 3);
            this.dGVUnverifiedBooks.MultiSelect = false;
            this.dGVUnverifiedBooks.Name = "dGVUnverifiedBooks";
            this.dGVUnverifiedBooks.ReadOnly = true;
            this.dGVUnverifiedBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVUnverifiedBooks.RowTemplate.Height = 30;
            this.dGVUnverifiedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUnverifiedBooks.Size = new System.Drawing.Size(1010, 500);
            this.dGVUnverifiedBooks.TabIndex = 1;
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
            // dataGridViewId
            // 
            this.dataGridViewId.HeaderText = "Id sách";
            this.dataGridViewId.Name = "dataGridViewId";
            this.dataGridViewId.ReadOnly = true;
            // 
            // dataGridViewUsername
            // 
            this.dataGridViewUsername.HeaderText = "Tên người đăng";
            this.dataGridViewUsername.Name = "dataGridViewUsername";
            this.dataGridViewUsername.ReadOnly = true;
            // 
            // dataGridViewBookName
            // 
            this.dataGridViewBookName.HeaderText = "Tên sách";
            this.dataGridViewBookName.Name = "dataGridViewBookName";
            this.dataGridViewBookName.ReadOnly = true;
            this.dataGridViewBookName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookReports)).EndInit();
            this.tabPageBookVerifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnverifiedBooks)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAccounts;
        private System.Windows.Forms.TabPage tabPageBookReport;
        private System.Windows.Forms.DataGridView dataGridViewBookReports;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewBookReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAccountId;
        private System.Windows.Forms.DataGridViewLinkColumn ReportedBookId;
        private System.Windows.Forms.TabPage tabPageBookVerifications;
        private System.Windows.Forms.Button buttonViewVerify;
        private System.Windows.Forms.DataGridView dGVUnverifiedBooks;
        private System.Windows.Forms.Button buttonVerifyAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewBookName;
    }
}
