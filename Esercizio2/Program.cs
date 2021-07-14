using System;

namespace Week1Day3.Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Analizza Numeri

            //Si scriva un programma per poter analizzare una sequenza di numeri.
            //Dati N numeri interi letti da tastiera(alternativa generati in maniera Random)
            //si vogliono calcolare e stampare su schermo diversi risultati:


            //1.quanti sono i numeri positivi, nulli e negativi
            //2.quanti sono i numeri pari e dispari
            //3.se la sequenza dei numeri inseriti è crescente, decrescente oppure né crescente né decrescente.

            //Suggerimento.
            //Una sequenza è crescente se ogni numero è maggiore del precedente,
            //decrescente se ogni numero è minore del precedente,
            //né crescente né decrescente in tutti gli altri casi.

            Console.WriteLine("Analizza numeri.");
            Console.WriteLine("Quanti numeri vuoi analizzare?");
            bool isnumero = int.TryParse(Console.ReadLine(), out int numero);
            int[] ArrayNumero = new int[numero];
            if (isnumero)
            {
                for (int x = 0; x < numero; x++)
                {
                    Console.WriteLine($"Inserisci il {x + 1}^ numero: ");
                    ArrayNumero[x] = int.Parse(Console.ReadLine());

                }

                int positivi = Positivita(ArrayNumero);
                int negativi = Negativita(ArrayNumero);
                int nulli = Nullo(ArrayNumero);

                int p = Pari(ArrayNumero, out int dispari);


                bool cresc = Cresente(ArrayNumero);
                bool decresc = Decrescente(ArrayNumero);


                Console.WriteLine("Analisi eseguita: ");
                Console.WriteLine($"Numeri positivi: {positivi}");
                Console.WriteLine($"Numeri negativi: {negativi}");
                Console.WriteLine($"Numeri nulli: {nulli}");
                Console.WriteLine($"Numeri pari: {p}");
                Console.WriteLine($"Numeri dispari: {dispari} ");
                if (!cresc && !decresc)
                {
                    Console.WriteLine($"Numeri nè crescenti nè decrescenti! ");
                }
                else if (cresc)
                {
                    Console.WriteLine("Ordinamento crescente");
                }
                else if (decresc)
                {
                    Console.WriteLine("Ordinamento decrescente ");
                }

            }
            else 
            {
                Console.WriteLine("quantità di numeri da analizzare non valida! ");
            }

        }

      

        private static bool Decrescente(int[] arrayNumero)
        {
           
            for (int x = 0; x < arrayNumero.Length-1; x++)
            {
                if (arrayNumero[x] > arrayNumero[x + 1])
                {
                    continue;
                }else
                {
                    return false;
                }
            }

            return true;

        }

        private static bool Cresente(int[] arrayNumero)
        {
            
            for (int x = 0; x < arrayNumero.Length-1; x++)
            {   
                if (arrayNumero[x] < arrayNumero[x + 1])
                {
                    continue;
                }
                else
                {
                   return false;
                }
            }

            return true;

        }

        private static int Pari(int[] arrayNumero, out int  dispari)
        {
            int pari=0;
            dispari = 0;
            for (int x = 0; x < arrayNumero.Length; x++)
            {
                if (arrayNumero[x] % 2 == 0)
                {
                    pari++;
                }
                else dispari++;
            }

            
            return pari;
        }

        private static int Nullo(int[] arrayNumero)
        {
            int nulli=0;
            for (int x = 0; x < arrayNumero.Length; x++)
            {
                if (arrayNumero[x] == 0)
                {
                    nulli++;
                }
            }

            return nulli;
        }

        private static int Negativita(int[] arrayNumero)
        {
            int negativi=0;
            for (int x = 0; x < arrayNumero.Length; x++)
            {
                if (arrayNumero[x] < 0)
                {
                    negativi++;
                }
            }

            return negativi;
        }


        private static int Positivita(int[] arrayNumero)
        { int positivi=0;
            for (int x = 0; x < arrayNumero.Length; x++) 
            {
                if (arrayNumero[x] > 0)
                {
                    positivi++;
                }
            }

            return positivi;
        }


    }
}
