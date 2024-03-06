using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPISach.Models {
    public partial class Sach {
        public Sach() {
            ChitietSachTacgia = new HashSet<ChitietSachTacgium>();
        }

        public string Masach { get; set; }
        public string Tensach { get; set; }
        public string Theloai { get; set; }
        public string Namxb { get; set; }
        public string Manxb { get; set; }

        public virtual Nhaxuatban ManxbNavigation { get; set; }
        public virtual ICollection<ChitietSachTacgium> ChitietSachTacgia { get; set; }
    }
}
