using on.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on.ModelVM
{
    class CSach
    {
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public string Theloai { get; set; }
        public string Namxb { get; set; }

        public static Sach chuyendoi(CSach cs)
        {
            if (cs == null)
                return null;
            return new Sach
            {
                Masach = cs.Masach,
                Tensach = cs.Tensach,
                Theloai = cs.Theloai,
                Namxb = cs.Namxb,
                Manxb = "nxb001"
            };
        }
        public static CSach chuyendoi(Sach x)
        {
            if (x == null)
                return null;
            return new CSach
            {
                Masach = x.Masach,
                Tensach = x.Tensach,
                Theloai = x.Theloai,
                Namxb = x.Namxb
            };
        }
    }
}
