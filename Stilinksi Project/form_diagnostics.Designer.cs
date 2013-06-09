namespace Stilinksi_Project
{
    partial class form_diagnostics
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
            this.components = new System.ComponentModel.Container();
            this.lbl_LeftNum = new System.Windows.Forms.Label();
            this.lbl_Oper = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_Sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_FoNum = new System.Windows.Forms.Label();
            this.lbl_Tnum = new System.Windows.Forms.Label();
            this.lbl_Snum = new System.Windows.Forms.Label();
            this.lbl_Fnum = new System.Windows.Forms.Label();
            this.lbl_equal = new System.Windows.Forms.Label();
            this.lbl_RightNum = new System.Windows.Forms.Label();
            this.tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_LeftNum
            // 
            this.lbl_LeftNum.AutoSize = true;
            this.lbl_LeftNum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LeftNum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeftNum.Location = new System.Drawing.Point(107, 199);
            this.lbl_LeftNum.Name = "lbl_LeftNum";
            this.lbl_LeftNum.Size = new System.Drawing.Size(174, 106);
            this.lbl_LeftNum.TabIndex = 0;
            this.lbl_LeftNum.Text = "000";
            // 
            // lbl_Oper
            // 
            this.lbl_Oper.AutoSize = true;
            this.lbl_Oper.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Oper.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oper.Location = new System.Drawing.Point(287, 199);
            this.lbl_Oper.Name = "lbl_Oper";
            this.lbl_Oper.Size = new System.Drawing.Size(100, 106);
            this.lbl_Oper.TabIndex = 1;
            this.lbl_Oper.Text = "+";
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Salmon;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(744, 387);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(205, 76);
            this.btn_Enter.TabIndex = 12;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            this.btn_Enter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Diagnostic_KeyDown);
            this.btn_Enter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Diagnostic_KeyPress);
            // 
            // lbl_Sec
            // 
            this.lbl_Sec.AutoSize = true;
            this.lbl_Sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sec.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sec.Location = new System.Drawing.Point(921, 55);
            this.lbl_Sec.Name = "lbl_Sec";
            this.lbl_Sec.Size = new System.Drawing.Size(88, 72);
            this.lbl_Sec.TabIndex = 20;
            this.lbl_Sec.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 72);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Min.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Min.Location = new System.Drawing.Point(827, 55);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(88, 72);
            this.lbl_Min.TabIndex = 19;
            this.lbl_Min.Text = "05";
            // 
            // lbl_FoNum
            // 
            this.lbl_FoNum.BackColor = System.Drawing.Color.White;
            this.lbl_FoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_FoNum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoNum.Location = new System.Drawing.Point(927, 198);
            this.lbl_FoNum.Name = "lbl_FoNum";
            this.lbl_FoNum.Size = new System.Drawing.Size(80, 100);
            this.lbl_FoNum.TabIndex = 18;
            this.lbl_FoNum.Text = "0";
            this.lbl_FoNum.Visible = false;
            // 
            // lbl_Tnum
            // 
            this.lbl_Tnum.BackColor = System.Drawing.Color.White;
            this.lbl_Tnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Tnum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tnum.Location = new System.Drawing.Point(840, 199);
            this.lbl_Tnum.Name = "lbl_Tnum";
            this.lbl_Tnum.Size = new System.Drawing.Size(80, 100);
            this.lbl_Tnum.TabIndex = 17;
            this.lbl_Tnum.Text = "0";
            this.lbl_Tnum.Visible = false;
            // 
            // lbl_Snum
            // 
            this.lbl_Snum.BackColor = System.Drawing.Color.White;
            this.lbl_Snum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Snum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Snum.Location = new System.Drawing.Point(754, 198);
            this.lbl_Snum.Name = "lbl_Snum";
            this.lbl_Snum.Size = new System.Drawing.Size(80, 100);
            this.lbl_Snum.TabIndex = 16;
            this.lbl_Snum.Visible = false;
            // 
            // lbl_Fnum
            // 
            this.lbl_Fnum.BackColor = System.Drawing.Color.White;
            this.lbl_Fnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Fnum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fnum.Location = new System.Drawing.Point(666, 198);
            this.lbl_Fnum.Name = "lbl_Fnum";
            this.lbl_Fnum.Size = new System.Drawing.Size(80, 100);
            this.lbl_Fnum.TabIndex = 15;
            this.lbl_Fnum.Visible = false;
            // 
            // lbl_equal
            // 
            this.lbl_equal.AutoSize = true;
            this.lbl_equal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_equal.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equal.Location = new System.Drawing.Point(560, 199);
            this.lbl_equal.Name = "lbl_equal";
            this.lbl_equal.Size = new System.Drawing.Size(100, 106);
            this.lbl_equal.TabIndex = 14;
            this.lbl_equal.Text = "=";
            // 
            // lbl_RightNum
            // 
            this.lbl_RightNum.AutoSize = true;
            this.lbl_RightNum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RightNum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RightNum.Location = new System.Drawing.Point(402, 199);
            this.lbl_RightNum.Name = "lbl_RightNum";
            this.lbl_RightNum.Size = new System.Drawing.Size(174, 106);
            this.lbl_RightNum.TabIndex = 13;
            this.lbl_RightNum.Text = "000";
            // 
            // tmr_Clock
            // 
            this.tmr_Clock.Tick += new System.EventHandler(this.tmr_Clock_Tick);
            // 
            // frm_Diagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stilinksi_Project.Properties.Resources.gamescreen;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.lbl_Sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.lbl_FoNum);
            this.Controls.Add(this.lbl_Tnum);
            this.Controls.Add(this.lbl_Snum);
            this.Controls.Add(this.lbl_Fnum);
            this.Controls.Add(this.lbl_equal);
            this.Controls.Add(this.lbl_RightNum);
            this.Controls.Add(this.lbl_Oper);
            this.Controls.Add(this.lbl_LeftNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Diagnostic";
            this.Text = "frm_Diagnostic";
            this.Load += new System.EventHandler(this.frm_Diagnostic_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Diagnostic_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Diagnostic_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LeftNum;
        private System.Windows.Forms.Label lbl_Oper;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lbl_Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_FoNum;
        private System.Windows.Forms.Label lbl_Tnum;
        private System.Windows.Forms.Label lbl_Snum;
        private System.Windows.Forms.Label lbl_Fnum;
        private System.Windows.Forms.Label lbl_equal;
        private System.Windows.Forms.Label lbl_RightNum;
        private System.Windows.Forms.Timer tmr_Clock;
    }
}