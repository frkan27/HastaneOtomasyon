using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Personel : Kisi, IMaasAlan

    {
        public decimal Maas { get; set; }
        public PersonelServis personelServis { get; set; }

        public enum PersonelServis
        {
            Temizlik,
            HastaBakımı,
            Maliye
        }


    }
}
