
namespace PresentationLayer
{
    partial class RegisterScreen
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.linkLabelBackToLogIn = new System.Windows.Forms.LinkLabel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxRePassword);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.linkLabelBackToLogIn);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(340, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(200, 100);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.GotFocus += new System.EventHandler(this.textBoxEmail_RemoveText);
            this.textBoxEmail.LostFocus += new System.EventHandler(this.textBoxEmail_AddText);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRePassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRePassword.Location = new System.Drawing.Point(200, 208);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.Size = new System.Drawing.Size(200, 26);
            this.textBoxRePassword.TabIndex = 3;
            this.textBoxRePassword.Text = "Nhập lại mật khẩu";
            this.textBoxRePassword.GotFocus += new System.EventHandler(this.textBoxRePassword_RemoveText);
            this.textBoxRePassword.LostFocus += new System.EventHandler(this.textBoxRePassword_AddText);
            this.textBoxRePassword.Validated += new System.EventHandler(this.textBoxRePassword_Validated);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(133, 79);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 6;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelBackToLogIn
            // 
            this.linkLabelBackToLogIn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.linkLabelBackToLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelBackToLogIn.AutoSize = true;
            this.linkLabelBackToLogIn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBackToLogIn.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelBackToLogIn.Location = new System.Drawing.Point(242, 290);
            this.linkLabelBackToLogIn.Name = "linkLabelBackToLogIn";
            this.linkLabelBackToLogIn.Size = new System.Drawing.Size(116, 16);
            this.linkLabelBackToLogIn.TabIndex = 5;
            this.linkLabelBackToLogIn.TabStop = true;
            this.linkLabelBackToLogIn.Text = "Quay lại đăng nhập";
            this.linkLabelBackToLogIn.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelBackToLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackToLogIn_LinkClicked);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(200, 244);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(200, 43);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Đăng kí";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(200, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Mật khẩu";
            this.textBoxPassword.GotFocus += new System.EventHandler(this.textBoxPassword_RemoveText);
            this.textBoxPassword.LostFocus += new System.EventHandler(this.textBoxPassword_AddText);
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(200, 136);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Tên đăng nhập";
            this.textBoxUsername.GotFocus += new System.EventHandler(this.textBoxUsername_RemoveText);
            this.textBoxUsername.LostFocus += new System.EventHandler(this.textBoxUsername_AddText);
            this.textBoxUsername.Validated += new System.EventHandler(this.textBoxUsername_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegisterScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.LinkLabel linkLabelBackToLogIn;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}
