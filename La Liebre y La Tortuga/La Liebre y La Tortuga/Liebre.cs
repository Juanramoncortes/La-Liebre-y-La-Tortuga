using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Liebre_y_La_Tortuga
{
    class Liebre:Jugador
    {
        public Liebre(string tipo)
            :base (tipo)
        {

        }
        public void avanzar()
        {
            Dado();
            avanzar(Parametros(dado[n]));
                n++;
        }

        public int Parametros(int dado)
        {
            int num = 0;
            if (dado == 1 || dado == 2)
            {
                num = 0;
            }
            else
         if (dado == 4 || dado == 5)
            {
                num = (9);
            }
            else
         if (dado == 6)
            {
                num = (-12);
            }
            else
         if (dado == 6 || dado == 7 || dado == 8)
            {
                num = (1);
            }
            else
         if (dado == 9 || dado == 10)
            {
                num = (-1);
            }

            return num;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
