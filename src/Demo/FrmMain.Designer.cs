namespace Demo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label publishDateLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            this.btnOk = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publishDateTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contentWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.msgLabel = new System.Windows.Forms.Label();
            this.appendCheckBox = new System.Windows.Forms.CheckBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            contentLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(12, 113);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(59, 12);
            contentLabel.TabIndex = 6;
            contentLabel.Text = "正文内容:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(12, 57);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(59, 12);
            publishDateLabel.TabIndex = 8;
            publishDateLabel.Text = "发布日期:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 86);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(35, 12);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "标题:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 12);
            label1.TabIndex = 8;
            label1.Text = "网址:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(672, 25);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "提取正文";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.Color.White;
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Location = new System.Drawing.Point(3, 3);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentTextBox.Size = new System.Drawing.Size(632, 366);
            this.contentTextBox.TabIndex = 7;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.White;
            this.titleTextBox.Location = new System.Drawing.Point(101, 83);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(565, 21);
            this.titleTextBox.TabIndex = 11;
            // 
            // publishDateTextBox
            // 
            this.publishDateTextBox.BackColor = System.Drawing.Color.White;
            this.publishDateTextBox.Location = new System.Drawing.Point(101, 54);
            this.publishDateTextBox.Name = "publishDateTextBox";
            this.publishDateTextBox.ReadOnly = true;
            this.publishDateTextBox.Size = new System.Drawing.Size(565, 21);
            this.publishDateTextBox.TabIndex = 11;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(632, 366);
            this.webBrowser.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(101, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 398);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contentTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "正文文本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.contentWebBrowser);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "带标签正文";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contentWebBrowser
            // 
            this.contentWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.contentWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.contentWebBrowser.Name = "contentWebBrowser";
            this.contentWebBrowser.Size = new System.Drawing.Size(632, 366);
            this.contentWebBrowser.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "原始网页";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(12, 478);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 12);
            this.msgLabel.TabIndex = 15;
            // 
            // appendCheckBox
            // 
            this.appendCheckBox.AutoSize = true;
            this.appendCheckBox.Checked = global::Demo.Properties.Settings.Default.appendMode;
            this.appendCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Demo.Properties.Settings.Default, "appendMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.appendCheckBox.Location = new System.Drawing.Point(675, 57);
            this.appendCheckBox.Name = "appendCheckBox";
            this.appendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.appendCheckBox.TabIndex = 14;
            this.appendCheckBox.Text = "追加模式";
            this.appendCheckBox.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Demo.Properties.Settings.Default, "url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.urlTextBox.Location = new System.Drawing.Point(101, 25);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(565, 21);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = global::Demo.Properties.Settings.Default.url;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 520);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.appendCheckBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(contentLabel);
            this.Controls.Add(label1);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.publishDateTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.urlTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Html2Article - Author: 翟士丹 StanZhai jasondan325@163.com";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publishDateTextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox appendCheckBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser contentWebBrowser;
    }
}

