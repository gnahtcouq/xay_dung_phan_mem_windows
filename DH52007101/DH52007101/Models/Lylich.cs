﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DH52007101.Models {
    public partial class Lylich {
        public Lylich() {
            Diemthis = new HashSet<Diemthi>();
        }

        public string Mshv { get; set; }
        public string Tenhv { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }
        public string Malop { get; set; }

        public virtual Lop MalopNavigation { get; set; }
        public virtual ICollection<Diemthi> Diemthis { get; set; }
    }
}
