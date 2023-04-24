namespace IsTakip.Core.Classes.BaseClasses;

public abstract class BaseObject
{
    public int Id { get; set; }
    public int GuncelleyenKullaniciId { get; set; }
    public int? OlusturanKullaniciId { get; set; }
    public DateTime OlusturmaTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public bool Aktif { get; set; }
    public bool Silindi { get; set; }

}