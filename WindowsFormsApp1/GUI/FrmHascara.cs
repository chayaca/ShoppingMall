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
    public partial class FrmHascara : Form
    {
        hascarotTable hascarot = new hascarotTable();
        hascara hascara;
        chanut ch;

        tashlumimLehascaraTable tashlumim = new tashlumimLehascaraTable();
        tashlumLehascara tashlum;
        sherutimBehascaraTable sherutim = new sherutimBehascaraTable();
        sherutBehascara sherut;
        public void AvBenTash()
        {
            DataView dvTash = new DataView(new tashlumimLehascaraTable().GetDataTable());
            dgvTashlumim.DataSource = dvTash;
            dgvTashlumim.Visible = true;
            dvTash.RowFilter = "MisHascara=" + hascara.MisHascara;


        }
        public void AvBenSh()
        {
            DataView dvsh = new DataView(new sherutimBehascaraTable().GetDataTable());
            dgvSherutim.DataSource = dvsh;
            dgvSherutim.Visible = true;
            dvsh.RowFilter = "MisHascara=" + hascara.MisHascara;
        }

        public FrmHascara(chanut ch)
        {
            InitializeComponent();
            MiluyCombo();
            hascara = new hascara();
            this.ch = ch;
        }
        public void MiluyCombo()
        {
            cmbMisEsek.DataSource = new asakimTable().GetDataTable();
            cmbMisEsek.DisplayMember = "misEsek";
            cmbMisEsek.ValueMember = "shemEsek";
            cmbSherutim.DataSource = new sherutimBehascaraTable().GetDataTable();
            cmbSherutim.DisplayMember = "shemSherut";
            cmbSherutim.ValueMember = "misSherut";
        }
        private void FrmHascara_Load(object sender, EventArgs e)
        {
            lblMisHascara.Text = hascarot.GetNewKey().ToString();
            lblTaarichBakasha.Text = DateTime.Today.ToShortDateString();
            lblMisChanut.Text = ch.MisChanut.ToString();
            lblMechir.Text = ch.MechirHascaraChodshi.ToString();
            AvBenTash();
            dgvTashlumim.Visible = false;
            dgvSherutim.Visible = false;
        }

        private void taarichBakasha_Click(object sender, EventArgs e)
        {

        }

        private void misChanut_Click(object sender, EventArgs e)
        {

        }

        private void cmbMisEsek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOfen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOfen.Text == "אשראי")
            {
                grbAshray.Visible = true;
                grbHoraat.Visible = false;
            }
            else
            {
                grbHoraat.Visible = true;
                grbAshray.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            hascara.MisHascara = Convert.ToInt32(lblMisHascara.Text);
            hascara.TaarichBakashatHascara = Convert.ToDateTime(lblTaarichBakasha.Text);
            hascara.MisChanut = Convert.ToInt32(lblMisChanut.Text);
            hascara.MisEsek = Convert.ToInt32(cmbMisEsek.Text);
            hascara.MeshechZmanHachoze = Convert.ToInt32(nudZmanChoze.Value);
            hascara.OptzyaLehaaracha = chbhaaracha.Checked;
            hascara.OfenTashlum = cmbOfen.Text;
            hascara.TaarichKnisa = Convert.ToDateTime(dtpKnisa.Text);


            if (cmbOfen.Text == "אשראי")
            {
                try
                {
                    hascara.MisAshray = txtMisAshray.Text;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisAshray, ex.Message);
                    degel = false;
                }
                try
                {
                    hascara.Tokef = Convert.ToDateTime(dtpTokef.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(dtpTokef, ex.Message);
                    degel = false;

                }
                try
                {
                    hascara.Cvv = Convert.ToInt32(txtCvv.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtCvv, ex.Message);
                    degel = false;

                }

            }
            else
            {
                try
                {
                    hascara.MisAsmachta = txtMisAsmachta.Text;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisAsmachta, ex.Message);
                    degel = false;

                }
                try
                {
                    hascara.MisBank = Convert.ToInt32(txtMisBank.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisBank, ex.Message);
                    degel = false;

                }
                try
                {
                    hascara.MisSnif = Convert.ToInt32(txtMisSnif.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisSnif, ex.Message);
                    degel = false;

                }
                try
                {
                    hascara.MisCheshbon = Convert.ToInt32(txtMisCheshbon.Text);
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtMisCheshbon, ex.Message);
                    degel = false;

                }

                ch.Status = true;
                ch.Update();



            }

            if (degel)
            {
                try
                {
                    hascara.Add();
                    PtichatTashlumim();
                    PtichatSherutim();
                    AvBenTash();
                    AvBenSh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("קרתה שגיאה בהוספה" + ex.Message);

                }
            }

        }
        public void PtichatTashlumim()
        {
            int chodesh, shana;
            chodesh = dtpKnisa.Value.Month;
            shana = dtpKnisa.Value.Year;
            for (int i = 0; i < hascara.MeshechZmanHachoze; i++)
            {
                tashlum = new tashlumLehascara();
                tashlum.MisTashlum = tashlumim.GetNewKey();
                tashlum.MisHascara = hascara.MisHascara;
                tashlum.SachTashlumChodshi = ch.MechirHascaraChodshi;
                tashlum.Chodesh = chodesh;
                tashlum.Shana = shana;
                chodesh = chodesh + 1;
                if (chodesh == 12)
                {
                    chodesh = 1;
                    shana = shana + 1;
                }
                tashlum.Add();
            }
        }
        public void PtichatSherutim()
        {
            sherut.MisPerutSherutBehascara = 
            sherut.MisHascara = hascara.MisHascara;
            sherut.MisSherut= sherutim.GetNewKey();
        }

        private void lblMechir_Click(object sender, EventArgs e)
        {
            
        }

        private void chbsherut_CheckedChanged(object sender, EventArgs e)
        {
            cmbSherutim.Visible = true;
        }
    }
}
