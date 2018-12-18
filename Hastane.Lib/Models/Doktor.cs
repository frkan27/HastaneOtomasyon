using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hastane.Lib.Models.Hemsire;

namespace Hastane.Lib.Models
{
    public class Doktor : Kisi, IMaasAlan
    {
        public decimal Maas { get; set; }
        public Servis servis { get; set; }

        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();


    }
}
