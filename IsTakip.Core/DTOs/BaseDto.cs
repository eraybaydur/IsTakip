namespace IsTakip.Core.DTOs
{
    public abstract class BaseDto
    {
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
