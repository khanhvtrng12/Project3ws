using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class holidays
    {
        public int ID { get; set; }
        public string Holiday_date { get; set; }
        public string Holiday_name_group { get; set; }
        public string Holiday_name_en { get; set; }
        public string Holiday_name_vi { get; set; }
        public string Remark { get; set; }
        public string Updated_by { get; set; }
        public DateTime Updated_date { get; set; }
    }

}
