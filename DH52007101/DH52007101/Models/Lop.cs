﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DH52007101.Models {
    public partial class Lop {
        public Lop() {
            Lyliches = new HashSet<Lylich>();
        }

        public string Malop { get; set; }
        public string Tenlop { get; set; }

        public virtual ICollection<Lylich> Lyliches { get; set; }
    }
}
