using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using StanSoft;

namespace Demo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.urlTextBox.Text))
            {
                MessageBox.Show("请输入网址!");
                return;
            }
            // 保存用户输入的Url,和追加模式设置
            Properties.Settings.Default.Save();

            this.webBrowser.Navigate(this.urlTextBox.Text);
            this.webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;

            SetDownloadState();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != this.webBrowser.Document.Url)
            {
                return;
            }
            string encode = this.webBrowser.Document.Encoding;
            StreamReader sr = new StreamReader(this.webBrowser.DocumentStream, Encoding.GetEncoding(encode));
            string html = sr.ReadToEnd();

            //Html2Article.LimitCount = 100;
            //Html2Article.Depth = 8;
            // 设置是否使用正文追加模式
            Html2Article.AppendMode = this.appendCheckBox.CheckState == CheckState.Checked;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            // 将Html解析为Article结构化数据
            Article article = Html2Article.GetArticle(html);
            sw.Stop();
            msgLabel.Text = "提取耗时：" + Environment.NewLine + sw.ElapsedMilliseconds + "毫秒";

            this.publishDateTextBox.Text = article.PublishDate.ToString();
            this.titleTextBox.Text = article.Title;
            this.contentTextBox.Text = article.Content;

            string articleHtml = UrlUtility.FixUrl(this.urlTextBox.Text, article.ContentWithTags);
            this.contentWebBrowser.DocumentText = articleHtml;

            ResetState();
        }

        private void SetDownloadState()
        {
            this.btnOk.Text = "下载中...";
            this.btnOk.Enabled = false;

            this.publishDateTextBox.Text = "";
            this.titleTextBox.Text = "";
            this.contentTextBox.Text = "";
            this.msgLabel.Text = "";
        }

        private void ResetState()
        {
            this.btnOk.Text = "提取正文";
            this.btnOk.Enabled = true;
        }
    }
}
