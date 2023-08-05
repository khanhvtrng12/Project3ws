using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class test
    {
        public static string _table = "holidays";
        public static string _fiels = "Item,Machine,ProcessCode,Width,Height,Scrap,Update,UpdateDate";
        private DLA_Holidays db = new DLA_Holidays();
        public DataTable Load()
        {
            string sql = "SELECT * FROM " + _table;
            return db.ExecuteDataTable(sql);

        }
        public bool InsertData(holidays holidaysDTO)
        {
            var result = false;
            object[] values = { holidaysDTO.Holiday_date, holidaysDTO.Holiday_name_group, holidaysDTO.Holiday_name_en, holidaysDTO.Holiday_name_vi, holidaysDTO.Remark, holidaysDTO.Updated_by, holidaysDTO.Updated_date };
            string query = "INSERT INTO " + _table + " VALUES ";
            result = db.ExecuteNonQuery2(query, values) > 0;
            return result;
        }
        public bool EdittData(holidays holidaysDTO)
        {
            var result = false;
            object[] values = { holidaysDTO.ID, holidaysDTO.Holiday_date, holidaysDTO.Holiday_name_group, holidaysDTO.Holiday_name_en, holidaysDTO.Holiday_name_vi, holidaysDTO.Remark, holidaysDTO.Updated_by, holidaysDTO.Updated_date };
            string query = "UPDATE " + _table + " SET ";
            
            DataTable schemaTable = Load();
            result = db.ExecuteNonQuery3(query, values, schemaTable) > 0;
            return result;
        }
        public bool DeleteData(string id)
        {
            var result = false;
            DataTable schemaTable = Load();
            string query = "DELETE FROM " + _table + " WHERE " + schemaTable.Columns[0].ColumnName + "= '"+id +"'";
            result = db.ExecuteNonQuery3(query) >0;
            return result;
        }
    }
}
