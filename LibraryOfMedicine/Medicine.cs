using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfMedicine
{
    public class Medicine : IComparable<Medicine>
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

        public int CompareTo(Medicine other)
        {
            if (Name != other.Name)
                return Name.CompareTo(other.Name);
            return Price.CompareTo(other.Price);
        }
        public class ArticulComparer : IComparer<Medicine>
        {
            public int Compare(Medicine x, Medicine y)
            {
                return x.Articul.CompareTo(y.Articul);
            }
        }

        public class Pharmacy : IEnumerable<Medicine> 
        {
            public string PharmacyName { get; set; }
            public string Address { get; set; }
            public IReadOnlyList<Medicine> AvailableMedicines => medicines;

            private List<Medicine> medicines;
            public Pharmacy(string pharmacyName, string address, IEnumerable<Medicine> medicines)
            {
                PharmacyName = pharmacyName;
                Address = address;
                medicines = new List<Medicine>(medicines.Distinct());
            }
            public IEnumerator<Medicine> GetEnumerator() => medicines.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
