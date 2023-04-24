﻿using IsTakip.Core.Classes.IsClasses;
using IsTakip.Core.Classes.MusteriClasses;

namespace IsTakip.Core.DTOs
{
    public class MusteriDto : BaseDto
    {
        public string Tanim { get; set; }
        public int MusteriSinifId { get; set; }
        public int MusteriTemsilcisiId { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarasi { get; set; }
        public string Aciklama { get; set; }

        public MusteriSinif? MusteriSinif { get; set; }
        public MusteriKisitlama? MusteriKisitlama { get; set; }
        public MusteriTemsilcisi? MusteriTemsilcisi { get; set; }
        public Ajanda? Ajanda { get; set; }
        public Is? Is { get; set; }

    }
}
