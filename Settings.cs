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
using System.Media;
namespace KeyAuth
{
    public partial class Settings : Form
    {

        public Settings()
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("No Music 😡");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}