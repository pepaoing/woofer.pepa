using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace KeyAuth
{
    public partial class Clean : Form
    {
        private Process Process;

        public static void RunAsProcess(string Code)
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + Code)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            });
            process?.WaitForExit();
            process?.Close();
        }
        public Clean()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RunAsProcess("ipconfig /release");
            RunAsProcess("ipconfig /flushdns");
            RunAsProcess("ipconfig /renew");
            RunAsProcess("ipconfig /flushdns");
            RunAsProcess("ping localhost -n 3 >nul");
                WebClient webClient1 = new WebClient();
                string text2 = "C:\\Windows\\Media\\mac.bat";
                using (WebClient webClient3 = new WebClient())
                {
                    webClient3.DownloadFile("https://cdn.discordapp.com/attachments/975854399953993768/1003777043076497531/mac.bat", text2);
                    Thread.Sleep(2000);
                    Process = Process.Start(text2);
                    Process.StartInfo.FileName = text2;
                    Process.StartInfo.UseShellExecute = true;
                    Process.StartInfo.Verb = "runas";

                    System.Windows.MessageBox.Show("Done Run AppleCheats Cleaner");
                }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }
    }
}