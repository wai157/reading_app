
namespace PresentationLayer
{
    partial class FormLogInScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.linkLabelForgotPassword);
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(340, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.StealFocus);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignUp.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(250, 323);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 40);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Đăng kí";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.ActiveLinkColor = System.Drawing.Color.Turquoise;
            this.linkLabelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(252, 222);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(94, 16);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Quên mật khẩu";
            this.linkLabelForgotPassword.VisitedLinkColor = System.Drawing.Color.DimGray;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(200, 172);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(200, 40);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Đăng nhập";
            this.buttonLogIn.UseVisualStyleBackColor = true;
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
            // 
            // FormLogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.vivid_blurred_colorful_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogInScreen";
            this.Text = "FormLogInScreen";
            this.AcceptButton = buttonLogIn;
            this.Click += new System.EventHandler(this.StealFocus);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}