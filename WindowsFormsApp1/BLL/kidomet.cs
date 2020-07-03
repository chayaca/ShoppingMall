using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class kidomet
    {
        kidomotTable myT = new kidomotTable();
        private string kkidomet;

        public string Kkidomet
        {
            get { return kkidomet; }
            set { kkidomet = value; }
        }


    }
}
