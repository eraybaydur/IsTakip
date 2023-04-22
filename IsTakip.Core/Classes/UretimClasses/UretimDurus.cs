using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.UretimClasses
{
    public class UretimDurus : BaseObject
    {
        public int UretimEmriId { get; set; }
        public int DurusSuresi { get; set; } //sn
        public int DurusTipId { get; set; }

        public UretimEmri? UretimEmri { get; set; }
        public DurusTip? DurusTip { get; set; }
    }
}
