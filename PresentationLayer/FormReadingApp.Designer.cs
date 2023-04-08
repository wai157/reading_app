
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
            this.logInScreen = new PresentationLayer.LogInScreen();
            this.mainScreen = new PresentationLayer.MainScreen();
            this.bookScreen = new PresentationLayer.BookScreen();
            this.SuspendLayout();
            // 
            // logInScreen
            // 
            this.logInScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInScreen.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInScreen.Location = new System.Drawing.Point(0, 0);
            this.logInScreen.Name = "logInScreen";
            this.logInScreen.Size = new System.Drawing.Size(1280, 695);
            this.logInScreen.TabIndex = 0;
            // 
            // mainScreen
            // 
            this.mainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreen.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen.Location = new System.Drawing.Point(0, 0);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(1280, 695);
            this.mainScreen.TabIndex = 0;
            // 
            // bookScreen
            // 
            this.bookScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookScreen.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookScreen.Location = new System.Drawing.Point(0, 0);
            this.bookScreen.Name = "bookScreen";
            this.bookScreen.Size = new System.Drawing.Size(1280, 695);
            this.bookScreen.TabIndex = 0;
            // 
            // FormReadingApp
            // 
            this.AcceptButton = this.logInScreen.ButtonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.logInScreen);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.bookScreen);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormReadingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reading App";
            this.Load += new System.EventHandler(this.FormReadingApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LogInScreen logInScreen;
        private MainScreen mainScreen;
        private BookScreen bookScreen;
    }
}

