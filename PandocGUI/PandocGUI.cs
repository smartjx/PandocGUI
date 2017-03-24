using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace PandocGUI
{
    public partial class PandocGUI : Form
    {
     private static   StringBuilder output = new StringBuilder();
     private static int lineCount = 0;
     private static CommandModel cm = new CommandModel();
        private static bool convertSuccess = false;
        public PandocGUI()
        {
            InitializeComponent();
          
             txtOutput.Text = Properties.Settings.Default.OutputPath;
        }

        private async void convert_Click(object sender, EventArgs e)
        {
            convertSuccess = true;

            if (txtSource.Text.Length < 1)
            {
                MessageBox.Show("没有选择源文件，请选择后再转换");
            }
            else
            {
                richTextBox1.Text = "转换中...请耐心等待...";
              //  updateCommandModel();
                var commandtorun = richTextBox2.Text;
                await Task.Factory.StartNew(() => runPandoc(commandtorun),
                                    TaskCreationOptions.LongRunning);

                
                richTextBox1.Text = output.ToString();
                
            }
         }

        private void selectSource_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtSource.Text = openFileDialog1.FileName;
                Properties.Settings.Default.SourceFile = openFileDialog1.FileName;
                Properties.Settings.Default.Save();

                updateCommandModel();
            }

        }

        private void updateCommandModel()
        {
            cm.defaultCommand = " -o ";
            cm.inputfile = "\"" + txtSource.Text + "\"";  
            cm.outputfile = "\"" + txtOutput.Text + "\\" + openFileDialog1.SafeFileName+ "." + cbFormat.SelectedItem + "\""; 
            cm.outputformat ="";
            cm.outputStyle = " " + cbStyle.SelectedItem;
             richTextBox2.Text = cm.inputfile + cm.defaultCommand + cm.outputfile + cm.outputformat + cm.outputStyle;
        }

        private void selectOutput_Click(object sender, EventArgs e)
         {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtOutput.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.OutputPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();

                updateCommandModel();
            }

        }

        private string runPandoc(string command)
        {
              output.Clear();
             output.Append("转换失败!");
            var pandocPath = new Uri(
         System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
         ).LocalPath + "\\Pandoc\\pandoc.exe";

            var process = new Process
            {
                StartInfo =
                            new ProcessStartInfo(pandocPath)
                            { RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                UseShellExecute = false,
                                Arguments = command,
                                CreateNoWindow = true
                         }
            };

 
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    output.Append("\n[" + lineCount + "]: " + e.Data);
                  }
            });

            process.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
               
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    convertSuccess = false;
                    lineCount++;
                    output.Append("\n[" + lineCount + "]: " + e.Data);
 
                }
            });


            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            if (convertSuccess == true)
            {
                output.Clear();
                output.Append("转换完成");
            }
         
            return output.ToString();

           

        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCommandModel();
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCommandModel();

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@Properties.Settings.Default.OutputPath); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请访问https://github.com/smartjx/PandocGUI 获取最新版本");
        }
    }
}
