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
            foreach (Animal a in Animals)
            {
                foreach (TrainWagon w in Wagons)
                {
                    if (w.CheckRemainingSize(a) && w.CheckMeatEater(a))
                    {
                        w.Animals.Add(a);
                    }
                    else if(!w.CheckRemainingSize(a))
                    {
                        //Wagons.Add(new TrainWagon(w.ID+1,a));
                    }
                }
            }
        }
    }
}
