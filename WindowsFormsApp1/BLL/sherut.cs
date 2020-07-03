using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class sherut
    {
        sherutimTable myT = new sherutimTable();
        private int misSherut;

        public int MisSherut
        {
            get { return misSherut; }
            set { misSherut = value; }
        }
        private string shemSherut;

        public string ShemSherut
        {
            get { return shemSherut; }
            set { shemSherut = value; }
        }
        private int mechirChodshi;

        public int MechirChodshi
        {
            get { return mechirChodshi; }
            set { mechirChodshi = value; }
        }
        private string sugSherut;

        public string SugSherut
        {
            get { return sugSherut; }
            set { sugSherut = value; }
        }
        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public sherut()
        {

        }
        public sherut(int misSherut)
        {
          drow=  myT.Find(misSherut);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misSherut"] = misSherut;
            drow["shemSherut"] = shemSherut;
            drow["mechirChodshi"] = mechirChodshi;
            drow["sugSherut"] = sugSherut; 
        }
        public void FillFields()
        {
            misSherut = Convert.ToInt32(drow["misSherut"]);
            shemSherut = drow["shemSherut"].ToString();
            mechirChodshi = Convert.ToInt32(drow["mechirChodshi"]);
            sugSherut = drow["sugSherut"].ToString();
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
