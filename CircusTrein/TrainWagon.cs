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
        public List<Animal> Animals = new List<Animal>();

        public TrainWagon(int _id)
        {
            ID = _id;
        }

        public TrainWagon(int _id, Animal _animal)
        {
            ID = _id;
            Animals = new List<Animal>();
            Animals.Add(_animal);
            int AnimalSize = (int)_animal.Size;
            CurrSize = AnimalSize;
        }

        public bool CheckRemainingSize(Animal animal)
        {
            int animalsize = (int)animal.Size;
            if (CurrSize  + animalsize <= MaxSize)
            {
                CurrSize += animalsize;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckMeatEater(Animal animal)
        {
            int ASize = (int)animal.Size;
            foreach (Animal a in Animals)
            {
                int BSize = (int)a.Size;
                if (a.MeatEater && animal.MeatEater)
                {
                    return false;
                }
                if (!a.MeatEater && animal.MeatEater && ASize < BSize)
                {
                    return true;
                }
                else if (a.MeatEater && !animal.MeatEater && ASize > BSize)
                {
                    return true;
                }
            }
            return true;
        }

    }
}
