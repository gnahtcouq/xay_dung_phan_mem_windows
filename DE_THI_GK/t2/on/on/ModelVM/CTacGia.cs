using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using on.Models;

namespace on.ModelVM
{
    class CTacGia
    {
        public string Matg { get; set; }
        public string Tentg { get; set; }
        public string Ngaysinh { get; set; }
        public string Phai { get; set; }
        public static Tacgium chuyendoi(CTacGia tg)
        {
            if (tg == null)
                return null;
            return new Tacgium
            {
                Matg = tg.Matg,
                Tentg = tg.Tentg,
                Ngaysinh = DateTime.Parse(tg.Ngaysinh),
                Phai = (tg.Phai== "Nam") ? true : false
            };
        }
        public static CTacGia chuyendoi(Tacgium x)
        {
            if (x == null)
                return null;
            return new CTacGia
            {
                Matg = x.Matg,
                Tentg = x.Tentg,
                Ngaysinh = x.Ngaysinh.Value.ToShortDateString(),
                Phai = (x.Phai==true) ? "Nam" : "Nữ"
            };
        }
    }
}
