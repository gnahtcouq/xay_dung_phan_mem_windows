using System;
using System.Collections.Generic;

#nullable disable

namespace LeThanhTuan_206.Models
{
    public partial class Phong
    {
        public Phong()
        {
            Chitietphieuthues = new HashSet<Chitietphieuthue>();
        }

        public string Maphong { get; set; }
        public int? Tinhtrang { get; set; }
        public string Maloai { get; set; }

        public virtual Loaiphong MaloaiNavigation { get; set; }
        public virtual ICollection<Chitietphieuthue> Chitietphieuthues { get; set; }
    }
}
