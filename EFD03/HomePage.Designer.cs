namespace EFD03
{
    partial class HomePage
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
            btn_delete_news = new Button();
            btn_update_news = new Button();
            btn_add_news = new Button();
            dtp_news = new DateTimePicker();
            txt_desc = new TextBox();
            txt_brief = new TextBox();
            txt_news_photo = new TextBox();
            txt_news_title = new TextBox();
            label2 = new Label();
            cb_category = new ComboBox();
            dgv_news = new DataGridView();
            wel_msg = new Label();
            btn_all_news = new Button();
            btn_my_news = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // btn_delete_news
            // 
            btn_delete_news.BackColor = Color.DarkRed;
            btn_delete_news.Cursor = Cursors.Hand;
            btn_delete_news.FlatStyle = FlatStyle.Flat;
            btn_delete_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_news.ForeColor = Color.White;
            btn_delete_news.Location = new Point(408, 271);
            btn_delete_news.Name = "btn_delete_news";
            btn_delete_news.Size = new Size(137, 34);
            btn_delete_news.TabIndex = 26;
            btn_delete_news.Text = "Delete News";
            btn_delete_news.UseVisualStyleBackColor = false;
            btn_delete_news.Click += btn_delete_news_Click;
            // 
            // btn_update_news
            // 
            btn_update_news.BackColor = Color.DarkRed;
            btn_update_news.Cursor = Cursors.Hand;
            btn_update_news.FlatStyle = FlatStyle.Flat;
            btn_update_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_news.ForeColor = Color.White;
            btn_update_news.Location = new Point(122, 271);
            btn_update_news.Name = "btn_update_news";
            btn_update_news.Size = new Size(137, 34);
            btn_update_news.TabIndex = 25;
            btn_update_news.Text = "Update News";
            btn_update_news.UseVisualStyleBackColor = false;
            btn_update_news.Click += btn_update_news_Click;
            // 
            // btn_add_news
            // 
            btn_add_news.BackColor = Color.DarkRed;
            btn_add_news.Cursor = Cursors.Hand;
            btn_add_news.FlatStyle = FlatStyle.Flat;
            btn_add_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_news.ForeColor = Color.White;
            btn_add_news.Location = new Point(266, 271);
            btn_add_news.Name = "btn_add_news";
            btn_add_news.Size = new Size(137, 34);
            btn_add_news.TabIndex = 24;
            btn_add_news.Text = "Add News";
            btn_add_news.UseVisualStyleBackColor = false;
            btn_add_news.Click += btn_add_news_Click;
            // 
            // dtp_news
            // 
            dtp_news.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_news.Location = new Point(388, 118);
            dtp_news.Name = "dtp_news";
            dtp_news.Size = new Size(246, 27);
            dtp_news.TabIndex = 23;
            // 
            // txt_desc
            // 
            txt_desc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_desc.Location = new Point(304, 155);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.PlaceholderText = "Description";
            txt_desc.Size = new Size(330, 108);
            txt_desc.TabIndex = 22;
            // 
            // txt_brief
            // 
            txt_brief.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_brief.Location = new Point(25, 155);
            txt_brief.Multiline = true;
            txt_brief.Name = "txt_brief";
            txt_brief.PlaceholderText = " Brief";
            txt_brief.Size = new Size(261, 108);
            txt_brief.TabIndex = 21;
            // 
            // txt_news_photo
            // 
            txt_news_photo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_news_photo.Location = new Point(207, 118);
            txt_news_photo.Name = "txt_news_photo";
            txt_news_photo.PlaceholderText = " Photo";
            txt_news_photo.Size = new Size(175, 27);
            txt_news_photo.TabIndex = 20;
            // 
            // txt_news_title
            // 
            txt_news_title.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_news_title.Location = new Point(25, 118);
            txt_news_title.Name = "txt_news_title";
            txt_news_title.PlaceholderText = " Title";
            txt_news_title.Size = new Size(175, 27);
            txt_news_title.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(207, 74);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 18;
            label2.Text = " Category";
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(289, 71);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(133, 28);
            cb_category.TabIndex = 17;
            cb_category.SelectedValueChanged += cb_category_SelectedValueChanged;
            // 
            // dgv_news
            // 
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(25, 322);
            dgv_news.Name = "dgv_news";
            dgv_news.RowTemplate.Height = 25;
            dgv_news.Size = new Size(609, 171);
            dgv_news.TabIndex = 16;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // wel_msg
            // 
            wel_msg.AutoSize = true;
            wel_msg.Font = new Font("SketchFlow Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            wel_msg.ForeColor = Color.DarkRed;
            wel_msg.Location = new Point(12, 10);
            wel_msg.Name = "wel_msg";
            wel_msg.Size = new Size(135, 21);
            wel_msg.TabIndex = 15;
            wel_msg.Text = " Welcome,  ";
            // 
            // btn_all_news
            // 
            btn_all_news.BackColor = Color.DarkRed;
            btn_all_news.Cursor = Cursors.Hand;
            btn_all_news.FlatStyle = FlatStyle.Flat;
            btn_all_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_all_news.ForeColor = Color.White;
            btn_all_news.Location = new Point(583, 5);
            btn_all_news.Name = "btn_all_news";
            btn_all_news.Size = new Size(51, 26);
            btn_all_news.TabIndex = 27;
            btn_all_news.Text = "All";
            btn_all_news.UseVisualStyleBackColor = false;
            btn_all_news.Click += btn_all_news_Click;
            // 
            // btn_my_news
            // 
            btn_my_news.BackColor = Color.DarkRed;
            btn_my_news.Cursor = Cursors.Hand;
            btn_my_news.FlatStyle = FlatStyle.Flat;
            btn_my_news.Font = new Font("SketchFlow Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_my_news.ForeColor = Color.White;
            btn_my_news.Location = new Point(526, 5);
            btn_my_news.Name = "btn_my_news";
            btn_my_news.Size = new Size(51, 26);
            btn_my_news.TabIndex = 28;
            btn_my_news.Text = "My";
            btn_my_news.UseVisualStyleBackColor = false;
            btn_my_news.Click += btn_my_news_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SketchFlow Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(557, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 29;
            label1.Text = "News";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 505);
            Controls.Add(label1);
            Controls.Add(btn_my_news);
            Controls.Add(btn_all_news);
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
            Controls.Add(wel_msg);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete_news;
        private Button btn_update_news;
        private Button btn_add_news;
        private DateTimePicker dtp_news;
        private TextBox txt_desc;
        private TextBox txt_brief;
        private TextBox txt_news_photo;
        private TextBox txt_news_title;
        private Label label2;
        private ComboBox cb_category;
        private DataGridView dgv_news;
        private Label wel_msg;
        private Button btn_all_news;
        private Button btn_my_news;
        private Label label1;
    }
}