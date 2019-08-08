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
            int[] A = new int[7];
            A[0] = 10;
            A[1] = 3;
            A[2] = 9;
            A[3] = 9;
            A[4] = 9;
            A[5] = 9;
            A[6] = 3;

            Array.Sort(A);
            int numeroSolo = 0;
            for (int i = 0; i < A.Length; i+=2)
            {
                int numeroActual = A[i];


                if (i + 1 <= A.Length - 1)
                {
                    int numeroSiguiente = A[i + 1];

                    if (numeroActual != numeroSiguiente)
                    {
                        numeroSolo = numeroActual;
                        break;
                    }
                }
                else {
                    numeroSolo = numeroActual;
                }
                
                
            }
            /*  bool bandera = false;
              int numeroSolo = 0;

              for (int i = 0; i < A.Length; i++)
              {
                  int numeroBuscado = A[i];

                  for (int b = 0; b < A.Length; b++)
                  {
                      if (i!=b)
                      {
                          int numeroActual = A[b];

                          if (numeroActual==numeroBuscado)
                          {
                              bandera = true;
                              break;
                          }
                      }
                  }
                  if (!bandera)
                  {
                      numeroSolo = numeroBuscado;
                      break;
                  }
                  bandera = false;
              }*/
            Console.WriteLine(numeroSolo);
            Console.ReadKey();
        }
    }
}
