using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array de prueba*/
            int[] A = new int[7];
            A[0] = 10;
            A[1] = 3;
            A[2] = 9;
            A[3] = 9;
            A[4] = 9;
            A[5] = 9;
            A[6] = 3;

            /*ordeno array de menor a mayor*/

            Array.Sort(A);

            /*Variable que guardara el numero que este sin compañero*/
            int numeroSolo = 0;

            /*Recorro el array, y por cada vuelta lo hago de a 2. Esto es para verificar que cda numero tenga su compañero*/

            for (int i = 0; i < A.Length; i+=2)
            {
                /*Guardo el numero recorrido*/
                int numeroActual = A[i];

                /*verifico que no sea el ultimo lugar del array*/
                if (i + 1 <= A.Length - 1)
                {
                    /*Guardo el numero que esta al lado del que recorro actualmente*/
                    int numeroSiguiente = A[i + 1];
                    
                    /*Verifico que el numero recorrido y el siguiente no sean iguales*/
                    if (numeroActual != numeroSiguiente)
                    {
                        /*si no son iguales, es porque el que recorro no tiene su pareja*/
                        numeroSolo = numeroActual;
                        
                        /*termino recorrido de array*/
                        break;
                    }
                } 
                else {
                    /*si llego al ultimo lugar, por descarte, este es el numero sin pareja*/
                    numeroSolo = numeroActual;
                }
                
                
            }
            /*Devuelvo el numero encontrado sin pareja*/
            return numeroSolo;
        }
    }
}
