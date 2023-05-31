namespace EFD03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login1 = new Login();
            register1 = new Register();
            SuspendLayout();
            // 
            // login1
            // 
            login1.BackColor = SystemColors.Control;
            login1.Location = new Point(1, 1);
            login1.Name = "login1";
            login1.Size = new Size(347, 486);
            login1.TabIndex = 0;
            login1.Load += login1_Load_1;
            // 
            // register1
            // 
            register1.Location = new Point(1, 1);
            register1.Name = "register1";
            register1.Size = new Size(347, 486);
            register1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 488);
            Controls.Add(login1);
            Controls.Add(register1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Login login1;
        private Register register1;
    }
}