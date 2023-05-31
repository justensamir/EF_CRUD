using Castle.Components.DictionaryAdapter.Xml;
using EFD03.Models;
using EFD03.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EFD03.Login;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFD03
{
    public partial class HomePage : Form
    {
        BlogContext context;
        User? user;
        bool cbFlag;
        public HomePage()
        {
            InitializeComponent();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            context = new BlogContext();
            cbFlag = false;
            var category = context.Categories.Select(cat => new { Id = cat.Id, Name = cat.Name }).ToList();
            cb_category.DataSource = category;
            cb_category.ValueMember = "Id";
            cb_category.DisplayMember = "Name";

            user = context.Users.Where(user => user.Id == userId).SingleOrDefault();
            wel_msg.Text = $"Welcome, {user.Name}";
            dgv_news.DataSource = user.News.ToList();
            cbFlag = true;
        }

        private void btn_add_news_Click(object sender, EventArgs e)
        {
            user = context.Users.Where(user => user.Id == userId).SingleOrDefault();
            user.News.Add(new New()
            {
                Title = txt_news_title.Text,
                Photo = txt_news_photo.Text,
                Date = dtp_news.Value,
                Brief = txt_brief.Text,
                Description = txt_desc.Text,
                CategoryId = (int?)cb_category.SelectedValue,
                Category = context.Categories.Where(cat => cat.Id == (int?)cb_category.SelectedValue).FirstOrDefault(),
                UserId = userId,
                User = user
            });

            context.SaveChanges();
            dgv_news.DataSource = user.News.ToList();
            txt_brief.Text = txt_desc.Text = txt_news_photo.Text = txt_news_title.Text = "";
        }
        int newsId;
        New? _new;
        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            newsId = (int)dgv_news.SelectedRows[0].Cells["Id"].Value;
            _new = context.News.Where(n => n.Id == newsId).SingleOrDefault();
            txt_brief.Text = _new.Brief;
            txt_desc.Text = _new.Description;
            txt_news_title.Text = _new.Title;
            txt_news_photo.Text = _new.Photo;
            dtp_news.Value = _new.Date;
            cb_category.SelectedValue = _new.CategoryId;
        }

        private void btn_delete_news_Click(object sender, EventArgs e)
        {
            context.Remove(_new);
            context.SaveChanges();
            dgv_news.DataSource = user.News.ToList();
            txt_brief.Text = txt_desc.Text = txt_news_photo.Text = txt_news_title.Text = "";
        }

        private void btn_update_news_Click(object sender, EventArgs e)
        {
            _new.Title = txt_news_title.Text;
            _new.Photo = txt_news_photo.Text;
            _new.Date = dtp_news.Value;
            _new.Brief = txt_brief.Text;
            _new.Description = txt_desc.Text;
            _new.CategoryId = (int?)cb_category.SelectedValue;
            _new.Category = context.Categories.Where(cat => cat.Id == (int?)cb_category.SelectedValue).FirstOrDefault();

            context.SaveChanges();
            dgv_news.DataSource = user.News.ToList();
            txt_brief.Text = txt_desc.Text = txt_news_photo.Text = txt_news_title.Text = "";

        }

        private void btn_all_news_Click(object sender, EventArgs e)
        {
            dgv_news.DataSource = context.News.ToList();
            btn_add_news.Enabled = btn_delete_news.Enabled = btn_update_news.Enabled = false;
        }

        private void btn_my_news_Click(object sender, EventArgs e)
        {
            dgv_news.DataSource = user.News.ToList();
            btn_add_news.Enabled = btn_delete_news.Enabled = btn_update_news.Enabled = true;
        }

        private void cb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFlag)
            {
                var categoryNews = context.News.Where(n => n.CategoryId == (int?)cb_category.SelectedValue).ToList();
                dgv_news.DataSource = categoryNews;
            }
        }
    }
}
