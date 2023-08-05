using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Test
{
    internal class test
    {
        
        public static void main(string[] args)
        {
            DAL.DLA_Holidays db = new DLA_Holidays();

            if (db._OpenConn())
            {
                Console.WriteLine("Kết nối thành công !");
            }
            else
            {
                Console.WriteLine("Kết nối thất bại");
            }
            Console.ReadLine();
        }
    }
}
