using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Liebre_y_La_Tortuga
{
    class Carrera
    {
        Liebre j1 = new Liebre("Liebre");
        Tortuga j2 = new Tortuga("Tortuga");
        private string _Text;
        public Carrera()
        {

        }
        public void iniciar()
        {           
            _Text = "";
            Comenzar();            
        }
        public void Comenzar()
        {           
            while (j1.Posicion < 100 && j2.Posicion < 100)
            {                  
                j1.avanzar();
                _Text += j1.ToString();
                j2.avanzar();
                _Text += j2.ToString();
                
                if (j1.Posicion >= 100 && j2.Posicion >= 100)
                {
                    _Text += "Empate.";
                    return;
                }
                else
              if (j1.Posicion >= 100)
                {
                    _Text += j1.Tipo + " gano.";
                    return;
                }
                else
              if (j2.Posicion >= 100)
                {
                    _Text += j2.Tipo + " gano.";
                    return;
                }
            }
        }
        public override string ToString()
        {
            return _Text;
        }
    }
}
