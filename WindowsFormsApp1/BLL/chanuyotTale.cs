using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp1.BLL
{
   public class chanuyotTale:GeneralTable
    {
        public chanuyotTale():base("chanuyot","misChanut")
        {

        }
        public DataTable GetQuery()
        {
            return dal.GetQuery("SELECT chanuyot.status, chanuyot.*, chanuyot.godel, chanuyot.mechirHascaraChodshi, chanuyot.sugChanut, chanuyot.kayamChalonRaava, chanuyot.kayamMachsan, chanuyot.godelMachsan, chanuyot.koma, chanuyot.misAgaf, chanuyot.status, chanuyot.misPtachimLechanut, chanuyot.misPtachimLechanut FROM chanuyot WHERE(((chanuyot.status) = False));             ");
        }
    }
}
