using IsTakip.Core.Classes.BaseClasses;
using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Enums;

namespace IsTakip.Core.Classes.UretimClasses
{
    public class UretimEmri : BaseObject
    {
        public int IsId { get; set; }
        public DateTime IsEmriTarihi { get; set; }
        public int? ToplamDurusSuresi { get; set; }
        public DateTime? UretimBaslamaTarihi { get; set; }
        public DateTime? UretimTamamlanmaTarihi { get; set; }
        public UretimDurum UretimDurum { get; set; }

        public Is? Is { get; set; }
        public UretimDurus? UretimDurus { get; set; }

    }
}
