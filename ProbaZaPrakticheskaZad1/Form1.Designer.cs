
namespace ProbaZaPrakticheskaZad1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Reg = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_ConfPass = new System.Windows.Forms.Label();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.txtBox_ConfPass = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.chBox_Showpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(324, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Reg
            // 
            this.lbl_Reg.AutoSize = true;
            this.lbl_Reg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Reg.Location = new System.Drawing.Point(101, 47);
            this.lbl_Reg.Name = "lbl_Reg";
            this.lbl_Reg.Size = new System.Drawing.Size(169, 22);
            this.lbl_Reg.TabIndex = 2;
            this.lbl_Reg.Text = "Registration form";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_User.Location = new System.Drawing.Point(58, 110);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(103, 22);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "Username";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Pass.Location = new System.Drawing.Point(56, 195);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(100, 22);
            this.lbl_Pass.TabIndex = 4;
            this.lbl_Pass.Text = "Password";
            // 
            // lbl_ConfPass
            // 
            this.lbl_ConfPass.AutoSize = true;
            this.lbl_ConfPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfPass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_ConfPass.Location = new System.Drawing.Point(56, 278);
            this.lbl_ConfPass.Name = "lbl_ConfPass";
            this.lbl_ConfPass.Size = new System.Drawing.Size(177, 22);
            this.lbl_ConfPass.TabIndex = 5;
            this.lbl_ConfPass.Text = "Confirm Password";
            // 
            // btn_Reg
            // 
            this.btn_Reg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Reg.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Reg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Reg.FlatAppearance.BorderSize = 2;
            this.btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reg.Location = new System.Drawing.Point(62, 400);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(234, 50);
            this.btn_Reg.TabIndex = 6;
            this.btn_Reg.Text = "REGISTER";
            this.btn_Reg.UseVisualStyleBackColor = false;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // txtBox_ConfPass
            // 
            this.txtBox_ConfPass.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_ConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ConfPass.Location = new System.Drawing.Point(60, 303);
            this.txtBox_ConfPass.Multiline = true;
            this.txtBox_ConfPass.Name = "txtBox_ConfPass";
            this.txtBox_ConfPass.PasswordChar = '*';
            this.txtBox_ConfPass.Size = new System.Drawing.Size(236, 30);
            this.txtBox_ConfPass.TabIndex = 7;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Pass.Location = new System.Drawing.Point(60, 220);
            this.txtBox_Pass.Multiline = true;
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(236, 30);
            this.txtBox_Pass.TabIndex = 8;
            // 
            // txtBox_User
            // 
            this.txtBox_User.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_User.Location = new System.Drawing.Point(60, 135);
            this.txtBox_User.Multiline = true;
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(236, 30);
            this.txtBox_User.TabIndex = 9;
            // 
            // chBox_Showpass
            // 
            this.chBox_Showpass.AutoSize = true;
            this.chBox_Showpass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_Showpass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chBox_Showpass.Location = new System.Drawing.Point(144, 339);
            this.chBox_Showpass.Name = "chBox_Showpass";
            this.chBox_Showpass.Size = new System.Drawing.Size(152, 21);
            this.chBox_Showpass.TabIndex = 10;
            this.chBox_Showpass.Text = "Show Password?";
            this.chBox_Showpass.UseVisualStyleBackColor = true;
            this.chBox_Showpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(356, 519);
            this.Controls.Add(this.chBox_Showpass);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_ConfPass);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.lbl_ConfPass);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Reg);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Reg;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_ConfPass;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.TextBox txtBox_ConfPass;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.CheckBox chBox_Showpass;
    }
}

