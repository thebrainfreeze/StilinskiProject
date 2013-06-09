namespace Stilinksi_Project
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.txt_Pword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_Uname
            // 
            this.txt_Uname.AcceptsTab = true;
            this.txt_Uname.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.txt_Uname.Location = new System.Drawing.Point(732, 304);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(295, 38);
            this.txt_Uname.TabIndex = 0;
            // 
            // txt_Pword
            // 
            this.txt_Pword.AcceptsTab = true;
            this.txt_Pword.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.txt_Pword.Location = new System.Drawing.Point(732, 354);
            this.txt_Pword.Name = "txt_Pword";
            this.txt_Pword.PasswordChar = '*';
            this.txt_Pword.Size = new System.Drawing.Size(295, 38);
            this.txt_Pword.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.BackgroundImage = global::Stilinksi_Project.Properties.Resources.btn_login;
            this.btn_Login.Location = new System.Drawing.Point(850, 462);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(177, 47);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(854, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Enroll Now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stilinksi_Project.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pword);
            this.Controls.Add(this.txt_Uname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.TextBox txt_Pword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

