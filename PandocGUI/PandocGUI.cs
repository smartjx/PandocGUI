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

        public PandocGUI()
        {
            InitializeComponent();
             txtOutput.Text = Properties.Settings.Default.OutputPath;
        }

        private async void convert_Click(object sender, EventArgs e)
        {

            var onlyFileName = System.IO.Path.GetFileName(txtSource.Text);
            var command = txtSource.Text + " -o " +  txtOutput.Text+"\\" + onlyFileName+ "." + cbFormat.SelectedItem;
            //runPandoc(command);

        await Task.Factory.StartNew(() => runPandoc(@command),
                                TaskCreationOptions.LongRunning);

            richTextBox1.Text = output.ToString();
          //  System.Diagnostics.Process.Start("pandoc", command);
        }

        private void selectSource_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtSource.Text = openFileDialog1.FileName;

                
                Properties.Settings.Default.SourceFile = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
           
        }
         
        private void selectOutput_Click(object sender, EventArgs e)
         {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtOutput.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.OutputPath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
             }

        }

        private string runPandoc(string command)
        {

            //  var output = "";
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
                    lineCount++;
                    output.Append("\n[" + lineCount + "]: " + e.Data);
 
                }
            });


            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
           return output.ToString();

           

        }
    
   
}
}
