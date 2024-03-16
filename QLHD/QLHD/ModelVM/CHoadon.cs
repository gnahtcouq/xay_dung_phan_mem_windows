using QLHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.ModelVM {
    class CHoadon {
        public string Sohd { get; set; }
        public DateTime? Ngaylaphd { get; set; }
        public string Tenkh { get; set; }
        public double Thanhtien { get; set; }
        public static CHoadon chuyendoi(Hoadon x) {
            if (x == null) return null;
            double tt = 0;

            hoadonContext db = new hoadonContext();
            Hoadon a = db.Hoadons.Find(x.Sohd);

            if (a != null) {
                tt = db.Chitiethoadons.Where(t => t.Sohd == x.Sohd).Sum(k => k.Soluong.Value * k.Dongia.Value);
            }

            return new CHoadon {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Thanhtien = tt
            };
        }
    }
}
