using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Animal
    {
        public int ID { get; set; }
        public AnimalSize Size { get; set; }
        public bool MeatEater { get; set; }

        public Animal(int _id, int _size, int _meateater)
        {
            ID = _id;
            if (_meateater == 1)
            {
                MeatEater = true;
            }
            else if(_meateater == 2)
            {
                MeatEater = false;
            }
            if (_size == 1)
            {
                Size = AnimalSize.small;
            }
            else if (_size == 2)
            {
                Size = AnimalSize.medium;
            }
            else if (_size == 3)
            {
                Size = AnimalSize.big;
            }
        }


        public enum AnimalSize
        {
            small =1,
            medium =3,
            big = 5
        }
    }
}
