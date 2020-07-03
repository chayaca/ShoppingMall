using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class hascara
    {
        hascarotTable myT = new hascarotTable();
        private int misHascara;

        public int MisHascara
        {
            get { return misHascara; }
            set { misHascara = value; }
        }
        private DateTime taarichBakashatHascara;

        public DateTime TaarichBakashatHascara
        {
            get { return taarichBakashatHascara; }
            set { taarichBakashatHascara = value; }
        }
        private int misChanut;

        public int MisChanut
        {
            get { return misChanut; }
            set { misChanut = value; }
        }
        private int misEsek;

        public int MisEsek
        {
            get { return misEsek; }
            set { misEsek = value; }
        }
        private DateTime taarichKnisa;

        public DateTime TaarichKnisa
        {
            get { return taarichKnisa; }
            set { taarichKnisa = value; }
        }
        private int meshechZmanHachoze;

        public int MeshechZmanHachoze
        {
            get { return meshechZmanHachoze; }
            set { meshechZmanHachoze = value; }
        }
        private bool optzyaLehaaracha;

        public bool OptzyaLehaaracha
        {
            get { return optzyaLehaaracha; }
            set { optzyaLehaaracha = value; }
        }
        private string ofenTashlum;

        public string OfenTashlum
        {
            get { return ofenTashlum; }
            set { ofenTashlum = value; }
        }
        private string misAshray;

        public string MisAshray
        {
            get { return misAshray; }
            set { misAshray = value; }
        }
        private DateTime tokef;

        public DateTime Tokef
        {
            get { return tokef; }
            set { tokef = value; }
        }
        private int cvv;

        public int Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }
        private string misAsmachta;

        public string MisAsmachta
        {
            get { return misAsmachta; }
            set { misAsmachta = value; }
        }
        private int misBank;

        public int MisBank
        {
            get { return misBank; }
            set { misBank = value; }
        }
        private int misSnif;

        public int MisSnif
        {
            get { return misSnif; }
            set { misSnif = value; }
        }
        private int misCheshbon;

        public int MisCheshbon
        {
            get { return misCheshbon; }
            set { misCheshbon = value; }
        }
        private bool sherutimMeyuchadim;

        public bool SherutimMeyuchadim
        { 

            get { return sherutimMeyuchadim; }
            set { sherutimMeyuchadim = value; }
        }
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


        private DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public hascara()
        {

        }
        public hascara(int misHascara)
        {
          drow=  myT.Find(misHascara);
            FillFields();
        }
        public void FillDrow()
        {
            drow["misHascara"] = misHascara;
            drow["taarichBakashatHascara"] = taarichBakashatHascara;
            drow["misChanut"] = misChanut;
            drow["misEsek"] = misEsek;
            drow["taarichKnisa"] = taarichKnisa;
            drow["meshechZmanHachoze"] = meshechZmanHachoze;
            drow["optzyaLehaaracha"] = optzyaLehaaracha;
            drow["ofenTashlum"] = ofenTashlum;
            drow["misAshray"] = misAshray;
            drow["tokef"] = tokef;
            drow["cvv"] = cvv;
            drow["misAsmachta"] = misAsmachta;
            drow["misBank"] = misBank;
            drow["misSnif"] = misSnif;
            drow["misCheshbon"] = misCheshbon;
            drow["sherutimMeyuchadim"] = sherutimMeyuchadim;
            drow["misSherut"] = misSherut;
            drow["shemSherut"] = shemSherut;
        }
        public void FillFields()
        {
            misHascara = Convert.ToInt32(drow["misHascara"]);
            taarichBakashatHascara = Convert.ToDateTime(drow["taarichBakashatHascara"]);
            misChanut = Convert.ToInt32(drow["misChanut"]);
            misEsek = Convert.ToInt32(drow["misEsek"]);
            taarichKnisa = Convert.ToDateTime(drow["taarichKnisa"]);
            meshechZmanHachoze = Convert.ToInt32(drow["meshechZmanHachoze"]);
            optzyaLehaaracha = Convert.ToBoolean(drow["optzyaLehaaracha"]);
            ofenTashlum = drow["ofenTashlum"].ToString();
            misAshray = drow["misAshray"].ToString();
            tokef = Convert.ToDateTime(drow["tokef"]);
            cvv = Convert.ToInt32(drow["cvv"]);
            misAsmachta = drow["misAsmachta"].ToString();
            misBank = Convert.ToInt32(drow["misBank"]);
            misSnif = Convert.ToInt32(drow["misSnif"]);
            misCheshbon = Convert.ToInt32(drow["misCheshbon"]);
            sherutimMeyuchadim = Convert.ToBoolean(drow["sherutimMeyuchadim"]);
            misSherut = Convert.ToInt32(drow["misSherut"]);
            shemSherut = drow["shemSherut"].ToString();

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
