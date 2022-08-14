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
using DiscordRpcDemo;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Management;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Diagnostics;
using System.Media;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main woof = new Main();
            woof.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }
    }
}