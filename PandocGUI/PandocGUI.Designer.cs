namespace PandocGUI
{
    partial class PandocGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PandocGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.selectSource = new System.Windows.Forms.Button();
            this.selectOutput = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(63, 30);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(267, 22);
            this.txtSource.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(63, 60);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(267, 22);
            this.txtOutput.TabIndex = 3;
            // 
            // selectSource
            // 
            this.selectSource.Location = new System.Drawing.Point(336, 30);
            this.selectSource.Name = "selectSource";
            this.selectSource.Size = new System.Drawing.Size(75, 25);
            this.selectSource.TabIndex = 4;
            this.selectSource.Text = "选择";
            this.selectSource.UseVisualStyleBackColor = true;
            this.selectSource.Click += new System.EventHandler(this.selectSource_Click);
            // 
            // selectOutput
            // 
            this.selectOutput.Location = new System.Drawing.Point(336, 58);
            this.selectOutput.Name = "selectOutput";
            this.selectOutput.Size = new System.Drawing.Size(75, 24);
            this.selectOutput.TabIndex = 5;
            this.selectOutput.Text = "选择";
            this.selectOutput.UseVisualStyleBackColor = true;
            this.selectOutput.Click += new System.EventHandler(this.selectOutput_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "html",
            "pdf",
            "docx",
            "txt",
            "epub",
            "json",
            "md"});
            this.cbFormat.Location = new System.Drawing.Point(63, 88);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(267, 24);
            this.cbFormat.TabIndex = 6;
            this.cbFormat.Text = "docx";
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "格式:";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(417, 171);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(106, 64);
            this.convert.TabIndex = 8;
            this.convert.Text = "转换";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 256);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(527, 83);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "样式：";
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "-c Github.css"});
            this.cbStyle.Location = new System.Drawing.Point(63, 118);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(267, 24);
            this.cbStyle.TabIndex = 11;
            this.cbStyle.Text = "-c Github.css";
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 171);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(411, 64);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "以下命令行可修改：";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(417, 58);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(107, 24);
            this.btnOpenFolder.TabIndex = 14;
            this.btnOpenFolder.Text = "打开文件夹";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 30);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PandocGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 339);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.selectOutput);
            this.Controls.Add(this.selectSource);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PandocGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PandocGUI";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button selectSource;
        private System.Windows.Forms.Button selectOutput;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

