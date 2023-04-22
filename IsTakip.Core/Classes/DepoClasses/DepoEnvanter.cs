using IsTakip.Core.Classes.BaseClasses;
using IsTakip.Core.Classes.MusteriClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.DepoClasses
{
    public class DepoEnvanter
    {
        public int Id { get; set; }
        public int DepoId { get; set; }
        public int DepoRafId { get; set; }
        public int MalzemeTipId { get; set; }
        public int KalinlikId { get; set; }
        public decimal En { get; set; }
        public decimal Boy { get; set; }
        public int Adet { get; set; }
        public decimal Agirlik { get; set; }
        public string? Aciklama { get; set; }

        public Depo? Depo { get; set; }
        public DepoRaf? DepoRaf { get; set; }
        public MalzemeTip? MalzemeTip { get; set; } 
        public Kalinlik? Kalinlik { get; set; } 
    }
}
