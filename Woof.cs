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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System.Media;
using DiscordRpcDemo;
using System.Windows;
using System.Management;
using System.Diagnostics;
using System.Xml.Linq;

namespace KeyAuth
{
    public partial class Woof : Form
    {

        public Woof()
        {
            InitializeComponent();

        }

        private string IDgenerate;

        //generates random string
        private static Random rndhwid = new Random();
        public static string randstring(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rndhwid.Next(s.Length)]).ToArray());
        }
        private static readonly Random rand = new Random(DateTime.Now.Second);
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
        private static void SpoofMachineID()
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c "));

           RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\SQMClient", true);
            registryKey.SetValue("MachineId", "{" + Guid.NewGuid().ToString().ToUpper() + "}");
        }
        private static void SpoofMachineGUID()
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c "));
            string value = Guid.NewGuid().ToString();
            RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true);
            registryKey.SetValue("MachineGuid", value);
        }
        private static void SpoofProfileGUID()
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c "));
            RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
            registryKey.SetValue("HwProfileGUID", "{" + Guid.NewGuid().ToString() + "}");
        }
        private static void SpoofProductID()
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c "));
            RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
            registryKey.SetValue("ProductID", $"{RandomNumberString(5)}-{RandomNumberString(5)}-{RandomNumberString(5)}-{RandomString(5)}");
            registryKey.Close();
        }
        public static string RandomString(int length)
        {
            char[] array = "abcdefghlijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToArray();
            string text = string.Empty;
            for (int i = 0; i < length; i++)
            {
                text += array[rand.Next(array.Length)].ToString();
            }
            return text;
        }
        public static string RandomNumberString(int length)
        {
            char[] array = "0123456789".ToArray();
            string text = string.Empty;
            for (int i = 0; i < length; i++)
            {
                text += array[rand.Next(array.Length)].ToString();
            }
            return text;
        }
        public static bool IsAdministrator()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }



            private static Random rando = new Random();
            public static string rndString(int length)
            {
                const string chars = "ABCDEF0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[rando.Next(s.Length)]).ToArray());
            }
            public static void VolumeIDSpoof()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                for (int ctr = 0; ctr < drives.Length; ctr++)
                {
                    //Volume ID for change serials
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    process.StandardInput.WriteLine("cd C:/Windows/Media/");
                    process.StandardInput.Flush();
                    process.StandardInput.WriteLine("start Volumeid.exe");
                    process.StandardInput.Flush();
                    process.StandardInput.WriteLine("volumeid " + drives[ctr].Name.Substring(0, 2) + " " + rndString(4) + "-" + rndString(4));
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                }
            }
        

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Woof woof = new Woof();
            woof.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
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

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Not Allowed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Not Allowed");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        Random random = new Random();
        public const string Alphabet = "ABCDEF0123456789";
        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[random.Next(Alphabet.Length)];
            }
            return new string(chars);
        }
        
        private string[] regkeyshwid = new string[]
        {
            "HARDWARE\\Description\\System\\CentralProcessor\\0",
            "HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
            "SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
            "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
            "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
            "HARDWARE\\DESCRIPTION\\System\\BIOS",
        };

        //nop - no operations
        private string[,] ValuesKeysHWID = new string[,]
        {
            {"SystemProductName", "Identifier", "Previous Update Revision", "ProcessorNameString", "VendorIdentifier", "Platform Specific Field1", "Component Information"},
            {"SerialNumber", "Identifier", "SystemManufacturer", "nop", "nop", "nop", "nop"},
            {"ComputerHardwareId", "ComputerHardwareIds", "BIOSVendor", "ProductId", "ProcessorNameString", "BIOSReleaseDate", "nop"},
            {"ProductId", "InstallDate", "InstallTime", "nop", "nop", "nop", "nop"},
            {"SusClientId", "nop", "nop", "nop", "nop", "nop", "nop"},
            {"BaseBoardManufacturer", "BaseBoardProduct", "BIOSVersion", "nop", "SystemManufacturer", "SystemProductName", "nop"},
        };

        public Process Process { get; private set; }

        public void SpoofHWID()
        {
            //Spoofing Hardware ID(for avoid EAC ban FOREVER)
            IDgenerate = randstring(20);
            for (int ctr = 0; ctr < regkeyshwid.Length; ctr++)
            {
                spoofRegistryKey(ctr);
            }
        }
        private void spoofRegistryKey(int regKeyIndex)
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(regkeyshwid[regKeyIndex], true);

            if (registryKey == null)
                return;

            for (int ctr = 0; ctr < ValuesKeysHWID.GetLength(1); ctr++)
            {
                if (ValuesKeysHWID[regKeyIndex, ctr] == "nop")
                    break;

                registryKey.SetValue(ValuesKeysHWID[regKeyIndex, ctr], IDgenerate);
                IDgenerate = randstring(20);
            }

            registryKey.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SpoofProductID();
            SpoofProfileGUID();
            SpoofMachineID();
            SpoofMachineGUID();
            SpoofHWID();
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/973254736205721610/1004069066153144471/Driver.sys", @"C:\Windows\Media\Driver.sys");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/973215142353440868/1004036854879891506/kdmapper1.exe", @"C:\Windows\Media\kdmapper1.exe");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/973215142353440868/1004036855190266027/driverload.bat", @"C:\Windows\Media\driverload.bat");
            System.Diagnostics.Process.Start(@"C:\Windows\Media\driverload.bat");
            System.Threading.Thread.Sleep(700);
            File.Delete(@"C:\Windows\Media\Driver.sys");
            File.Delete(@"C:\Windows\Media\driverload.bat");
            System.Windows.MessageBox.Show("Driver + Guid Woofed Wait For MotherBoard, Gpu Changer And Disk");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/975854399953993768/1004020639478333541/Volumeid.exe", @"C:\Windows\Media\Volumeid.exe");
            VolumeIDSpoof();
            WebClient webClient2 = new WebClient();
            string text2 = "C:\\Windows\\Media\\gpu.exe";
            using (WebClient webClient3 = new WebClient())
            {
                webClient3.DownloadFile("https://download1337.mediafire.com/2jisy1qag2pg/kp0ooey9ye32zvc/gpu.exe", text2);
                Thread.Sleep(2000);
                Process = Process.Start(text2);
                Process.StartInfo.FileName = text2;
                Process.StartInfo.UseShellExecute = true;
                Process.StartInfo.Verb = "runas";
                System.Windows.MessageBox.Show("Done Launch Clean");
            }
        }
    
            

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            Clean clean = new Clean();
            clean.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}