using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Hemsire : Kisi, IMaasAlan
    {
        public decimal Maas { get; set; }
        public Servis servis { get; set; }
        public bool AtandiMi { get; set; }




        public enum Servis
        {
            KBB,
            Göz,
            Ortopedi,
            Dahiliye,
            Beyin
        }
    }
}
