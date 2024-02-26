using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHD.Models;

namespace QLHD.ModelVM {
    internal class HanghoaVM {
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public string Dongia { get; set; }

        public static Hanghoa chuyendoi(HanghoaVM x) {
            if (x == null) return null;
            return new Hanghoa {
                Mahang = x.Mahang,
                Tenhang = x.Tenhang,
                Dvt = x.Dvt,
                Dongia = double.Parse(x.Dongia)
            };
        }
    }
}
