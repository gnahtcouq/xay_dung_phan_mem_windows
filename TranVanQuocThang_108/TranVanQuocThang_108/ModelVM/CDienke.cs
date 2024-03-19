using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waDienke_Giuaky.Models;

namespace TranVanQuocThang_108.ModelVM {
    internal class CDienke {
        public string Madk { get; set; }
        public string Ngaydk { get; set; }
        public string Makh { get; set; }
        public string Tenkh { get; set; }
        public static CDienke chuyendoi(Dienke x) {
            csdl_dienkeContext db = new csdl_dienkeContext();
            Khachhang kh = db.Khachhangs.Find(x.Makh);
            if (x == null) return null;
            return new CDienke {
                Madk = x.Madk,
                Ngaydk = x.Ngaydk.Value.ToShortDateString(),
                Makh = x.Makh,
                Tenkh = kh.Tenkh,
            };
        }
        public static Dienke chuyendoi(CDienke x) {

            if (x == null) return null;
            return new Dienke {
                Madk = x.Madk,
                Ngaydk = DateTime.Parse(x.Ngaydk),
                Makh = x.Makh,
            };
        }
    }
}
