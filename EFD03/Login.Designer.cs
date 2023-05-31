namespace EFD03
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txt_lusername = new TextBox();
            txt_lpassword = new TextBox();
            btn_login = new Button();
            reg_link = new LinkLabel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SketchFlow Print", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(78, 26);
            label1.Name = "label1";
            label1.Size = new Size(178, 68);
            label1.TabIndex = 0;
            label1.Text = "Hello";
            // 
            // txt_lusername
            // 
            txt_lusername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lusername.Location = new Point(37, 231);
            txt_lusername.Name = "txt_lusername";
            txt_lusername.PlaceholderText = "Username";
            txt_lusername.Size = new Size(261, 27);
            txt_lusername.TabIndex = 1;
            // 
            // txt_lpassword
            // 
            txt_lpassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lpassword.Location = new Point(37, 282);
            txt_lpassword.Name = "txt_lpassword";
            txt_lpassword.PasswordChar = '*';
            txt_lpassword.PlaceholderText = "Password";
            txt_lpassword.Size = new Size(261, 27);
            txt_lpassword.TabIndex = 2;
            txt_lpassword.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkRed;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("SketchFlow Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(98, 349);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(137, 45);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // reg_link
            // 
            reg_link.AutoSize = true;
            reg_link.Location = new Point(109, 406);
            reg_link.Name = "reg_link";
            reg_link.Size = new Size(109, 15);
            reg_link.TabIndex = 7;
            reg_link.TabStop = true;
            reg_link.Text = "Create An Acount ?";
            reg_link.LinkClicked += reg_link_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(82, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 136);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(reg_link);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(txt_lpassword);
            Controls.Add(txt_lusername);
            Controls.Add(label1);
            Name = "Login";
            Size = new Size(338, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_lusername;
        private TextBox txt_lpassword;
        private Button btn_login;
        private LinkLabel reg_link;
        private Panel panel1;
    }
}
