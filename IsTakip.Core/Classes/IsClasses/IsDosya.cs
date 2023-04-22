using IsTakip.Core.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.IsClasses
{
    public class IsDosya
    {
        public int Id { get; set; }
        public int IsId { get; set; }
        public string DosyaAdi { get; set; }

        public Is Is { get; set; }
    }
}
