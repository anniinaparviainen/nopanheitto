using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopanheitto
{
    class Dice
    {
        public int Value { get; set; }

        public int Luku1;
        public int Luku2;
        

        public Dice()
        {

            Luku1 = 1;
            Luku2 = 1;
          

        }
        public void Roll(Random rng)
        {
            Luku1 = rng.Next(1, 7);
            Luku2 = rng.Next(1, 7);

            
        }
    }
}
