using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class esek
    {
        asakimTable myT = new asakimTable();
        private int misEsek;

        public int MisEsek
        {
            get { return misEsek; }
            set { misEsek = value; }
        }
        private string shemEsek;

        public string ShemEsek
        {
            get { return shemEsek; }
            set {if (value.Length < 2)
                    throw new Exception("שם עסק לא יכול להיות פחות מ2 אותיות");
                    shemEsek = value; }
        }
        private string shemIshKesher;

        public string ShemIshKesher
        {
            get { return shemIshKesher; }
            set { shemIshKesher = value; }
        }
        private string nayadIshKesher;

        public string NayadIshKesher
        {
            get { return nayadIshKesher; }
            set { nayadIshKesher = value; }
        }
        private string kidomet;

        public string Kidomet
        {
            get { return kidomet; }
            set { kidomet = value; }
        }
        private string mailIshKesher;

        public string MailIshKesher
        {
            get { return mailIshKesher; }
            set { mailIshKesher = value; }
        }
        private string ctovetMisrad;

        public string CtovetMisrad
        {
            get { return ctovetMisrad; }
            set { ctovetMisrad = value; }
        }
        private int KodIr;

        public int kodIr
        {
            get { return KodIr; }
            set { KodIr = value; }
        }
        private string mailEsek;

        public string MailEsek
        {
            get { return mailEsek; }
            set { mailEsek = value; }
        }
        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public esek()
        {

        }
        public esek(int misEsek)
        {
          drow=  myT.Find(misEsek);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misEsek"] = misEsek;
            drow["shemEsek"] = shemEsek;
            drow["shemIshKesher"] = shemIshKesher;
            drow["nayadIshKesher"] = nayadIshKesher;
            drow["kidomet"] = kidomet;
            drow["mailIshKesher"] = mailIshKesher;
            drow["ctovetMisrad"] = ctovetMisrad;
            drow["KodIr"] = KodIr;
            drow["MailEsek"] = MailEsek;
        }
       public void FillFields()
        {
            misEsek =Convert.ToInt32 (drow["misEsek"]);
            shemEsek = drow["shemEsek"].ToString();
            shemIshKesher = drow["shemIshKesher"].ToString();
            nayadIshKesher = drow["nayadIshKesher"].ToString();
            kidomet = drow["kidomet"].ToString();
            mailIshKesher = drow["mailIshKesher"].ToString();
            ctovetMisrad = drow["ctovetMisrad"].ToString();
            KodIr = Convert.ToInt32(drow["KodIr"]);
            MailEsek = drow["MailEsek"].ToString();
            DataTable 
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
