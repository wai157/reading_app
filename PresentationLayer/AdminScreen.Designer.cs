
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tabPageBookReport = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonViewBookReport = new System.Windows.Forms.Button();
            this.dataGridViewBookReports = new System.Windows.Forms.DataGridView();
            this.reportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportedBookId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPageBookVerifications = new System.Windows.Forms.TabPage();
            this.buttonVerifyAllBooks = new System.Windows.Forms.Button();
            this.buttonViewVerifyBook = new System.Windows.Forms.Button();
            this.dGVUnverifiedBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageChapterVerifications = new System.Windows.Forms.TabPage();
            this.buttonVerifyAllChapters = new System.Windows.Forms.Button();
            this.buttonViewVerifyChapter = new System.Windows.Forms.Button();
            this.dGVUnverifiedChapters = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVUsers = new System.Windows.Forms.DataGridView();
            this.buttonEditUserInfo = new System.Windows.Forms.Button();
            this.header1 = new PresentationLayer.Header();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageBookReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookReports)).BeginInit();
            this.tabPageBookVerifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnverifiedBooks)).BeginInit();
            this.tabPageChapterVerifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnverifiedChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPageChapterVerifications);
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
            this.tabPageUsers.Controls.Add(this.buttonEditUserInfo);
            this.tabPageUsers.Controls.Add(this.dGVUsers);
            this.tabPageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.tabPageUsers.Location = new System.Drawing.Point(4, 34);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1016, 574);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Người dùng";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookReports.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.tabPageBookVerifications.Controls.Add(this.buttonVerifyAllBooks);
            this.tabPageBookVerifications.Controls.Add(this.buttonViewVerifyBook);
            this.tabPageBookVerifications.Controls.Add(this.dGVUnverifiedBooks);
            this.tabPageBookVerifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.tabPageBookVerifications.Location = new System.Drawing.Point(4, 34);
            this.tabPageBookVerifications.Name = "tabPageBookVerifications";
            this.tabPageBookVerifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookVerifications.Size = new System.Drawing.Size(1016, 574);
            this.tabPageBookVerifications.TabIndex = 3;
            this.tabPageBookVerifications.Text = "Kiểm duyệt truyện";
            // 
            // buttonVerifyAllBooks
            // 
            this.buttonVerifyAllBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonVerifyAllBooks.Location = new System.Drawing.Point(779, 509);
            this.buttonVerifyAllBooks.Name = "buttonVerifyAllBooks";
            this.buttonVerifyAllBooks.Size = new System.Drawing.Size(150, 40);
            this.buttonVerifyAllBooks.TabIndex = 3;
            this.buttonVerifyAllBooks.Text = "Duyệt tất cả";
            this.buttonVerifyAllBooks.UseVisualStyleBackColor = false;
            this.buttonVerifyAllBooks.Click += new System.EventHandler(this.buttonVerifyAll_Click);
            // 
            // buttonViewVerifyBook
            // 
            this.buttonViewVerifyBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonViewVerifyBook.Location = new System.Drawing.Point(935, 509);
            this.buttonViewVerifyBook.Name = "buttonViewVerifyBook";
            this.buttonViewVerifyBook.Size = new System.Drawing.Size(75, 40);
            this.buttonViewVerifyBook.TabIndex = 2;
            this.buttonViewVerifyBook.Text = "Xem";
            this.buttonViewVerifyBook.UseVisualStyleBackColor = false;
            this.buttonViewVerifyBook.Click += new System.EventHandler(this.buttonViewVerify_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUnverifiedBooks.DefaultCellStyle = dataGridViewCellStyle3;
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
            // tabPageChapterVerifications
            // 
            this.tabPageChapterVerifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.tabPageChapterVerifications.Controls.Add(this.buttonVerifyAllChapters);
            this.tabPageChapterVerifications.Controls.Add(this.buttonViewVerifyChapter);
            this.tabPageChapterVerifications.Controls.Add(this.dGVUnverifiedChapters);
            this.tabPageChapterVerifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.tabPageChapterVerifications.Location = new System.Drawing.Point(4, 34);
            this.tabPageChapterVerifications.Name = "tabPageChapterVerifications";
            this.tabPageChapterVerifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChapterVerifications.Size = new System.Drawing.Size(1016, 574);
            this.tabPageChapterVerifications.TabIndex = 4;
            this.tabPageChapterVerifications.Text = "Kiểm duyệt chương";
            // 
            // buttonVerifyAllChapters
            // 
            this.buttonVerifyAllChapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonVerifyAllChapters.Location = new System.Drawing.Point(779, 509);
            this.buttonVerifyAllChapters.Name = "buttonVerifyAllChapters";
            this.buttonVerifyAllChapters.Size = new System.Drawing.Size(150, 40);
            this.buttonVerifyAllChapters.TabIndex = 5;
            this.buttonVerifyAllChapters.Text = "Duyệt tất cả";
            this.buttonVerifyAllChapters.UseVisualStyleBackColor = false;
            this.buttonVerifyAllChapters.Click += new System.EventHandler(this.buttonVerifyAllChapters_Click);
            // 
            // buttonViewVerifyChapter
            // 
            this.buttonViewVerifyChapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonViewVerifyChapter.Location = new System.Drawing.Point(935, 509);
            this.buttonViewVerifyChapter.Name = "buttonViewVerifyChapter";
            this.buttonViewVerifyChapter.Size = new System.Drawing.Size(75, 40);
            this.buttonViewVerifyChapter.TabIndex = 4;
            this.buttonViewVerifyChapter.Text = "Xem";
            this.buttonViewVerifyChapter.UseVisualStyleBackColor = false;
            this.buttonViewVerifyChapter.Click += new System.EventHandler(this.button2_Click);
            // 
            // dGVUnverifiedChapters
            // 
            this.dGVUnverifiedChapters.AllowUserToAddRows = false;
            this.dGVUnverifiedChapters.AllowUserToDeleteRows = false;
            this.dGVUnverifiedChapters.AllowUserToResizeColumns = false;
            this.dGVUnverifiedChapters.AllowUserToResizeRows = false;
            this.dGVUnverifiedChapters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUnverifiedChapters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.dGVUnverifiedChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUnverifiedChapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.No});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUnverifiedChapters.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVUnverifiedChapters.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGVUnverifiedChapters.Location = new System.Drawing.Point(3, 3);
            this.dGVUnverifiedChapters.MultiSelect = false;
            this.dGVUnverifiedChapters.Name = "dGVUnverifiedChapters";
            this.dGVUnverifiedChapters.ReadOnly = true;
            this.dGVUnverifiedChapters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVUnverifiedChapters.RowTemplate.Height = 30;
            this.dGVUnverifiedChapters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUnverifiedChapters.Size = new System.Drawing.Size(1010, 500);
            this.dGVUnverifiedChapters.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id chương";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên người đăng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // No
            // 
            this.No.HeaderText = "Chương số";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // dGVUsers
            // 
            this.dGVUsers.AllowUserToAddRows = false;
            this.dGVUsers.AllowUserToDeleteRows = false;
            this.dGVUsers.AllowUserToResizeColumns = false;
            this.dGVUsers.AllowUserToResizeRows = false;
            this.dGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.dGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.role});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(134)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGVUsers.Location = new System.Drawing.Point(3, 3);
            this.dGVUsers.MultiSelect = false;
            this.dGVUsers.Name = "dGVUsers";
            this.dGVUsers.ReadOnly = true;
            this.dGVUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVUsers.RowTemplate.Height = 30;
            this.dGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUsers.Size = new System.Drawing.Size(1010, 500);
            this.dGVUsers.TabIndex = 3;
            // 
            // buttonEditUserInfo
            // 
            this.buttonEditUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonEditUserInfo.Location = new System.Drawing.Point(869, 509);
            this.buttonEditUserInfo.Name = "buttonEditUserInfo";
            this.buttonEditUserInfo.Size = new System.Drawing.Size(140, 40);
            this.buttonEditUserInfo.TabIndex = 4;
            this.buttonEditUserInfo.Text = "Chỉnh sửa";
            this.buttonEditUserInfo.UseVisualStyleBackColor = false;
            this.buttonEditUserInfo.Click += new System.EventHandler(this.buttonEditUserInfo_Click);
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên người dùng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Quyền";
            this.role.Name = "role";
            this.role.ReadOnly = true;
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
            this.tabPageChapterVerifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnverifiedChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageBookReport;
        private System.Windows.Forms.DataGridView dataGridViewBookReports;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonViewBookReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAccountId;
        private System.Windows.Forms.DataGridViewLinkColumn ReportedBookId;
        private System.Windows.Forms.TabPage tabPageBookVerifications;
        private System.Windows.Forms.Button buttonViewVerifyBook;
        private System.Windows.Forms.DataGridView dGVUnverifiedBooks;
        private System.Windows.Forms.Button buttonVerifyAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewBookName;
        private System.Windows.Forms.TabPage tabPageChapterVerifications;
        private System.Windows.Forms.DataGridView dGVUnverifiedChapters;
        private System.Windows.Forms.Button buttonVerifyAllChapters;
        private System.Windows.Forms.Button buttonViewVerifyChapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridView dGVUsers;
        private System.Windows.Forms.Button buttonEditUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}
