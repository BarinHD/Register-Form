
namespace ProbaZaPrakticheskaZad1
{
    partial class Form2
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
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.txtBox_Ticket = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.lbl_Ticket = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Dest = new System.Windows.Forms.Label();
            this.cmbBox_Dest = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_User
            // 
            this.txtBox_User.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_User.Location = new System.Drawing.Point(52, 115);
            this.txtBox_User.Multiline = true;
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(236, 30);
            this.txtBox_User.TabIndex = 19;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Pass.Location = new System.Drawing.Point(52, 195);
            this.txtBox_Pass.Multiline = true;
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(236, 30);
            this.txtBox_Pass.TabIndex = 18;
            // 
            // txtBox_Ticket
            // 
            this.txtBox_Ticket.BackColor = System.Drawing.Color.DarkGray;
            this.txtBox_Ticket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Ticket.Location = new System.Drawing.Point(54, 277);
            this.txtBox_Ticket.Multiline = true;
            this.txtBox_Ticket.Name = "txtBox_Ticket";
            this.txtBox_Ticket.Size = new System.Drawing.Size(76, 30);
            this.txtBox_Ticket.TabIndex = 17;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Reserve.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Reserve.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Reserve.FlatAppearance.BorderSize = 2;
            this.btn_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reserve.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reserve.Location = new System.Drawing.Point(54, 433);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(234, 50);
            this.btn_Reserve.TabIndex = 16;
            this.btn_Reserve.Text = "RESERVE";
            this.btn_Reserve.UseVisualStyleBackColor = false;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // lbl_Ticket
            // 
            this.lbl_Ticket.AutoSize = true;
            this.lbl_Ticket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ticket.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Ticket.Location = new System.Drawing.Point(50, 247);
            this.lbl_Ticket.Name = "lbl_Ticket";
            this.lbl_Ticket.Size = new System.Drawing.Size(77, 22);
            this.lbl_Ticket.TabIndex = 15;
            this.lbl_Ticket.Text = "Tickets";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Pass.Location = new System.Drawing.Point(48, 170);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(100, 22);
            this.lbl_Pass.TabIndex = 14;
            this.lbl_Pass.Text = "Password";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_User.Location = new System.Drawing.Point(50, 90);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(103, 22);
            this.lbl_User.TabIndex = 13;
            this.lbl_User.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Login.Location = new System.Drawing.Point(118, 43);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(121, 24);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "Login form";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(323, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Dest
            // 
            this.lbl_Dest.AutoSize = true;
            this.lbl_Dest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Dest.Location = new System.Drawing.Point(48, 329);
            this.lbl_Dest.Name = "lbl_Dest";
            this.lbl_Dest.Size = new System.Drawing.Size(113, 22);
            this.lbl_Dest.TabIndex = 20;
            this.lbl_Dest.Text = "Destination";
            // 
            // cmbBox_Dest
            // 
            this.cmbBox_Dest.FormattingEnabled = true;
            this.cmbBox_Dest.Location = new System.Drawing.Point(52, 354);
            this.cmbBox_Dest.Name = "cmbBox_Dest";
            this.cmbBox_Dest.Size = new System.Drawing.Size(201, 21);
            this.cmbBox_Dest.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, -8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 42);
            this.button2.TabIndex = 22;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(356, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbBox_Dest);
            this.Controls.Add(this.lbl_Dest);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_Ticket);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.lbl_Ticket);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.TextBox txtBox_Ticket;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Label lbl_Ticket;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Dest;
        private System.Windows.Forms.ComboBox cmbBox_Dest;
        private System.Windows.Forms.Button button2;
    }
}