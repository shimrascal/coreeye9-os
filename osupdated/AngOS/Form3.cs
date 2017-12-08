using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AngOS
{
    public partial class Form3 : Form
    {
        int pw;
        bool hided;
        string fileloc;
        public Form3()
        {
            InitializeComponent();
            pw = panel2.Width;
            hided = false;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer3.Start();
            label7.Text = DateTime.Now.ToLongDateString();
            label8.Text = DateTime.Now.ToLongTimeString();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                panel2.Width = panel2.Width + 15;
                if (panel2.Width >= pw)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 15;
                if (panel2.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "chrome.exe";
            p.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //notepad
            Process p = new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.Start();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //drive c
            Process p = new Process();
            p.StartInfo.FileName = "C:";
            p.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ms word
            Process p = new Process();
            p.StartInfo.FileName = "WINWORD.exe";
            p.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //media player
            Process p = new Process();
            p.StartInfo.FileName = "wmplayer.exe";
            p.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"-s -t 60");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"-r -t 60");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //log off
            this.Hide();
            Form2 l = new Form2();
            l.Show();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"-a");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label8.Text = DateTime.Now.ToLongTimeString();
            timer3.Start();
        }
    }
    }

