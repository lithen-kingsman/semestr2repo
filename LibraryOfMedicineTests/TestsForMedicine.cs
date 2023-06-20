using System.Reflection;
using System;
using LibraryOfMedicine;
using System.Xml.Linq;

namespace LibraryOfMedicineTests
{
    [TestFixture]
    public class MedicineTests
    {
        public static LibraryOfMedicine.Medicine medicine;

        [SetUp]
        public void Setup()
        {
            medicine = new Medicine(12345678, "Аэртал", "Производитель из России", 369, 5673, dispensation.withoutPrescription);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(medicine.Articul, Is.EqualTo(12345678));
            Assert.That(medicine.Name, Is.EqualTo("Аэртал"));
            Assert.That(medicine.Dispensation, Is.EqualTo(dispensation.withoutPrescription));
            Assert.That(medicine.Producer, Is.EqualTo("Производитель из России"));
            Assert.That(medicine.Price, Is.EqualTo(369));
            Assert.That(medicine.RemainsOnStock, Is.EqualTo(5673));
        }
        [Test]
        public void GetInfo_Medicine_ValuesString()
        {
            string expectedInfo = $"Артикул: 12345678";
            expectedInfo += $"Название: Аэртал";
            expectedInfo += $"Отпуск: без рецепта";
            expectedInfo += $"Производитель: Производитель из России";
            expectedInfo += $"Цена: 369";
            expectedInfo += $"Количество на складе: 5673";

            Assert.That(medicine.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}