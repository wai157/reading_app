
namespace PresentationLayer
{
    partial class LogInScreen
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogIn = new System.Windows.Forms.Button();
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
            this.panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.linkLabelForgotPassword);
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(340, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(172, 79);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 3;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonSignUp.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonSignUp.Location = new System.Drawing.Point(250, 323);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 40);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Đăng kí";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(80)))), ((int)(((byte)(231)))));
            this.linkLabelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(252, 218);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(94, 16);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Quên mật khẩu";
            this.linkLabelForgotPassword.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassword_LinkClicked);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonLogIn.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonLogIn.Location = new System.Drawing.Point(200, 172);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(200, 43);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Đăng nhập";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(200, 136);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 26);
            this.textBoxPassword.TabIndex = 1;
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
            this.textBoxUsername.Location = new System.Drawing.Point(200, 100);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 26);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "Tên đăng nhập";
            this.textBoxUsername.GotFocus += new System.EventHandler(this.textBoxUsername_RemoveText);
            this.textBoxUsername.LostFocus += new System.EventHandler(this.textBoxUsername_AddText);
            this.textBoxUsername.Validated += new System.EventHandler(this.textBoxUsername_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogInScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.LogInScreen_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
