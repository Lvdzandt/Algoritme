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


        public enum AnimalSize
        {
            small =1,
            medium =3,
            big = 5
        }
    }
}
