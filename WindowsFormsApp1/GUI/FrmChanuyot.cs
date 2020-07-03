using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
namespace WindowsFormsApp1.GUI
{
    public partial class FrmChanuyot : Form
    {
        chanuyotTale chanuyot = new chanuyotTale();
        chanut chanut;
       
        DataView d;

        public FrmChanuyot()
        {
            InitializeComponent();
          
            MiluyCombo();
            d = new DataView(chanuyot.GetQuery());
            dgvChanuyot.DataSource = d;
        }
        public void MiluyCombo()
        {
         
        }
        private void FrmChanuyot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmchanut ff = new Frmchanut();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chanut = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            Frmchanut ff = new Frmchanut(chanut);
            ff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string matzav = "SHOW";
            chanut = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            Frmchanut ff = new Frmchanut(matzav, chanut);
            ff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chanut c = new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[0].Value));
            DataView dv = new DataView(new hascarotTable().GetDataTable());
            dv.RowFilter = "misChanut=" + c.MisChanut;
            if (dv.Count > 0)
                MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
            else
                c.Delete();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMechir.Visible = true;

        }

        private void txtMechir_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtShetach.Visible = true;
        }

        private void txtShetach_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = "";
            string a = "";
            if (chbMechir.Checked == true)
            {
                s = s + "mechirHascaraChodshi<=" + txtMechir.Text;
                a = " and ";
            }
            if (chbShetach.Checked == true)
            {
                s = s + a + "godel>=" + txtShetach.Text;
                a = " and ";
            }
            if (chbMachsan.Checked == true)
            {
                s = s + a + "kayamMachsan=true";
                a = " and ";
            }
            if (chbSug.Checked == true)
            {
                s = s + a + "sugChanut= '" + cmbSug.Text+"'";
            }
            if (s != "")
            {
                d.RowFilter = s;
            }
        }

        private void chbSug_CheckedChanged(object sender, EventArgs e)
        {
            cmbSug.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chanut=new chanut(Convert.ToInt32(dgvChanuyot.SelectedRows[0].Cells[1].Value));
            FrmHascara ff = new FrmHascara(chanut);
            ff.Show();
        }
    }
}
