using System;
using System.Collections.Generic;

#nullable disable

namespace on.Models
{
    public partial class Nhaxuatban
    {
        public Nhaxuatban()
        {
            Saches = new HashSet<Sach>();
        }

        public string Manxb { get; set; }
        public string Tennxb { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
