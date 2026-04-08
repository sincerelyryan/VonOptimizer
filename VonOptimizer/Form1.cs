using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VonOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public WebClient wc = new WebClient();
        public string filepath = Application.StartupPath;


        private void Form1_Load(object sender, EventArgs e)
        {
           
            string changeLogs =  wc.DownloadString("https://pastebin.com/raw/Lrfqa1Qg");
            string kingvon = wc.DownloadString("https://pastebin.com/raw/n947PgBg");
            guna2TextBox1.AppendText(changeLogs);
            pictureBox1.ImageLocation = kingvon;



        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            
            foreach (Process i in process)
            {
                guna2HtmlLabel9.Text = "" + process.Length;
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            ProcessStartInfo RestorePoint = new ProcessStartInfo();
            {
                
                RestorePoint.FileName = "powershell.exe";
                RestorePoint.Arguments = "Checkpoint-Computer -Description \"VonOptimizer Restore Point\" -RestorePointType \"MODIFY_SETTINGS\"";

            }

            Process.Start(RestorePoint);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo config = new ProcessStartInfo();
            {
                config.WorkingDirectory = "C:\\Windows\\System32";
                config.FileName = "msconfig";
                

            }

            Process.Start(config);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string temp = Path.GetTempPath();
            string winTemp = Path.GetDirectoryName("C:\\Windows\\Temp\\");
            string prefetch = Path.GetDirectoryName("C:\\Windows\\Prefetch\\");
            foreach (string file in Directory.GetFiles(temp))
            {
                try
                {
                    File.Delete(file);
                    foreach (string dir in Directory.GetDirectories(temp))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {

                }
                                
            }
            foreach (string file in Directory.GetFiles(winTemp))
            {
                try
                {
                    File.Delete(file);
                    foreach (string dir in Directory.GetDirectories(winTemp))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {

                }

            }
            foreach (string file in Directory.GetFiles(prefetch))
            {
                try
                {
                    File.Delete(file);
                    foreach (string dir in Directory.GetDirectories(prefetch))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {

                }

            }
            ProcessStartInfo flushDNS = new ProcessStartInfo();
            {
                flushDNS.FileName = "cmd.exe";
                flushDNS.Arguments = "/c ipconfig /flushdns";
                flushDNS.UseShellExecute = false;
                flushDNS.CreateNoWindow = true;
            }
            Process.Start(flushDNS).WaitForExit();
            MessageBox.Show("Temp files have been deleted.");
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/settingsDebloat.bat", filepath + "\\settingsDebloat.bat");
            ProcessStartInfo settings = new ProcessStartInfo();
            {
                settings.FileName = "settingsDebloat.bat";
                settings.WorkingDirectory = Application.StartupPath;
            }

            Process.Start(settings).WaitForExit();
            MessageBox.Show("Settings have been debloated.");
            File.Delete("settingsDebloat.bat");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/ioTweaks.bat", filepath + "\\ioTweaks.bat");
            ProcessStartInfo settings = new ProcessStartInfo();
            {
                settings.FileName = "ioTweaks.bat";
                settings.WorkingDirectory = Application.StartupPath;
            }

            Process.Start(settings).WaitForExit();
            MessageBox.Show("IO has been tweaked.");
            File.Delete("ioTweaks.bat");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/disableTelemetry.bat", filepath + "\\disableTelemetry.bat");
            ProcessStartInfo settings = new ProcessStartInfo();
            {
                settings.FileName = "disableTelemetry.bat";
                settings.WorkingDirectory = Application.StartupPath;
            }

            Process.Start(settings).WaitForExit();
            MessageBox.Show("All Telemetry Has been disabled.");
            File.Delete("disableTelemetry.bat");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/Wub.exe",filepath + "\\Wub.exe");
            Process.Start("Wub.exe");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Checked == true)
            {
                Main.Visible = true;
                Main.BringToFront();

            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (guna2Button4.Checked == true)
            {
                Settings.Visible = true;
                Settings.BringToFront();

            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/powerplan.ps1", filepath + "\\powerPlan.ps1");
            ProcessStartInfo powerPlan = new ProcessStartInfo();
            {
                powerPlan.WorkingDirectory = Application.StartupPath;
                powerPlan.FileName = "powershell.exe";
                powerPlan.Arguments = Application.StartupPath + "\\powerPlan.ps1";
            }
            Process.Start(powerPlan).WaitForExit();
            MessageBox.Show("Power Plan has been set.");
            File.Delete("powerPlan.ps1");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/cpu.bat", filepath + "\\cpu.bat");
            Process.Start("cpu.bat").WaitForExit();
            MessageBox.Show("CPU has been tweaked.");
            File.Delete("cpu.bat");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/menuK.bat", filepath + "\\menuK.bat");
            Process.Start("menuK.bat").WaitForExit();
            MessageBox.Show("Menu time has been tweaked.");
            File.Delete("menuK.bat");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/disablePrinter.bat", filepath + "\\disablePrinter.bat");
            Process.Start("disablePrinter.bat").WaitForExit();
            MessageBox.Show("Printer services have been disabled.");
            File.Delete("disablePrinter.bat");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/uselessProcess.bat", filepath + "\\uselessProcess.bat");
            Process.Start("uselessProcess.bat").WaitForExit();
            MessageBox.Show("Useless Processes have been disabled.");
            File.Delete("uselessProcess.bat");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/uninstallUseless.bat", filepath + "\\uninstallUseless.bat");
            Process.Start("uninstallUseless.bat").WaitForExit();
            MessageBox.Show("Useless apps have been deleted.");
            File.Delete("uninstallUseless.bat");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/sincerelyryan/VonOptimizer/raw/refs/heads/main/tweaks/memreduct.exe",  filepath + "\\memreduct.exe");
            ProcessStartInfo memReduct = new ProcessStartInfo();
            {
                memReduct.FileName = "cmd.exe";
                memReduct.WorkingDirectory = Application.StartupPath;
                memReduct.Arguments = "/c memreduct.exe -clean";

            }
            Process.Start(memReduct).WaitForExit();
            MessageBox.Show("Memory Has been cleaned.");
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (guna2Button5.Checked == true)
            {
                Network.Visible = true;
                Network.BringToFront();

            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
