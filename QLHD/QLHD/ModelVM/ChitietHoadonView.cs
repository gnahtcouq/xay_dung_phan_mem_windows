using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Models {
    class ChitietHoadonView {
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }
        public double ThanhTien {
            get { return Dongia.Value * Soluong.Value; }
        }
        public static List<ChitietHoadonView> getChitietHoadons(Hoadon x) {
            List<ChitietHoadonView> ds = x.Chitiethoadons.Select(t => new ChitietHoadonView {
                Mahang = t.Mahang,
                Tenhang = t.MahangNavigation.Tenhang,
                Dvt = t.MahangNavigation.Dvt,
                Dongia = t.Dongia,
                Soluong = t.Soluong
            }).ToList();

            return ds;
        }
    }
}
