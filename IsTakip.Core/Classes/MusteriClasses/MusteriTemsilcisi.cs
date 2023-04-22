using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.MusteriClasses;

public class MusteriTemsilcisi : BaseObject
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Email { get; set; }
    public string TelefonNumarasi { get; set; }

    public ICollection<Musteri> Musteriler { get; set; } = new List<Musteri>();
}