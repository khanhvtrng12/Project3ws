using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class bus
    {
        public DataTable ReadAll()
        {
            test ts1 = new test();
            return ts1.Load();
        }
        public static bool Create(holidays hl1)
        {
            test ts1 = new test();
            return ts1.InsertData(hl1);
        }
        public static bool Update(holidays hl1)
        {
            test ts1 = new test();
            return ts1.EdittData(hl1);
        }
        public static bool Delete(string id)
        {
            test ts1 = new test();
            return ts1.DeleteData(id);
        }
        public DataTable FindOne(holidays hl1)
        {
            test ts1 = new test();
            return ts1.SearchData(hl1);
        }
    }
}