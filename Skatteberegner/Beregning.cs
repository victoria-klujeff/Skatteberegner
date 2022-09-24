using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            if (julegave + andenGave > 1200)
            {
                return andenGave + (julegave > 900 ? julegave: 0);
            }
            return 0;
        }
    }
}
