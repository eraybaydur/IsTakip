using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.MusteriClasses;

public class MusteriSinif : BaseObject
{
    public string Tanim { get; set; }
    public string Aciklama { get; set; }

    public ICollection<Musteri> Musteriler { get; set; }
}