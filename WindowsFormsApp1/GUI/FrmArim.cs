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
    public partial class FrmArim : Form
    {
        arimTable arim = new arimTable();
        ir ir;
        public FrmArim()
        {
            InitializeComponent();
            ir = new ir();
            dgvarim.DataSource = arim.GetDataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmArim_Load(object sender, EventArgs e)
        {

        }

        private void dgvarim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChadash_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            btnAdcen.Visible = false;
            btnOsef.Visible = true;
            lblKod.Text = arim.GetNewKey().ToString();
        }

        private void btnOsef_Click(object sender, EventArgs e)
        {
            bool degel=true;
            errorProvider1.Clear();
            try
            {
                ir.KodIr = Convert.ToInt32(lblKod.Text);
                ir.ShemIr = txtShem.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShem, ex.Message);
                degel = false;

            }
            if (degel)
            {

                try
                {
                    ir.Add();
                    groupBox1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("הייתה שגיאה בהוספה" + ex.Message);
                }
            }
        }

        private void dgvarim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            btnOsef.Visible = false;
            btnAdcen.Visible = true;
            ir = new ir(Convert.ToInt32(dgvarim.SelectedRows[0].Cells[0].Value));
            lblKod.Text =ir.KodIr .ToString();
            txtShem.Text = ir.ShemIr;
        }

        private void btnAdcen_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            try
            {
                ir.ShemIr = txtShem.Text; 
                
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShem, ex.Message);
                degel = false;


            }
            if (degel)
            {

                try
                {
                    ir.Update();
                    groupBox1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("הייתה שגיאה בעדכון" + ex.Message);
                }
            }

            
        }

        private void btnMachak_Click(object sender, EventArgs e)
        {
            ir ir = new ir(Convert.ToInt32(dgvarim.SelectedRows[0].Cells[0].Value));
            DataView dv = new DataView(new asakimTable().GetDataTable());
            dv.RowFilter = "kodIr=" + ir.KodIr;
            if (dv.Count > 0)
                MessageBox.Show("לא ניתן למחוק כיוון שיש רשומות מקושרות");
            ir.Delete();
        }

        private void lblKod_Click(object sender, EventArgs e)
        {

        }
    }
    }

