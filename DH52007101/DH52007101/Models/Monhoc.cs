using System;
using System.Collections.Generic;

#nullable disable

namespace DH52007101.Models {
    public partial class Monhoc {
        public Monhoc() {
            Diemthis = new HashSet<Diemthi>();
        }

        public string Msmh { get; set; }
        public string Tenmh { get; set; }
        public int? Sotiet { get; set; }

        public virtual ICollection<Diemthi> Diemthis { get; set; }
    }
}
