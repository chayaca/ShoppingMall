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
    public partial class FrmAsakim : Form
    {
        asakimTable asakim = new asakimTable();
        esek ee;
        DataView dv;
        hascarotTable hascarot;
        public FrmAsakim()
        {
            InitializeComponent();
             dv = new DataView(asakim.GetDataTable());
            dgvAsakim.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mazav= "SHOW";
            ee = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            FrmEsek f = new FrmEsek(mazav, ee);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEsek ff = new FrmEsek();
            ff.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "shemEsek like'" + txtShem.Text + "*'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           dv.RowFilter = "misEsek=" + txtKod.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ee = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            FrmEsek f = new FrmEsek(ee);
            f.Show();
        }

        private void FrmAsakim_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            esek esek = new esek(Convert.ToInt32(dgvAsakim.SelectedRows[0].Cells[0].Value));
            DataView dv = new DataView(new hascarotTable().GetDataTable());
            dv.RowFilter = "misEsek =" + esek.MailEsek ;
            if (dv.Count > 0)
                MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
            else
            {
                    dv = new DataView(new arimTable().GetDataTable());
                    dv.RowFilter = "kodIr =" + esek.kodIr;
                    if (dv.Count > 0)
                        MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
                    else
                    {
                        esek.Delete();
                    }
                
            }
           
        }
    }
}
