using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace La_Liebre_y_La_Tortuga
{
    class Jugador
    {
        protected static int[] dado=new int[100];        
        private int _Posicion;
        private string _Tipo;
        public string Tipo
        {
            get { return _Tipo; }
        }
        protected static int n = 0;
        public int Posicion
        {
            get { return _Posicion; }
        }

     
        public Jugador(string tipo)
        {
            
            _Tipo = tipo;
            _Posicion = 0;
            //N = 0;
            n =0;
            dado[n]=0;
           
        }
        Random ran = new Random(DateTime.Now.Millisecond);

        public void Dado()
        { 


            
            dado[n] = ran.Next(1, 10);
            

        }
        public void avanzar(int num)
        {

          _Posicion += num;          
        }
        public override string ToString()
        {
            return _Tipo+ " esta en la "+ Posicion+Environment.NewLine;
        }


    }
}
