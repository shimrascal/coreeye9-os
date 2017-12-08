using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngOS
{

    public partial class Form1 : Form
    {
        int z;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
          

        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 1;
            if (z > 50)
            {
                this.timer1.Enabled = false;
                new Form2().Show();
                this.Hide();


                return;

            }
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}