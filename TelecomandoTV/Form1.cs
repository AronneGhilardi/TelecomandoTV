using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelecomandoTV
{
    public partial class Form1 : Form
    {
        private TelecomandoTV TV;

        public Form1()
        {
            InitializeComponent();
            TV = new TelecomandoTV();
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (TV.getStato() == true)
            {
                TV.accendi();
                pictureBox1.BackColor = Color.Green;
            }
            else (TV.getStato() == false)
            {
                TV.spegni();
                pictureBox1.BackColor = Color.Red;
            }
        } 
    }
}
