using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHarjoitus2021
{
    public class Laskin
    {
        public int Erotus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }
        public int Summa(int luku1, int luku2)
        {
            return luku1 + luku2;
        }
        public int JakoJaannos(int luku1, int luku2)
        {
            return luku1 % luku2;
        }
        public int Tulo(int luku1, int luku2)
        {
            return luku1 * luku2;
        }
        public int JakoLasku(int luku1, int luku2)
        {
            return luku1 / luku2;
        }
    }
}

    
