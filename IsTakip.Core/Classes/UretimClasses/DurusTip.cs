using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.UretimClasses
{
    public class DurusTip
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public virtual UretimDurus? UretimDurus { get; set; }
    }
}
