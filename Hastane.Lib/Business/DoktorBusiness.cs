using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Business
{
    public class DoktorBusiness : IAtama<Doktor, Hemsire>
    {
        public void AtamaYap(Doktor nereye, Hemsire neyi)
        {
            if(neyi.AtandiMi)
            throw new Exception("Bu hemsire daha önce atanmıştır..");
            if (nereye.servis != neyi.servis)
                throw new Exception("doktor ve hemşire aynı serviste olmalı");
            neyi.AtandiMi = true;
            nereye.Hemsireler.Add(neyi);

        }

        public void Cıkart(Doktor nereden, Hemsire neyi)
        {
            neyi.AtandiMi = false;
            nereden.Hemsireler.Remove(neyi);
        }
    }
}
