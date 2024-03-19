using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThanhTuan_206.Models {
    class CPhong {
        public string Maphong { get; set; }
        public string Tinhtrang { get; set; }

        public static Phong chuyendoi(CPhong cp) {
            if (cp == null)
                return null;
            return new Phong {
                Maphong = cp.Maphong,
                Tinhtrang = int.Parse(cp.Tinhtrang)

            };
        }
        public static CPhong chuyendoi(Phong p) {
            if (p == null)
                return null;
            return new CPhong {
                Maphong = p.Maphong,
                Tinhtrang = p.Tinhtrang.ToString()
            };
        }
    }
}
