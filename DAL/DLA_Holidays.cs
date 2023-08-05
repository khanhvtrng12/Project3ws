using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DLA_Holidays
    {
        protected SqlConnection _conn;
        string datasource = @".\SQLEXPRESS"; // Lưu ý: SQL mỗi máy khác nhau
        string database = "holidays_pj";
        string username = "sa"; // Vui lòng bật quyền sa lên
        string password = "sa";
        public bool _OpenConn()
        {
            try
            {
                _conn = DBAccess.GetDBConnection(datasource, database, username, password);
                _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void _CloseConn()
        {
            _conn.Close();
            _conn.Dispose();
        }

        public DataTable ExecuteDataTable(string Query)
        {
            DataTable dt = new DataTable();
            if (_OpenConn())
            {
                try
                {
                    SqlCommand SqlCmd = new SqlCommand(Query, _conn);
                    dt.Load(SqlCmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    return dt;
                }
            }
            _CloseConn();
            return dt;

        }

        public DataSet ExecuteDataSet(string query)
        {
            DataSet ds = new DataSet();
            if (_OpenConn())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, _conn);
                    da.Fill(ds, "result");
                }
                catch (Exception ex)
                {
                    return ds;
                }
            }
            _CloseConn();
            return ds;
        }
        public SqlDataReader ExecuteReader(string query)
        {
            if (_OpenConn())
            {
                try
                {
                    SqlDataReader reader;
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            _CloseConn();
            return null;
        }

        public int ExecuteNonQuery(string query)
        {
            var affected = 0;
            if (_OpenConn())
            {
                SqlTransaction trans = _conn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    affected = cmd.ExecuteNonQuery();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    affected = -2;
                }
            }

            _CloseConn();
            return affected;
        }
        public int ExecuteNonQuery2(string query, object[] values)
        {
            var affected = 0;
            if (_OpenConn())
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                string temp = "";
                for (int i = 0; i < values.Length; i++)
                {
                    temp += "@" + i + ",";
                    cmd.Parameters.AddWithValue("@" + i, values[i]);
                }
                query += "(" + temp.TrimEnd(',') + ")";
                cmd.CommandText = query;
                cmd.Connection = _conn;
                affected = cmd.ExecuteNonQuery();
            }
            _CloseConn();
            return affected;
        }
        public int ExecuteNonQuery3(string query, object[] values, DataTable schemaTable)
        {
            var affected = 0;
            if (_OpenConn())
            {
                StringBuilder queryBuilder = new StringBuilder();
                SqlCommand cmd = new SqlCommand(query, _conn);
                queryBuilder.Append(query);
                for (int i = 1; i < values.Length; i++)
                {
                    queryBuilder.Append("[");
                    queryBuilder.Append(schemaTable.Columns[i].ColumnName);
                    queryBuilder.Append("] = @");
                    queryBuilder.Append(i);
                    queryBuilder.Append(",");
                    cmd.Parameters.AddWithValue("@" + i, values[i]);
                }

                queryBuilder.Length--;

                queryBuilder.Append(" WHERE [");
                queryBuilder.Append(schemaTable.Columns[0].ColumnName);
                queryBuilder.Append("] = @primaryKeyValue");
                cmd.Parameters.AddWithValue("@primaryKeyValue", values[0]);

                cmd.CommandText = queryBuilder.ToString();
                cmd.Connection = _conn;
                affected = cmd.ExecuteNonQuery();
            }
            _CloseConn();
            return affected;
        }
        public int ExecuteNonQuery3(string query)
        {
            var affected = 0;
            if (_OpenConn())
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                affected = cmd.ExecuteNonQuery();
            }
            _CloseConn();
            return affected;
        }

    }
}
