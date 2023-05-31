namespace EFD03
{
    partial class Register
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
            label1 = new Label();
            txt_name = new TextBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_confpass = new TextBox();
            txt_age = new TextBox();
            txt_address = new TextBox();
            btn_register = new Button();
            log_link = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SketchFlow Print", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(56, 17);
            label1.Name = "label1";
            label1.Size = new Size(216, 51);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(35, 103);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Name";
            txt_name.Size = new Size(261, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(35, 147);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(261, 27);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(35, 191);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(261, 27);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_confpass
            // 
            txt_confpass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confpass.Location = new Point(35, 234);
            txt_confpass.Name = "txt_confpass";
            txt_confpass.PlaceholderText = "Confirm Password";
            txt_confpass.Size = new Size(261, 27);
            txt_confpass.TabIndex = 5;
            txt_confpass.UseSystemPasswordChar = true;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age.Location = new Point(35, 278);
            txt_age.Name = "txt_age";
            txt_age.PlaceholderText = "Age";
            txt_age.Size = new Size(261, 27);
            txt_age.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(35, 321);
            txt_address.Name = "txt_address";
            txt_address.PlaceholderText = "Address";
            txt_address.Size = new Size(261, 27);
            txt_address.TabIndex = 7;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DarkRed;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("SketchFlow Print", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(87, 371);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(137, 45);
            btn_register.TabIndex = 8;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // log_link
            // 
            log_link.AutoSize = true;
            log_link.Location = new Point(87, 424);
            log_link.Name = "log_link";
            log_link.Size = new Size(141, 15);
            log_link.TabIndex = 9;
            log_link.TabStop = true;
            log_link.Text = "Already have an Acount ?";
            log_link.LinkClicked += log_link_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(log_link);
            Controls.Add(btn_register);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(txt_confpass);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "Register";
            Size = new Size(338, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_confpass;
        private TextBox txt_age;
        private TextBox txt_address;
        private Button btn_register;
        private LinkLabel log_link;
    }
}
