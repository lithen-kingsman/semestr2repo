using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfMedicine
{
    public class Ointment : Medicine
    {
        public int TubeVolume { get; set; }

        public Ointment(int articul, string name, string producer, int price, int remains, dispensation dispensation, int tubeVolume) :
           base(articul, name, producer, price, remains, dispensation)
        {
            TubeVolume = tubeVolume;
        }
        public override string GetInfo() =>
           base.GetInfo() + $"Объем тубы: {TubeVolume} мг ";
    }
}
