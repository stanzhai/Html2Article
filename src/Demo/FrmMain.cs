using CefSharp;
using CefSharp.WinForms;
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
            InitCefSharp();
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
            if (!cbx_UseCefSharp.Checked)
            {
                this.webBrowser.Navigate(this.urlTextBox.Text.Trim());
                this.webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            }
            else {
                //试用cefSharp
                LoadUrlUsingCefSharp(this.urlTextBox.Text.Trim());
            }
            SetDownloadState();
        }
        /// <summary>
        /// 试用CefSharp加载URL
        /// </summary>
        /// <param name="url">要加载的URL</param>
        /// <returns>执行是否成功</returns>
        /// <returns>执行是否成功</returns>
        private bool LoadUrlUsingCefSharp(string url)
        {
            bool isOK = false;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                chromiumWebBrowser1.Load(url);
                return true;
            }
            else
            {
                MessageBox.Show("(Uri.IsWellFormedUriString(url={0}, UriKind.RelativeOrAbsolute={1})"+ url+UriKind.RelativeOrAbsolute);
            }
            return isOK;
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
            resolveArticleFromHtmlString(html);


        }

        /// <summary>
        /// 从HTML字符串中查找文章正文部分
        /// </summary>
        /// <param name="html">要处理的HTML字符串</param>
        private void resolveArticleFromHtmlString(String html) {
            //Html2Article.LimitCount = 100;
            //Html2Article.Depth = 8;
            // 设置是否使用正文追加模式
            Html2Article.AppendMode = this.appendCheckBox.CheckState == CheckState.Checked;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            // 将Html解析为Article结构化数据
            Article article = Html2Article.GetArticle(html);
            sw.Stop();
            this.InvokeOnUiThreadIfRequired(() => this.msgLabel.Text = "提取耗时：" + Environment.NewLine + sw.ElapsedMilliseconds + "毫秒");

            this.InvokeOnUiThreadIfRequired(() => this.publishDateTextBox.Text = article.PublishDate.ToString());
          
            this.InvokeOnUiThreadIfRequired(() => this.titleTextBox.Text = article.Title);
          
            this.InvokeOnUiThreadIfRequired(() => this.contentTextBox.Text = article.Content);
            
            string articleHtml = UrlUtility.FixUrl(this.urlTextBox.Text, article.ContentWithTags);
            this.InvokeOnUiThreadIfRequired(() => this.contentWebBrowser.DocumentText = articleHtml);
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
            this.InvokeOnUiThreadIfRequired(() => this.btnOk.Text = "提取正文");
            

            this.InvokeOnUiThreadIfRequired(() => this.btnOk.Enabled = true);
            
        }


        /// <summary>
        /// 初始化 CefSharp
        /// </summary>
        public static void InitCefSharp()
        {
            var settings = new CefSettings();

            // Increase the log severity so CEF outputs detailed information, useful for debugging
            settings.LogSeverity = LogSeverity.Verbose;
            // By default CEF uses an in memory cache, to save cached data e.g. to persist cookies you need to specify a cache path
            // NOTE: The executing user must have sufficient privileges to write to this folder.
            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache");
            //Disable GPU Acceleration
            settings.CefCommandLineArgs.Add("disable-gpu");
            //firefox
            //settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0";
            //chrome
            settings.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 88.0.4324.190 Safari / 537.36";

            Cef.Initialize(settings);
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

            this.InvokeOnUiThreadIfRequired(() => this.msgLabel.Text = e.Browser.IsLoading.ToString());
            if (!e.Browser.IsLoading)
            {
                // locad completed
                //reead html
                //var task02 = e.Browser.MainFrame.GetTextAsync();
                var task02 = e.Browser.MainFrame.GetSourceAsync();
                task02.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        //html
                        String resultStr = t.Result;

                        String sourceBegin = "<html><head></head><body><pre style=\"word-wrap: break-word; white-space: pre-wrap;\">";
                        String sourceEnd = "</pre></body></html>";
                        if (resultStr.StartsWith(sourceBegin))
                        {
                            //去掉开始结束
                            resultStr = resultStr.Replace(sourceBegin, "").Replace(sourceEnd, "");
                        }

                        this.InvokeOnUiThreadIfRequired(() => this.msgLabel.Text = resultStr);

                        //获取文章。
                        resolveArticleFromHtmlString(resultStr);

                    }
                    else {
                        MessageBox.Show(t.Exception.Message);
                    }
                });
            }
        }

        private void urlTextBox_DoubleClick(object sender, EventArgs e)
        {
            urlTextBox.SelectAll();
        }
    }
}
