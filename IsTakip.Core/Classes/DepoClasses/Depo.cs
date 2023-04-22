using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.DepoClasses
{
    public class Depo : BaseObject
    {
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public string Yetkili { get; set; }
        public string YetkiliTelefon { get; set; }

        public DepoEnvanter? DepoEnvanter { get; set; }

    }
}
