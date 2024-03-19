using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThanhTuan_206.Models {
    class CLoaIPhong {
        public string Maloai { get; set; }
        public string Songuoi { get; set; }
        public string Dongia { get; set; }

        public static Loaiphong chuyendoi(CLoaIPhong clp) {
            if (clp == null)
                return null;
            return new Loaiphong {
                Maloai = clp.Maloai,
                Songuoi = int.Parse(clp.Songuoi),
                Dongia = double.Parse(clp.Dongia)

            };
        }
        public static CLoaIPhong chuyendoi(Loaiphong lp) {
            if (lp == null)
                return null;
            return new CLoaIPhong {
                Maloai = lp.Maloai,
                Songuoi = lp.Songuoi.ToString(),
                Dongia = lp.Dongia.ToString(),
            };
        }
    }
}
