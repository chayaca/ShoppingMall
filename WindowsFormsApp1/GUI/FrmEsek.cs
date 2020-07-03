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
    public partial class FrmEsek : Form
    {
        asakimTable asakim = new asakimTable();
        esek es;
        string frmStatus;
        public FrmEsek()
        {
            InitializeComponent();
            es = new esek();
            MiluyCombo();
            frmStatus = "NEW";
        }
        public FrmEsek(esek ee)
        {
            InitializeComponent();
            es = ee;
            MiluyCombo();
            frmStatus = "UPDATE";
            lblMis.Text = ee.MisEsek.ToString();
            txtShemEsek.Text = ee.ShemEsek;
            txtShemIshKesher.Text = ee.ShemIshKesher;
            txtNayad.Text = ee.NayadIshKesher;
            cmbkid.SelectedValue = ee.Kidomet;
            txtMailIshKesher.Text = ee.MailIshKesher;
            txtCtovet.Text = ee.CtovetMisrad;
           cmbShemIr.SelectedValue = ee.kodIr.ToString();
         }
        public FrmEsek(string bb,esek ee)
        {
            InitializeComponent();
            es = ee;
            MiluyCombo();
            frmStatus = bb;
            lblMis.Text = ee.MisEsek.ToString();
            txtShemEsek.Text = ee.ShemEsek;
            txtShemIshKesher.Text = ee.ShemIshKesher;
            txtNayad.Text = ee.NayadIshKesher;
            cmbkid.SelectedValue = ee.Kidomet;
            txtMailIshKesher.Text = ee.MailIshKesher;
            txtCtovet.Text = ee.CtovetMisrad;
            cmbShemIr.SelectedValue = ee.kodIr.ToString();
            lblMis.Enabled = false;
            txtShemEsek.Enabled = false;
            txtShemIshKesher.Enabled = false;
            txtNayad.Enabled = false;
            cmbkid.Enabled = false;
            txtMailIshKesher.Enabled = false;
            txtCtovet.Enabled = false;
            cmbShemIr.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            bool degel = true;
            errorProvider1.Clear();
            es.MisEsek =Convert.ToInt32(  lblMis.Text);
            try
            {
              es.ShemEsek = txtShemEsek.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemEsek, ex.Message);
                degel = false;
            }
            try
            {
               es.ShemIshKesher = txtShemIshKesher.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtShemIshKesher, ex.Message);
                degel = false;
            }
            try
            {
                es.NayadIshKesher = txtNayad.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtNayad, ex.Message);
                degel = false;
            }
              es.Kidomet = cmbkid.Text;
            try
            {
                es.MailIshKesher = txtMailIshKesher.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMailIshKesher, ex.Message);
                degel = false;
            }
            try
            {
                es.CtovetMisrad = txtCtovet.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtCtovet, ex.Message);
                degel = false;
            }
               es.kodIr =Convert.ToInt32( cmbShemIr.SelectedValue);
            try
            {
                es.MailEsek = txtMailEsek.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMailEsek, ex.Message);
                degel = false;
            }
            es.kodIr = Convert.ToInt32(cmbShemIr.SelectedValue);
            if (degel)
            {
                if (frmStatus == "NEW")
                {
                    try
                    {
                        es.Add();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("קרתה שגיאה בהוספה" + ex.Message);
                    }
                }
                if (frmStatus == "UPDATE")
                {
                    try
                    {
                        es.Update();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("קרתה שגיאה בעדכון" + ex.Message);
                    }
                    
                }
                if (frmStatus == "SHOW")
                {
                    this.Close();
                }


            }
          




            
            
        }

        private void lblMis_Click(object sender, EventArgs e)
        {

        }

        private void FrmEsek_Load(object sender, EventArgs e)
        {
            if(frmStatus=="NEW")
            lblMis.Text = asakim.GetNewKey().ToString();
        }
        public void MiluyCombo()
        {
            cmbkid.DataSource = new kidomotTable().GetDataTable();
            cmbkid.DisplayMember = "kidomet";
            cmbkid.ValueMember = "kidomet";
            cmbShemIr.DataSource = new arimTable().GetDataTable();
            cmbShemIr.DisplayMember = "shemIr";
            cmbShemIr.ValueMember = "kodIr";
        }

        private void txtShemEsek_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbShemIr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
