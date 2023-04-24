namespace IsTakip.Core.DTOs.KullaniciDTOs
{
    public class KullaniciCreateDto : BaseDto
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciKodu { get; set; }
        public string KullaniciSifre { get; set; }
        public bool MailBildirim { get; set; }
        public string? RolTanim { get; set; }

    }
}
