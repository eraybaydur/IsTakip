using IsTakip.Core.Classes.BaseClasses;
using IsTakip.Core.Classes.IsClasses;

namespace IsTakip.Core.Classes.DepoClasses
{
    public class Kalinlik
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public DepoEnvanter? DepoEnvanter { get; set; }
        public Is? Is { get; set; }
    }
}
