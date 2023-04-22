using IsTakip.Core.Classes.BaseClasses;
using IsTakip.Core.Classes.DepoClasses;
using IsTakip.Core.Classes.MusteriClasses;
using IsTakip.Core.Classes.UretimClasses;
using IsTakip.Core.Enums;

namespace IsTakip.Core.Classes.IsClasses
{
    public class Is : BaseObject
    {
        public int MusteriId { get; set; }
        public bool Teklifli { get; set; }
        public string TeklifNo { get; set; }
        public decimal Fiyat { get; set; }
        public bool IsBitimindeBildir { get; set; }
        public DateTime Termin { get; set; }
        public IsOnceligi IsOnceligi { get; set; }
        public string MusteriSiparisNo { get; set; }
        public string? IsNotu { get; set; }
        public int MalzemeTipId { get; set; }
        public int KalinlikId { get; set; }
        public bool Iscilik { get; set; }
        public string? MalzemeNotu { get; set; }

        public Musteri? Musteri { get; set; }
        public MalzemeTip? MalzemeTip { get; set; }
        public Kalinlik? Kalinlik { get; set; }
        public IsDosya? IsDosya { get; set; }
        public UretimEmri? UretimEmri { get; set; }
    }
}
