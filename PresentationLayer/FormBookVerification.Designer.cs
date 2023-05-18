
namespace PresentationLayer
{
    partial class FormBookVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookVerification));
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonUnverify = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panelMain.Controls.Add(this.textBoxDescription);
            this.panelMain.Controls.Add(this.buttonUnverify);
            this.panelMain.Controls.Add(this.buttonVerify);
            this.panelMain.Controls.Add(this.labelDescription);
            this.panelMain.Controls.Add(this.labelGenre);
            this.panelMain.Controls.Add(this.labelAuthor);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.pictureBoxCover);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            // 
            // buttonUnverify
            // 
            this.buttonUnverify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.buttonUnverify.DialogResult = System.Windows.Forms.DialogResult.No;
            resources.ApplyResources(this.buttonUnverify, "buttonUnverify");
            this.buttonUnverify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonUnverify.Name = "buttonUnverify";
            this.buttonUnverify.UseVisualStyleBackColor = false;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(251)))), ((int)(((byte)(214)))));
            this.buttonVerify.DialogResult = System.Windows.Forms.DialogResult.Yes;
            resources.ApplyResources(this.buttonVerify, "buttonVerify");
            this.buttonVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.UseVisualStyleBackColor = false;
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelDescription.Name = "labelDescription";
            // 
            // labelGenre
            // 
            resources.ApplyResources(this.labelGenre, "labelGenre");
            this.labelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelGenre.Name = "labelGenre";
            // 
            // labelAuthor
            // 
            resources.ApplyResources(this.labelAuthor, "labelAuthor");
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelAuthor.Name = "labelAuthor";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(8)))));
            this.labelName.Name = "labelName";
            // 
            // pictureBoxCover
            // 
            resources.ApplyResources(this.pictureBoxCover, "pictureBoxCover");
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.TabStop = false;
            // 
            // FormBookVerification
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookVerification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBookVerification_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonUnverify;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}