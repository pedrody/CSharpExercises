using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex028
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3;
        public static double MinimoAprovado = 60.0;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= MinimoAprovado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double DiferencaAprovacao()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return MinimoAprovado - NotaFinal();
            }

        }


    }
}
