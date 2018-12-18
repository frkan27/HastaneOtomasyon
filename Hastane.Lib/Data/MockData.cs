using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hastane.Lib.Models.Hemsire;

namespace Hastane.Lib.Data
{
    public class MockData
    {
        public Context Context { get; set; }

        public MockData()
        {
            Context = new Context();

            for (int i = 0; i < 60; i++)
            {
                Context.Hastalar.Add(new Hasta()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime()


                }); 
            }
            for (int i = 0; i < 10; i++)
            {
                Context.Doktorlar.Add(new Doktor()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Maas=FakeData.NumberData.GetNumber(4000,10000),
                    servis=FakeData.EnumData.GetElement<Servis>()



                });
            }

            for (int i = 0; i < 20; i++)
            {
                Context.Hemsireler.Add(new Hemsire()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    TCKN = FakeData.TextData.GetNumeric(11),
                    Telefon = "5" + FakeData.TextData.GetNumeric(9),
                    DogumTarihi = FakeData.DateTimeData.GetDatetime(),
                    Maas = FakeData.NumberData.GetNumber(2000, 5000),
                    servis = FakeData.EnumData.GetElement<Servis>()



                });
            }
        }
    }
}
