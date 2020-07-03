using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class ir
    {
        arimTable myT = new arimTable();
        private int kodIr;

        public int KodIr
        {
            get { return kodIr; }
            set { kodIr = value; }
        }
        private string shemIr;

        public string ShemIr
        {
            get { return shemIr; }
            set {if (value.Length < 2)
                    throw new Exception("שם עיר לא יכול להיות תו אחד");
                shemIr = value; }
        }
        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public ir()
        {

        }
        public ir(int KodIr)
        {
          drow=  myT.Find(KodIr);
            FillFields();
        }
        public void FillDrow()
        {
            drow["kodIr"] = kodIr;
            drow["shemIr"] = shemIr;
        }
        public void FillFields()
        {
            kodIr = Convert.ToInt32(drow["kodIr"]);
            shemIr = drow["shemIr"].ToString();
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
