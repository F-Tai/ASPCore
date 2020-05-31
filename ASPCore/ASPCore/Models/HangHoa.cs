using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class HangHoa
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public string Hinh { get; set; }
        public double Dongia { get; set; }
        public int Giamgia { get; set; }
        public double Giaban => Dongia * (100 - Giamgia) / 100.0;

    }
}
