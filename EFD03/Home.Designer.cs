namespace EFD03
{
    partial class Home
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
            dgv_news = new DataGridView();
            cb_category = new ComboBox();
            label2 = new Label();
            txt_news_title = new TextBox();
            txt_news_photo = new TextBox();
            txt_brief = new TextBox();
            txt_desc = new TextBox();
            dtp_news = new DateTimePicker();
            btn_add_news = new Button();
            btn_update_news = new Button();
            btn_delete_news = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SketchFlow Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(204, 34);
            label1.TabIndex = 2;
            label1.Text = " Welcome,  ";
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(11, 357);
            dgv_news.Name = "dgv_news";
            dgv_news.RowTemplate.Height = 25;
            dgv_news.Size = new Size(609, 150);
            dgv_news.TabIndex = 3;
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(275, 70);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(133, 28);
            cb_category.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = " Category";
            // 
            // txt_news_title
            // 
            txt_news_title.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_news_title.Location = new Point(11, 117);
            txt_news_title.Name = "txt_news_title";
            txt_news_title.PlaceholderText = " Title";
            txt_news_title.Size = new Size(175, 27);
            txt_news_title.TabIndex = 6;
            // 
            // txt_news_photo
            // 
            txt_news_photo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_news_photo.Location = new Point(193, 117);
            txt_news_photo.Name = "txt_news_photo";
            txt_news_photo.PlaceholderText = " Photo";
            txt_news_photo.Size = new Size(175, 27);
            txt_news_photo.TabIndex = 7;
            // 
            // txt_brief
            // 
            txt_brief.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_brief.Location = new Point(11, 154);
            txt_brief.Multiline = true;
            txt_brief.Name = "txt_brief";
            txt_brief.PlaceholderText = " Brief";
            txt_brief.Size = new Size(261, 142);
            txt_brief.TabIndex = 9;
            // 
            // txt_desc
            // 
            txt_desc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_desc.Location = new Point(290, 154);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.PlaceholderText = "Description";
            txt_desc.Size = new Size(330, 142);
            txt_desc.TabIndex = 10;
            // 
            // dtp_news
            // 
            dtp_news.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_news.Location = new Point(374, 117);
            dtp_news.Name = "dtp_news";
            dtp_news.Size = new Size(246, 27);
            dtp_news.TabIndex = 11;
            // 
            // btn_add_news
            // 
            btn_add_news.BackColor = Color.DarkRed;
            btn_add_news.Cursor = Cursors.Hand;
            btn_add_news.FlatStyle = FlatStyle.Flat;
            btn_add_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_news.ForeColor = Color.White;
            btn_add_news.Location = new Point(252, 310);
            btn_add_news.Name = "btn_add_news";
            btn_add_news.Size = new Size(137, 34);
            btn_add_news.TabIndex = 12;
            btn_add_news.Text = "Add News";
            btn_add_news.UseVisualStyleBackColor = false;
            // 
            // btn_update_news
            // 
            btn_update_news.BackColor = Color.DarkRed;
            btn_update_news.Cursor = Cursors.Hand;
            btn_update_news.FlatStyle = FlatStyle.Flat;
            btn_update_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_news.ForeColor = Color.White;
            btn_update_news.Location = new Point(108, 310);
            btn_update_news.Name = "btn_update_news";
            btn_update_news.Size = new Size(137, 34);
            btn_update_news.TabIndex = 13;
            btn_update_news.Text = "Update News";
            btn_update_news.UseVisualStyleBackColor = false;
            // 
            // btn_delete_news
            // 
            btn_delete_news.BackColor = Color.DarkRed;
            btn_delete_news.Cursor = Cursors.Hand;
            btn_delete_news.FlatStyle = FlatStyle.Flat;
            btn_delete_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_news.ForeColor = Color.White;
            btn_delete_news.Location = new Point(394, 310);
            btn_delete_news.Name = "btn_delete_news";
            btn_delete_news.Size = new Size(137, 34);
            btn_delete_news.TabIndex = 14;
            btn_delete_news.Text = "Delete News";
            btn_delete_news.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_delete_news);
            Controls.Add(btn_update_news);
            Controls.Add(btn_add_news);
            Controls.Add(dtp_news);
            Controls.Add(txt_desc);
            Controls.Add(txt_brief);
            Controls.Add(txt_news_photo);
            Controls.Add(txt_news_title);
            Controls.Add(label2);
            Controls.Add(cb_category);
            Controls.Add(dgv_news);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(636, 526);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_news;
        private ComboBox cb_category;
        private Label label2;
        private TextBox txt_news_title;
        private TextBox txt_news_photo;
        private TextBox txt_brief;
        private TextBox txt_desc;
        private DateTimePicker dtp_news;
        private Button btn_add_news;
        private Button btn_update_news;
        private Button btn_delete_news;
    }
}
