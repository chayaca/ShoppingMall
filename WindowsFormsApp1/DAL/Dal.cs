using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace WindowsFormsApp1.DAL
{
  public   class Dal
    {
        DataSet ds;
        OleDbConnection con;

        public Dal()
        {
            ds = new DataSet();
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='"+ Application.StartupPath + @"\mall1.mdb'");			
			//MessageBox.Show( System.IO.File.Exists(Application.StartupPath + @"\vadhabayit.mdb").ToString() );

        }


        public void AddTable(string tableName) // הפעולה מקבלת שם טבלה ומוסיפה טבלה מהמסד נתונים
        {
            if (! ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adpter = new OleDbDataAdapter("select * from " + tableName, con );
                adpter.Fill(ds, tableName);
            }
        }

        public DataTable GetTable(string tableName) // הפעולה מקבלת שם טבלה ומחזירה את הטבלה הרצויה בשלמותה  
        {
            return ds.Tables[tableName];
        }

        public DataTable GetQuery(string SQLQuery) //   הפעולה מקבלת מחרוזת שאילתה ומחזירה טבלה שמכילה את רשומות השאילתה 
        {
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SQLQuery , con);
            DataTable Query = new DataTable();// תוצאות השאילתה
            Adapter.Fill(Query);//שליפה ממסד הנתונים ואחסון בDATASET 
            return Query;
        }

        public void Update(string tableName)//הפעולה מקבלת שם טבלה ומעדכנת את מסד הנתונים
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
            // הכנת פעולות העדכון
            OleDbCommandBuilder Builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = Builder.GetInsertCommand();// שאילתת הכנסה
            adapter.UpdateCommand = Builder.GetUpdateCommand();// שאילתת עדכון 
            adapter.DeleteCommand = Builder.GetDeleteCommand();// שאילתת מחיקה
            // עדכון מסד הנתונים
            adapter.Update(ds, tableName);
        }
        public int ExcuteQuery(string sqlQuery)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlQuery;
            con.Open();
            int x = command.ExecuteNonQuery();
            con.Close();
            return x;
        }
    }
}
