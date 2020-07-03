using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class sherutBehascara
    {
        sherutimBehascaraTable myT = new sherutimBehascaraTable();
        private int misPerutSherutBehascara;

        public int MisPerutSherutBehascara
        {
            get { return misPerutSherutBehascara; }
            set { misPerutSherutBehascara = value; }
        }
        private int misHascara;

        public int MisHascara
        {
            get { return misHascara; }
            set { misHascara = value; }
        }
        private int misSherut;

        public int MisSherut
        {
            get { return misSherut; }
            set { misSherut = value; }
        }
        private int chodesh;

        public int Chodesh
        {
            get { return chodesh; }
            set { chodesh = value; }
        }
        private int shana;

        public int Shana
        {
            get { return shana; }
            set { shana = value; }
        }
        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public sherutBehascara()
        {

        }
        public sherutBehascara(int misPerutSherutBehascara)
        {
          drow=  myT.Find(misPerutSherutBehascara);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misPerutSherutBehascara"] = misPerutSherutBehascara;
            drow["misHascara"] = misHascara;
            drow["misSherut"] = misSherut;
            drow["chodesh"] = chodesh;
            drow["shana"] = shana;
        }
        public void FillFields()
        {
            misPerutSherutBehascara = Convert.ToInt32(drow["misPerutSherutBehascara"]);
            misHascara = Convert.ToInt32(drow["misHascara"]);
            misSherut = Convert.ToInt32(drow["misSherut"]);
            chodesh = Convert.ToInt32(drow["chodesh"]);
            shana = Convert.ToInt32(drow["shana"]);
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
