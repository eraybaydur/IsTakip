namespace IsTakip.Core.Classes.KullaniciClasses;

public class Kullanici
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int? MusteriId { get; set; }
    public string KullaniciKodu { get; set; }
    public string KullaniciSifre { get; set; }
    public bool MailBildirim { get; set; }
    public string? RolTanim { get; set; }

    public bool Aktif { get; set; } = true;
    public bool Silindi { get; set; }

    

}