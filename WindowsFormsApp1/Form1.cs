using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArim ff = new FrmArim();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsakim ff = new FrmAsakim();
            ff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmChanuyot ff = new FrmChanuyot();
            ff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHascarot ff = new FrmHascarot();
            ff.Show();
        }
    }
}
