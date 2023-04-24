namespace IsTakip.Core.Classes.MusteriClasses;

public class MusteriKisitlama
{
    public int Id { get; set; }
    public string IslemAciklama { get; set; }
    public bool Kisitlama { get; set; } = false;
    public int MusteriId { get; set; }
    
    public Musteri Musteri { get; set; }
}