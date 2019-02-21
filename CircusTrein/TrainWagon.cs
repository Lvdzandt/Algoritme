using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class TrainWagon
    {
        private int MaxSize { get; set; } = 10;
        public int CurrSize { get; set; } = 0;

        public bool CheckRemainingSize(int size)
        {
            if (CurrSize + size >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
