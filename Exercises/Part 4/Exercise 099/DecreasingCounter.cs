using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_99
{   
    //Valmis
    public class DecreasingCounter
    {
        private int value;

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            this.value = value - 2;
            
            if (value < 0)
            {
                this.value = 0;
            }
        }

        public void Reset()
        {
            this.value = 0;
        }
    }
}

