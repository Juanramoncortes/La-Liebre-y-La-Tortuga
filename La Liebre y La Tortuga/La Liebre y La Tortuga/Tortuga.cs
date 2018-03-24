using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Liebre_y_La_Tortuga
{
    class Tortuga:Jugador
    {    
        public Tortuga(string nombre)
            :base(nombre)
        {
           
        }
        public void avanzar()
        {
            Dado();
            avanzar(Parametros(dado[n]));
            
        }
        public int Parametros(int dado)
        {
            int num = 0;
            if (dado == 1 || dado == 2 || dado == 3 || dado == 4 || dado == 5)
            {
                num = 3;
            }
            else
             if (dado == 6 || dado == 7 || dado == 8)
            {
                num = (1);
            }
            else
             if (dado == 9 || dado == 10)
            {
                num = (-6);
            }
            return num;            
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
