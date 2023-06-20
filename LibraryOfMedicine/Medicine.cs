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

        public string GetInfo()
        {
            string Dis = $"";

            if (Dispensation == dispensation.withPrescription)
                Dis = "с рецептом";
            else if (Dispensation == dispensation.withoutPrescription)
                Dis = "без рецепта";

            return $"Артикул: {Articul}" + $"Название: {Name}" + $"Отпуск: {Dis}" + $"Производитель: {Producer}" +
            $"Цена: {Price}" + $"Количество на складе: {RemainsOnStock}";

        }

    }

}