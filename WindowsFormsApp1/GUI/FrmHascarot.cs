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
    public partial class FrmHascarot : Form
    {
        hascarotTable hascarot = new hascarotTable();
        hascara hascara1 = new hascara();
        public FrmHascarot()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHascarot_Load(object sender, EventArgs e)
        {
            dgvHascarot.DataSource = hascarot.GetDataTable();
        }
    }
}
