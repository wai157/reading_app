
namespace PresentationLayer
{
    partial class FormReadingApp
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
            this.logInScreen1 = new UserControls.LogInScreen();
            this.mainScreen1 = new UserControls.MainScreen();
            this.adminScreen1 = new UserControls.AdminScreen();
            this.bookScreen1 = new UserControls.BookScreen();
            this.userProfileScreen1 = new UserControls.UserProfileScreen();
            this.SuspendLayout();
            // 
            // logInScreen1
            // 
            this.logInScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInScreen1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInScreen1.Location = new System.Drawing.Point(0, 0);
            this.logInScreen1.LogInAccount = null;
            this.logInScreen1.Name = "logInScreen";
            this.logInScreen1.Size = new System.Drawing.Size(1280, 720);
            this.logInScreen1.TabIndex = 0;
            // 
            // mainScreen1
            // 
            this.mainScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreen1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen1.Location = new System.Drawing.Point(0, 0);
            this.mainScreen1.Name = "mainScreen";
            this.mainScreen1.Size = new System.Drawing.Size(1280, 720);
            this.mainScreen1.TabIndex = 0;
            // 
            // adminScreen1
            // 
            this.adminScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminScreen1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminScreen1.Name = "adminScreen";
            this.adminScreen1.Size = new System.Drawing.Size(1280, 720);
            this.adminScreen1.TabIndex = 0;
            // 
            // bookScreen1
            // 
            this.bookScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookScreen1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookScreen1.Location = new System.Drawing.Point(0, 0);
            this.bookScreen1.Name = "bookScreen";
            this.bookScreen1.Size = new System.Drawing.Size(1280, 720);
            this.bookScreen1.TabIndex = 0;
            // 
            // userProfileScreen1
            // 
            this.userProfileScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userProfileScreen1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileScreen1.Location = new System.Drawing.Point(0, 0);
            this.userProfileScreen1.Name = "userProfileScreen";
            this.userProfileScreen1.Size = new System.Drawing.Size(1280, 720);
            this.userProfileScreen1.TabIndex = 0;
            // 
            // FormReadingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.logInScreen1);
            this.Controls.Add(this.mainScreen1);
            this.Controls.Add(this.adminScreen1);
            this.Controls.Add(this.bookScreen1);
            this.Controls.Add(this.userProfileScreen1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormReadingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Omega 3";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LogInScreen logInScreen1;
        private UserControls.MainScreen mainScreen1;
        private UserControls.AdminScreen adminScreen1;
        private UserControls.BookScreen bookScreen1;
        private UserControls.UserProfileScreen userProfileScreen1;
    }
}

