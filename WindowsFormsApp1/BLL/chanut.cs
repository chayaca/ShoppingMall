using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class chanut
    {
        chanuyotTale myT = new chanuyotTale();
        private int misChanut;

        public int MisChanut
        {
            get { return misChanut; }
            set { misChanut = value; }
        }
        private double godel;

        public double Godel
        {
            get { return godel; }
            set { godel = value; }
        }
        private int mechirHascaraChodshi;

        public int MechirHascaraChodshi
        {
            get { return mechirHascaraChodshi; }
            set { mechirHascaraChodshi = value; }
        }
        private string sugChanut;

        public string SugChanut
        {
            get { return sugChanut; }
            set { sugChanut = value; }
        }
        private bool kayamChalonRaava;

        public bool KayamChalonRaava
        {
            get { return kayamChalonRaava; }
            set { kayamChalonRaava = value; }
        }
        private bool kayamMachsan;

        public bool KayamMachsan
        {
            get { return kayamMachsan; }
            set { kayamMachsan = value; }
        }
        private double godelMachsan;

        public double GodelMachsan
        {
            get { return godelMachsan; }
            set { godelMachsan = value; }
        }
        private int koma;

        public int Koma
        {
            get { return koma; }
            set { koma = value; }
        }
        private int misAgaf;

        public int MisAgaf
        {
            get { return misAgaf; }
            set { misAgaf = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private int misPtachimLechanut;

        public int MisPtachimLechanut
        {
            get { return misPtachimLechanut; }
            set { misPtachimLechanut = value; }
        }
        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public chanut()
        {

        }
        public chanut(int misChanut)
        {
           drow= myT.Find(misChanut);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misChanut"] = misChanut;
            drow["godel"] = godel;
            drow["mechirHascaraChodshi"] = mechirHascaraChodshi;
            drow["sugChanut"] = sugChanut;
            drow["kayamChalonRaava"] = kayamChalonRaava;
            drow["kayamMachsan"] = kayamMachsan;
            drow["godelMachsan"] = godelMachsan;
            drow["koma"] = koma;
            drow["misAgaf"] = misAgaf;
            drow["status"] = status;
            drow["misPtachimLechanut"] = misPtachimLechanut;
        }
        public void FillFields()
        {
            misChanut = Convert.ToInt32(drow["misChanut"]);
            godel = Convert.ToDouble(drow["godel"]);
            mechirHascaraChodshi =Convert.ToInt32 (drow["mechirHascaraChodshi"]);
            sugChanut = drow["sugChanut"].ToString();
            kayamChalonRaava = Convert.ToBoolean(drow["kayamChalonRaava"]);
            kayamMachsan = Convert.ToBoolean(drow["kayamMachsan"]);
            godelMachsan = Convert.ToDouble(drow["godelMachsan"]);
            koma = Convert.ToInt32(drow["koma"]);
            misAgaf = Convert.ToInt32(drow["misAgaf"]);
            status = Convert.ToBoolean(drow["status"]);
            misPtachimLechanut = Convert.ToInt32(drow["misPtachimLechanut"]);
        }
        public void Add()// חדש הוספת רשומה חדשה
        {
            drow = myT.GetDataTable().NewRow();
            FillDrow();
            myT.GetDataTable().Rows.Add(drow);
            myT.Save();
        }
        public void Update()
        {
            FillDrow();
            myT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            myT.Save();
        }





    }
}
