using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfMedicine
{
    public class Tablets : Medicine
    {
        public int QuantityInPack { get; set; }

        public Tablets(int articul, string name, string producer, int price, int remains, dispensation dispensation, int quantityInPack) :
            base(articul, name, producer, price, remains, dispensation)
        {
            QuantityInPack = quantityInPack;
        }
        public override string GetInfo() =>
            base.GetInfo() + $"Количество таблеток в упаковке: {QuantityInPack} шт. ";

    }
}
