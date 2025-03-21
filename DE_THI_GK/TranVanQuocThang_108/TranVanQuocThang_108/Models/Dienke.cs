﻿using System;
using System.Collections.Generic;

#nullable disable

namespace waDienke_Giuaky.Models {
    public partial class Dienke {
        public Dienke() {
            Sudungdiens = new HashSet<Sudungdien>();
        }

        public string Madk { get; set; }
        public DateTime? Ngaydk { get; set; }
        public string Makh { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }
        public virtual ICollection<Sudungdien> Sudungdiens { get; set; }
    }
}
