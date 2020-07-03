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
    
    public partial class Frmchanut : Form
    {
        chanuyotTale chanuyot = new chanuyotTale();
        chanut ch;
        string status;
        public Frmchanut()
        {
            InitializeComponent();
            ch = new chanut();
            status = "NEW";
            lblMisChanut.Text = chanuyot.GetNewKey().ToString();
        }
        public Frmchanut(chanut chanut)
        {
            InitializeComponent();
            ch = chanut;
            status = "UPDATE";
            lblMisChanut.Text = chanut.MisChanut.ToString();
            txtGodel.Text = chanut.Godel.ToString();
            txtMechirHascara.Text = chanut.MechirHascaraChodshi.ToString();
            txtSugChanut.Text = chanut.SugChanut;
            chbKayamChalon.Checked = chanut.KayamChalonRaava;
            chbKayamMachsan.Checked = chanut.KayamMachsan;
            txtGodelMachsan.Text = chanut.GodelMachsan.ToString();
            txtKoma.Text = chanut.Koma.ToString();
            txtMisAgaf.Text = chanut.MisAgaf.ToString();
            chbStatus.Checked = chanut.Status;
            txtMisPtachim.Text = chanut.MisPtachimLechanut.ToString();

        }
        public Frmchanut(string bb,chanut chanut)
        {
            InitializeComponent();
            ch = chanut;
            status = bb;
            lblMisChanut.Text = chanut.MisChanut.ToString();
            txtGodel.Text = chanut.Godel.ToString();
            txtMechirHascara.Text = chanut.MechirHascaraChodshi.ToString();
            txtSugChanut.Text = chanut.SugChanut;
            chbKayamChalon.Checked = chanut.KayamChalonRaava;
            chbKayamMachsan.Checked = chanut.KayamMachsan;
            txtGodelMachsan.Text = chanut.GodelMachsan.ToString();
            txtKoma.Text = chanut.Koma.ToString();
            txtMisAgaf.Text = chanut.MisAgaf.ToString();
            chbStatus.Checked = chanut.Status;
            txtMisPtachim.Text = chanut.MisPtachimLechanut.ToString();
            groupBox1.Enabled = false;

        }
        



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            ch.MisChanut=Convert.ToInt32(lblMisChanut.Text);
            try
            {
                ch.Godel=Convert.ToInt32(txtGodel.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtGodel, ex.Message);
                degel = false;
            }
            try
            {
                ch.MechirHascaraChodshi = Convert.ToInt32(txtMechirHascara.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMechirHascara, ex.Message);
                degel = false;
            }
            try
            {
                ch.SugChanut = txtSugChanut.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtSugChanut, ex.Message);
                degel = false;
            }
            try
            {
                ch.KayamChalonRaava = chbKayamChalon.Checked;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(chbKayamChalon, ex.Message);
                degel = false;
            }
            try
            {
                ch.KayamMachsan = chbKayamMachsan.Checked;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(chbKayamMachsan, ex.Message);
                degel = false;
            }
            try
            {
                ch.GodelMachsan = Convert.ToInt32(txtGodelMachsan.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtGodelMachsan, ex.Message);
                degel = false;
            }
            try
            {
                ch.Koma = Convert.ToInt32(txtKoma.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtKoma, ex.Message);
                degel = false;
            }
            try
            {
                ch.MisAgaf = Convert.ToInt32(txtMisAgaf.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMisAgaf, ex.Message);
                degel = false;
            }
            try
            {
                ch.Status = chbStatus.Checked;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(chbStatus, ex.Message);
                degel = false;
            }
            try
            {
                ch.MisPtachimLechanut = Convert.ToInt32(txtMisPtachim.Text);
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtMisPtachim, ex.Message);
                degel = false;
            }
            if(degel)
            {
                if (status == "NEW")
                {
                    try
                    {
                        ch.Add();
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("קרתה שגיאה בהוספה" + ex.Message);
                    }
                }
                if (status == "UPDATE")
                {
                    try
                    {
                        ch.Update();
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("קרתה שגיאה בעדכון" + ex.Message);
                    }
                }
                if(status=="SHOW")
                {
                    this.Close();
                }
               
            }

        }

        private void Frmchanut_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
