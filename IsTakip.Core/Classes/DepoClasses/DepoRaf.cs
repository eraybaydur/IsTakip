using IsTakip.Core.Classes.BaseClasses;

namespace IsTakip.Core.Classes.DepoClasses
{
    public class DepoRaf
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }

        public DepoEnvanter? DepoEnvanter { get; set; }
    }
}
