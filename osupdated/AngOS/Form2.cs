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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            d.Show();
            this.Hide();
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
    }
}
