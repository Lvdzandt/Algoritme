using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public class Train
    {
        public List<TrainWagon> Wagons { get; set; }
        public List<Animal> Animals { get; set; }
        public static Random RNGenum = new Random();
        public static Random RNGmeat = new Random();

        public Train()
        {
            Animals = new List<Animal>();
            Wagons = new List<TrainWagon>();
            TrainWagon firstwagon = new TrainWagon(1);
            Wagons.Add(firstwagon);
        }

        public void AddWagons(ListBox lb)
        {
            foreach (var item in Wagons)
            {
                lb.Items.Add(item.ID);
            }
        }

        public void AddWagonAnimal(ListBox lb, int id)
        {
            foreach (var item in Wagons)
            {
                if (item.ID == id)
                {
                    foreach (Animal animal in item.Animals)
                    {
                        lb.Items.Add(animal.ID);
                    }
                }
            }
        }

        public void AllAnimals(ListBox lb)
        {
            foreach (Animal animal in Animals)
            {
                lb.Items.Add(animal.ID);
            }
        }

        public void AnimalInfo(ListBox lb, Label AnimalID, Label AnimalSize, Label AnimalMeatEater, int id)
        {
            foreach (var item in Animals)
            {
                if (item.ID == id)
                {
                    AnimalID.Text = Convert.ToString(item.ID);
                    AnimalSize.Text = Convert.ToString(item.Size);
                    AnimalMeatEater.Text = Convert.ToString(item.MeatEater);
                }
            }
        }

        public void MakeAnimals()
        {
            
            for (int i = 1; i < 51; i++)
            {
                Animals.Add(new Animal(i, RNGenum.Next(1, 4), RNGmeat.Next(1, 3)));
            }
        }

        public void OrderWagon()
        {
            Wagons.Clear();
            bool AddedAnimal = false;
            int i = 0;
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

