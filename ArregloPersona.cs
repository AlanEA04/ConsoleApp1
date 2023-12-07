using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArregloPersona
    {

        private int[] miMatriz;
        int valores;
        public ArregloPersona(int tamaño)
        {
           miMatriz = new int [tamaño];
           //tamaño = posocion
        }

        public void Insertar(int posicion)
        {
            int i;

            for (i = 0; posicion < miMatriz.Length;)
            {   
                miMatriz[i] = posicion;
                
                miMatriz[posicion] = valores;   
                Console.WriteLine($"ingresa los valores de la posicion {posicion} ");
               

            }
            
                //if (valores != null)
                //{


                //    Console.WriteLine($"ingresa los valor de la posicion{posicion}");
                //    valores = miMatriz[valores];
                //    miMatriz[valores] = posicion;
                //    posicion++;                                          
                //}
         
        }

        public void Mostrar() 
        {
            miMatriz = miMatriz;
            valores = miMatriz[valores];
           
        
        }


        public  void ValorBuscado(int Buscado)
        {




        }
        

    }
}
