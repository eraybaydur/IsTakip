using IsTakip.Core.Classes.BaseClasses;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Classes.MusteriClasses
{
    public class Ajanda : BaseObject
    {
        public int MusteriId { get; set; }
        public string Aciklama { get; set; }
        public DateTime NotTarihi { get; set; }
        public virtual Musteri? Musteri { get; set; }

    }
}
