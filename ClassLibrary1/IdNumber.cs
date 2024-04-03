using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class IdNumber
    {
        public int number;
        public IdNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Error");
            }

            this.number = number;
        }

        public override string ToString()
        {
            return number.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is IdNumber n)
            {
                return this.number == n.number;
            }
            return false;
        }
    }
}

