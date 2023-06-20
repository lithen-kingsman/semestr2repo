using System.Reflection;
using System;
using LibraryOfMedicine;
using System.Xml.Linq;
using static LibraryOfMedicine.Medicine;

namespace LibraryOfMedicineTests
{
    [TestFixture]
    public class MedicineTests
    {
        public static LibraryOfMedicine.Medicine medicine;

        [SetUp]
        public void Setup()
        {
            medicine = new Medicine(12345678, "������", "������������� �� ������", 369, 5673, dispensation.withoutPrescription);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(medicine.Articul, Is.EqualTo(12345678));
            Assert.That(medicine.Name, Is.EqualTo("������"));
            Assert.That(medicine.Dispensation, Is.EqualTo(dispensation.withoutPrescription));
            Assert.That(medicine.Producer, Is.EqualTo("������������� �� ������"));
            Assert.That(medicine.Price, Is.EqualTo(369));
            Assert.That(medicine.RemainsOnStock, Is.EqualTo(5673));
        }
        [Test]
        public void GetInfo_Medicine_ValuesString()
        {
            string expectedInfo = $"�������: 12345678 ";
            expectedInfo += $"��������: ������ ";
            expectedInfo += $"������: ��� ������� ";
            expectedInfo += $"�������������: ������������� �� ������ ";
            expectedInfo += $"����: 369 ";
            expectedInfo += $"���������� �� ������: 5673 ";

            Assert.That(medicine.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
    [TestFixture]
    public class TabletsTests
    {
        public static Tablets tablets;

        [SetUp]
        public void Setup()
        {
            tablets = new Tablets(12345678, "������", "������������� �� ������", 369, 5673, dispensation.withoutPrescription, 30);
            tablets.QuantityInPack = 30;
        }

        [Test]
        public void TabletsConstructorTest()

        {
            Assert.That(tablets.QuantityInPack, Is.EqualTo(30));
        }

        [Test]
        public void TabletsGetInfoTest()
        {
            string expectedInfo = $"�������: 12345678 ";
            expectedInfo += $"��������: ������ ";
            expectedInfo += $"������: ��� ������� ";
            expectedInfo += $"�������������: ������������� �� ������ ";
            expectedInfo += $"����: 369 ";
            expectedInfo += $"���������� �� ������: 5673 ";
            expectedInfo += $"���������� �������� � ��������: 30 ��. ";

            Assert.That(tablets.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }

    [TestFixture]
    public class MixtureTests
    {
        public static Mixture mixture;

        [SetUp]
        public void Setup()
        {
            mixture = new Mixture(12345678, "������", "������������� �� ������", 369, 5673, dispensation.withoutPrescription, 100);
            mixture.BottleVolume = 100;
        }

        [Test]
        public void MixtureConstructorTest()

        {
            Assert.That(mixture.BottleVolume, Is.EqualTo(100));
        }

        [Test]
        public void MixtureGetInfoTest()
        {
            string expectedInfo = $"�������: 12345678 ";
            expectedInfo += $"��������: ������ ";
            expectedInfo += $"������: ��� ������� ";
            expectedInfo += $"�������������: ������������� �� ������ ";
            expectedInfo += $"����: 369 ";
            expectedInfo += $"���������� �� ������: 5673 ";
            expectedInfo += $"����� �������: 100 �� ";

            Assert.That(mixture.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }

    [TestFixture]
    public class OintmentTests
    {
        public static Ointment ointment;

        [SetUp]
        public void Setup()
        {
            ointment = new Ointment(12345678, "������", "������������� �� ������", 369, 5673, dispensation.withoutPrescription, 400);
            ointment.TubeVolume = 400;
        }

        [Test]
        public void OintmentConstructorTest()

        {
            Assert.That(ointment.TubeVolume, Is.EqualTo(400));
        }

        [Test]
        public void OintmentGetInfoTest()
        {
            string expectedInfo = $"�������: 12345678 ";
            expectedInfo += $"��������: ������ ";
            expectedInfo += $"������: ��� ������� ";
            expectedInfo += $"�������������: ������������� �� ������ ";
            expectedInfo += $"����: 369 ";
            expectedInfo += $"���������� �� ������: 5673 ";
            expectedInfo += $"����� ����: 400 �� ";

            Assert.That(ointment.GetInfo(), Is.EqualTo(expectedInfo));
        }

    }
}


    