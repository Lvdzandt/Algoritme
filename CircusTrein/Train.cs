using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Train
    {
        public List<TrainWagon> Wagons { get; set; }
        public List<Animal> Animals { get; set; }

        public Train(List<Animal> _Animals)
        {
            Animals = _Animals;
            Wagons = new List<TrainWagon>();
            TrainWagon firstwagon = new TrainWagon(1);
            Wagons.Add(firstwagon);
        }

        public void OrderWagon()
        {
            bool AddedAnimal = false;
            int i = 1;
            foreach (Animal a in Animals)
            {
                while (!AddedAnimal)
                {
                    foreach (TrainWagon w in Wagons)
                    {
                        if (w.CheckRemainingSize(a) && w.CheckMeatEater(a))
                        {
                            w.Animals.Add(a);
                            AddedAnimal = true;
                            break;
                        }

                    }
                    if (!AddedAnimal)
                    {
                        Wagons.Add(new TrainWagon(i + 1, a));
                        i += 1;
                        AddedAnimal = true;
                    }
                    
                }
                AddedAnimal = false;
                }
            }
        }
    }

