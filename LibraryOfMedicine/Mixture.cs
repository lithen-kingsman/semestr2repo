using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfMedicine
{
    public class Mixture : Medicine
    {
        public int BottleVolume { get; set; }

        public Mixture(int articul, string name, string producer, int price, int remains, dispensation dispensation, int bottleVolume) :
           base(articul, name, producer, price, remains, dispensation)
        {
            BottleVolume = bottleVolume;
        }
        public override string GetInfo() =>
           base.GetInfo() + $"Объем бутылки: {BottleVolume} мл ";
    }
}
