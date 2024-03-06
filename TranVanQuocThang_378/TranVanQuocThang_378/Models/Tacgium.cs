using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPISach.Models
{
    public partial class Tacgium
    {
        public Tacgium()
        {
            ChitietSachTacgia = new HashSet<ChitietSachTacgium>();
        }

        public string Matg { get; set; }
        public string Tentg { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }

        public virtual ICollection<ChitietSachTacgium> ChitietSachTacgia { get; set; }
    }
}
