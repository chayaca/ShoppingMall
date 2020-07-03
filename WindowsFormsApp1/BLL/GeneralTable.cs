using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    public abstract  class GeneralTable
    {
        protected static Dal dal = new Dal();
        protected DataTable table;
        protected string key;
        protected string tableName;
        private int currentRow;

        public GeneralTable(string tableName, string key)
        {
            dal.AddTable(tableName);
            this.table = dal.GetTable(tableName);
            this.tableName = tableName;
            this.key = key;
            currentRow = 0;
        }

        public DataTable GetDataTable()
        {
            return this.table;
        }

        public string GetPrimaryKey()
        {
            return this.key;
        }

        public int GetNewKey()
        {
            DataTable dt = dal.GetQuery("select max(" + key + ") from " + table.TableName);
            return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public bool IsEmpty()
        {
            if (table.Rows.Count == 0)
                return true;
            return false;
        }

        public DataRow Find(string fieldName, object value)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[fieldName].Equals(value))
                    return row;
            }
            return null;
        }


        public DataRow Find(object value)
        {
            return Find(this.key, value);
        }

        public DataTable FindAll(string fieldName, object value)
        {
            DataTable dtTemp = dal.GetQuery("select * from " + this.table.TableName + " where " + fieldName + " = '" + value.ToString() +"'");
            return dtTemp;
        }

        public void Save()
        {
            try
            {
                dal.Update(table.TableName );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
