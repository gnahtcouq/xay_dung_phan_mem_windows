using System;
using System.Collections.Generic;

#nullable disable

namespace on.Models
{
    public partial class ChitietSachTacgium
    {

        public string Masach { get; set; }
        public string Matg { get; set; }

        public virtual Sach MasachNavigation { get; set; }
        public virtual Tacgium MatgNavigation { get; set; }
    }
}
