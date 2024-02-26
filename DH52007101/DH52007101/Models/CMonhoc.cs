using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52007101.Models {
    class CMonhoc {
        public string Msmh { get; set; }
        public string Tenmh { get; set; }
        public int? Sotiet { get; set; }

        public static Monhoc chuyendoi(CMonhoc x) {
            if (x == null) return null;
            return new Monhoc {
                Msmh = x.Msmh,
                Tenmh = x.Tenmh,
                Sotiet = x.Sotiet
            };
        }

        public static CMonhoc chuyendoi(Monhoc x) {
            if (x == null) return null;
            return new CMonhoc {
                Msmh = x.Msmh,
                Tenmh = x.Tenmh,
                Sotiet = x.Sotiet
            };
        }

        public static CMonhoc saochep(CMonhoc x) {
            if (x == null) return null;
            return new CMonhoc {
                Msmh = x.Msmh,
                Tenmh = x.Tenmh,
                Sotiet = x.Sotiet
            };
        }
    }
}
