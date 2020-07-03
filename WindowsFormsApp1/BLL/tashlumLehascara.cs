using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class tashlumLehascara
    {
        tashlumimLehascaraTable myT = new tashlumimLehascaraTable();
        private int misTashlum;

        public int MisTashlum
        {
            get { return misTashlum; }
            set { misTashlum = value; }
        }
        private int misHascara;

        public int MisHascara
        {
            get { return misHascara; }
            set { misHascara = value; }
        }
        private int sachTashlumChodshi;

        public int SachTashlumChodshi
        {
            get { return sachTashlumChodshi; }
            set { sachTashlumChodshi = value; }
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
        public tashlumLehascara()
        {

        }
        public tashlumLehascara(int misTashlum)
        {
           drow= myT.Find(misTashlum);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misTashlum"] = misTashlum;
            drow["misHascara"] = misHascara;
            drow["sachTashlumChodshi"] = sachTashlumChodshi;
            drow["chodesh"] = chodesh;
            drow["shana"] = shana;
        }
        public void FillFields()
        {
            misTashlum = Convert.ToInt32(drow["misTashlum"]);
            misHascara = Convert.ToInt32(drow["misHascara"]);
            sachTashlumChodshi = Convert.ToInt32(drow["sachTashlumChodshi"]);
            chodesh=Convert.ToInt32(drow["chodesh"]);
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
