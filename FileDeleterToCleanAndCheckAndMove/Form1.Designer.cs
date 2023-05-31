namespace FileDeleterToCleanAndCheckAndMove
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CheckFileMovementResultBnt = new System.Windows.Forms.Button();
            this.StoreFilePathPrefix = new System.Windows.Forms.Label();
            this.StoreFilePathPrefixTextBox = new System.Windows.Forms.TextBox();
            this.FilePathChangeBnt = new System.Windows.Forms.Button();
            this.FileMoveBnt = new System.Windows.Forms.Button();
            this.BacpUpSourcePathPrefixLabel = new System.Windows.Forms.Label();
            this.EncryptedFiePathPrefixLabel = new System.Windows.Forms.Label();
            this.BacpUpSourcePathPrefixTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedFiePathPrefixTextBox = new System.Windows.Forms.TextBox();
            this.CleanFileBnt = new System.Windows.Forms.Button();
            this.ReadFileBnt = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RegexExpressLabel = new System.Windows.Forms.Label();
            this.RegexExpressTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 548);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RegexExpressTextBox);
            this.tabPage1.Controls.Add(this.RegexExpressLabel);
            this.tabPage1.Controls.Add(this.CheckFileMovementResultBnt);
            this.tabPage1.Controls.Add(this.StoreFilePathPrefix);
            this.tabPage1.Controls.Add(this.StoreFilePathPrefixTextBox);
            this.tabPage1.Controls.Add(this.FilePathChangeBnt);
            this.tabPage1.Controls.Add(this.FileMoveBnt);
            this.tabPage1.Controls.Add(this.BacpUpSourcePathPrefixLabel);
            this.tabPage1.Controls.Add(this.EncryptedFiePathPrefixLabel);
            this.tabPage1.Controls.Add(this.BacpUpSourcePathPrefixTextBox);
            this.tabPage1.Controls.Add(this.EncryptedFiePathPrefixTextBox);
            this.tabPage1.Controls.Add(this.CleanFileBnt);
            this.tabPage1.Controls.Add(this.ReadFileBnt);
            this.tabPage1.Controls.Add(this.FilePathTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckFileMovementResultBnt
            // 
            this.CheckFileMovementResultBnt.Location = new System.Drawing.Point(497, 422);
            this.CheckFileMovementResultBnt.Name = "CheckFileMovementResultBnt";
            this.CheckFileMovementResultBnt.Size = new System.Drawing.Size(211, 74);
            this.CheckFileMovementResultBnt.TabIndex = 25;
            this.CheckFileMovementResultBnt.Text = "檢查搬運結果";
            this.CheckFileMovementResultBnt.UseVisualStyleBackColor = true;
            this.CheckFileMovementResultBnt.Click += new System.EventHandler(this.CheckFileMovementResultBnt_Click);
            // 
            // StoreFilePathPrefix
            // 
            this.StoreFilePathPrefix.AutoSize = true;
            this.StoreFilePathPrefix.Location = new System.Drawing.Point(47, 352);
            this.StoreFilePathPrefix.Name = "StoreFilePathPrefix";
            this.StoreFilePathPrefix.Size = new System.Drawing.Size(149, 12);
            this.StoreFilePathPrefix.TabIndex = 24;
            this.StoreFilePathPrefix.Text = "搬運檔案存放目的路徑開頭";
            // 
            // StoreFilePathPrefixTextBox
            // 
            this.StoreFilePathPrefixTextBox.Location = new System.Drawing.Point(215, 349);
            this.StoreFilePathPrefixTextBox.Name = "StoreFilePathPrefixTextBox";
            this.StoreFilePathPrefixTextBox.Size = new System.Drawing.Size(462, 22);
            this.StoreFilePathPrefixTextBox.TabIndex = 23;
            this.StoreFilePathPrefixTextBox.TextChanged += new System.EventHandler(this.StoreFilePathPrefixTextBox_TextChanged);
            // 
            // FilePathChangeBnt
            // 
            this.FilePathChangeBnt.Location = new System.Drawing.Point(215, 264);
            this.FilePathChangeBnt.Name = "FilePathChangeBnt";
            this.FilePathChangeBnt.Size = new System.Drawing.Size(241, 50);
            this.FilePathChangeBnt.TabIndex = 22;
            this.FilePathChangeBnt.Text = "更改檔案路徑";
            this.FilePathChangeBnt.UseVisualStyleBackColor = true;
            this.FilePathChangeBnt.Click += new System.EventHandler(this.FilePathChangeBnt_Click);
            // 
            // FileMoveBnt
            // 
            this.FileMoveBnt.Location = new System.Drawing.Point(215, 422);
            this.FileMoveBnt.Name = "FileMoveBnt";
            this.FileMoveBnt.Size = new System.Drawing.Size(241, 69);
            this.FileMoveBnt.TabIndex = 21;
            this.FileMoveBnt.Text = "搬運檔案";
            this.FileMoveBnt.UseVisualStyleBackColor = true;
            this.FileMoveBnt.Click += new System.EventHandler(this.FileMoveBnt_Click);
            // 
            // BacpUpSourcePathPrefixLabel
            // 
            this.BacpUpSourcePathPrefixLabel.AutoSize = true;
            this.BacpUpSourcePathPrefixLabel.Location = new System.Drawing.Point(47, 223);
            this.BacpUpSourcePathPrefixLabel.Name = "BacpUpSourcePathPrefixLabel";
            this.BacpUpSourcePathPrefixLabel.Size = new System.Drawing.Size(101, 12);
            this.BacpUpSourcePathPrefixLabel.TabIndex = 20;
            this.BacpUpSourcePathPrefixLabel.Text = "備份來源路徑開頭";
            this.BacpUpSourcePathPrefixLabel.Click += new System.EventHandler(this.BacpUpSourcePathPrefixLabel_Click);
            // 
            // EncryptedFiePathPrefixLabel
            // 
            this.EncryptedFiePathPrefixLabel.AutoSize = true;
            this.EncryptedFiePathPrefixLabel.Location = new System.Drawing.Point(47, 188);
            this.EncryptedFiePathPrefixLabel.Name = "EncryptedFiePathPrefixLabel";
            this.EncryptedFiePathPrefixLabel.Size = new System.Drawing.Size(101, 12);
            this.EncryptedFiePathPrefixLabel.TabIndex = 19;
            this.EncryptedFiePathPrefixLabel.Text = "加密檔案路徑開頭";
            this.EncryptedFiePathPrefixLabel.Click += new System.EventHandler(this.EncryptedFiePathPrefixLabel_Click);
            // 
            // BacpUpSourcePathPrefixTextBox
            // 
            this.BacpUpSourcePathPrefixTextBox.Location = new System.Drawing.Point(215, 213);
            this.BacpUpSourcePathPrefixTextBox.Name = "BacpUpSourcePathPrefixTextBox";
            this.BacpUpSourcePathPrefixTextBox.Size = new System.Drawing.Size(462, 22);
            this.BacpUpSourcePathPrefixTextBox.TabIndex = 18;
            this.BacpUpSourcePathPrefixTextBox.TextChanged += new System.EventHandler(this.BacpUpSourcePathPrefixTextBox_TextChanged);
            // 
            // EncryptedFiePathPrefixTextBox
            // 
            this.EncryptedFiePathPrefixTextBox.Location = new System.Drawing.Point(215, 178);
            this.EncryptedFiePathPrefixTextBox.Name = "EncryptedFiePathPrefixTextBox";
            this.EncryptedFiePathPrefixTextBox.Size = new System.Drawing.Size(462, 22);
            this.EncryptedFiePathPrefixTextBox.TabIndex = 17;
            this.EncryptedFiePathPrefixTextBox.TextChanged += new System.EventHandler(this.EncryptedFiePathPrefixTextBox_TextChanged);
            // 
            // CleanFileBnt
            // 
            this.CleanFileBnt.Location = new System.Drawing.Point(215, 58);
            this.CleanFileBnt.Name = "CleanFileBnt";
            this.CleanFileBnt.Size = new System.Drawing.Size(241, 48);
            this.CleanFileBnt.TabIndex = 16;
            this.CleanFileBnt.Text = "清除檔案";
            this.CleanFileBnt.UseVisualStyleBackColor = true;
            this.CleanFileBnt.Click += new System.EventHandler(this.CleanFileBnt_Click);
            // 
            // ReadFileBnt
            // 
            this.ReadFileBnt.Location = new System.Drawing.Point(49, 8);
            this.ReadFileBnt.Name = "ReadFileBnt";
            this.ReadFileBnt.Size = new System.Drawing.Size(75, 23);
            this.ReadFileBnt.TabIndex = 15;
            this.ReadFileBnt.Text = "讀取檔案";
            this.ReadFileBnt.UseVisualStyleBackColor = true;
            this.ReadFileBnt.Click += new System.EventHandler(this.ReadFileBnt_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(215, 10);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(462, 22);
            this.FilePathTextBox.TabIndex = 14;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(718, 516);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // RegexExpressLabel
            // 
            this.RegexExpressLabel.AutoSize = true;
            this.RegexExpressLabel.Location = new System.Drawing.Point(48, 143);
            this.RegexExpressLabel.Name = "RegexExpressLabel";
            this.RegexExpressLabel.Size = new System.Drawing.Size(76, 12);
            this.RegexExpressLabel.TabIndex = 26;
            this.RegexExpressLabel.Text = "c#正規表達式";
            // 
            // RegexExpressTextBox
            // 
            this.RegexExpressTextBox.Location = new System.Drawing.Point(215, 133);
            this.RegexExpressTextBox.Name = "RegexExpressTextBox";
            this.RegexExpressTextBox.Size = new System.Drawing.Size(462, 22);
            this.RegexExpressTextBox.TabIndex = 27;
            this.RegexExpressTextBox.Text = "^(?<filePath>.*?)(?=\\.\\[545BC58F\\[decryptfile@onionmail\\.org\\]\\.)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CheckFileMovementResultBnt;
        private System.Windows.Forms.Label StoreFilePathPrefix;
        private System.Windows.Forms.TextBox StoreFilePathPrefixTextBox;
        private System.Windows.Forms.Button FilePathChangeBnt;
        private System.Windows.Forms.Button FileMoveBnt;
        private System.Windows.Forms.Label BacpUpSourcePathPrefixLabel;
        private System.Windows.Forms.Label EncryptedFiePathPrefixLabel;
        private System.Windows.Forms.TextBox BacpUpSourcePathPrefixTextBox;
        private System.Windows.Forms.TextBox EncryptedFiePathPrefixTextBox;
        private System.Windows.Forms.Button CleanFileBnt;
        private System.Windows.Forms.Button ReadFileBnt;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox RegexExpressTextBox;
        private System.Windows.Forms.Label RegexExpressLabel;
    }
}

