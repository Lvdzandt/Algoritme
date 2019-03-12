using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class TrainWagon
    {
        public int ID { get; set; }
        private int MaxSize { get; set; } = 10;
        public int CurrSize { get; set; } = 0;
        public List<Animal> Animals { get; set; }

        public bool CheckRemainingSize(Animal animal)
        {
            if (CurrSize  + (int)animal.Size >= 10)
            {
                CurrSize += (int)animal.Size;
                Animals.Add(animal);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
