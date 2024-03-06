using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH52007101.Models {
    class CHocvien {
        public string Mshv { get; set; }
        public string Tenhv { get; set; }
        public string Ngaysinh { get; set; }
        public string Phai { get; set; }
        public string Malop { get; set; }
        public string Tenlop { get; set; }

        public static CHocvien chuyendoi(Lylich x) {
            if (x == null) return null;
            qlhvContext db = new qlhvContext();
            Lop lop = db.Lops.Find(x.Malop);
            return new CHocvien {
                Mshv = x.Mshv,
                Tenhv = x.Tenhv,
                Ngaysinh = x.Ngaysinh.Value.ToShortDateString(),
                Phai = (x.Phai == true ? "Nam" : "Nữ"),
                Malop = x.Malop,
                Tenlop = lop.Tenlop
            };
        }

        public static Lylich chuyendoi(CHocvien x) {
            if (x == null) return null;
            return new Lylich {
                Mshv = x.Mshv,
                Tenhv = x.Tenhv,
                Ngaysinh = DateTime.Parse(x.Ngaysinh),
                Phai = bool.Parse(x.Phai),
                Malop = x.Malop
            };
        }

        public static CHocvien chuyendoiSua(Lylich x) {
            if (x == null) return null;
            qlhvContext db = new qlhvContext();
            Lop lop = db.Lops.Find(x.Malop);
            return new CHocvien {
                Mshv = x.Mshv,
                Tenhv = x.Tenhv,
                Ngaysinh = x.Ngaysinh.Value.ToShortDateString(),
                Phai = x.Phai.ToString(),
                Malop = x.Malop
            };
        }
    }
}
