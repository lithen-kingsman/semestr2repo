using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfMedicine
{
    public class Medicine
    {
        public readonly int Articul;
        public string Name;
        public string Producer;
        public int Price;
        public int RemainsOnStock;
        public dispensation Dispensation;

        public Medicine(int articul, string name, string producer, int price, int remains, dispensation dispensation)
        {
            Articul = articul;
            Name = name;
            Producer = producer;
            Price = price;
            RemainsOnStock = remains;
            Dispensation = dispensation;
        }

        public virtual string GetInfo()
        {
            string Dis = $"";

            if (Dispensation == dispensation.withPrescription)
                Dis = "с рецептом";
            else if (Dispensation == dispensation.withoutPrescription)
                Dis = "без рецепта";

            return $"Артикул: {Articul} " + $"Название: {Name} " + $"Отпуск: {Dis} " + $"Производитель: {Producer} " +
            $"Цена: {Price} " + $"Количество на складе: {RemainsOnStock} ";

        }

        public class Tablets : Medicine
        {
            public int QuantityInPack { get; set; }

            public Tablets (int articul, string name, string producer, int price, int remains, dispensation dispensation, int quantityInPack):
                base (articul, name, producer, price, remains, dispensation)
            {
                QuantityInPack = quantityInPack;
            }
            public override string GetInfo() =>
                base.GetInfo() + $"Количество таблеток в упаковке: {QuantityInPack} шт. ";

        }

        public class Mixture : Medicine
        {
            public int BottleVolume { get; set; }

            public Mixture (int articul, string name, string producer, int price, int remains, dispensation dispensation, int bottleVolume) :
               base(articul, name, producer, price, remains, dispensation)
            {
                BottleVolume = bottleVolume;
            }
            public override string GetInfo() =>
               base.GetInfo() + $"Объем бутылки: {BottleVolume} мл ";
        }

        public class Ointment : Medicine
        {
            public int TubeVolume { get; set; }

            public Ointment (int articul, string name, string producer, int price, int remains, dispensation dispensation, int tubeVolume) :
               base(articul, name, producer, price, remains, dispensation)
            {
                TubeVolume = tubeVolume;
            }
            public override string GetInfo() =>
               base.GetInfo() + $"Объем тубы: {TubeVolume} мг ";
        }



    }

}