using System;
using System.Collections.Generic;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodi
            //Routine();


            //Array
            int[] primoArray = new int[5];
            primoArray[0] = 3;
            primoArray[1] = 10;
            primoArray[2] = 13;
            primoArray[3] = 55;
            primoArray[4] = 8;

            //cerco la posizione in base al valore
            int indice = Array.IndexOf(primoArray, 10);
            Console.WriteLine($"Il numero 10 si trova alla posizione {indice}"); //restituisce solo il primo indice in cui trova il valore 10 anche se vi sono più indici con valore 10.

            Console.WriteLine("Stampa del mio primoArray");
            for(int i =0; i<primoArray.Length; i++)
            {
                Console.Write($"{primoArray[i]}\t");
            }


            int[] numeri = { 1, 2, 45, 67, 70 };

            List<int> listaNumeri = new List<int>();
            listaNumeri.Add(23);
            listaNumeri.Add(45);
            int elementi = listaNumeri.Count;
            Console.WriteLine($"La mia listaNumeri contiene {elementi} elementi");

        }

        private static void Routine()
        {
            //routine
            Menu();

            //metodo con parametri per la somma
            int a = 1;
            int b = 2;
            int somma = 0;
            somma = Sum(a, b);

            //metodo con parametri per la somma e successivamente la sua stampa
            int c = 40;
            int d = 4;
            int sommaCD = Sum(c, d);
            Console.WriteLine(sommaCD);

            //metodo con parametri per la stampa
            int e = 45;
            int f = 2;
            StampaSomma(e, f);

            int var1 = 10;
            Cambiovalore(var1); //NON cambia valore var1 alla stampa rimane sempre 10 perchè sta solo nel metodo --> passaggio di parametro per valore
            Console.WriteLine($"Il valore di var1 dopo la chiamata a Cambiovalore è {var1}");

            CambiovalorePerRif(ref var1); //cambia il valore di var1 alla stampa --> passaggio per riferimento
            Console.WriteLine($"Il valore di var1 dopo la chiamata a CambiovalorePerRif è {var1}");


            //Chiamata metodo SommaDopoIncremento
            int n = 2;
            int m = 10;
            int sommaNM = SommaDopoIncremento(ref n, m);
            Console.WriteLine($"La variabile n vale: {n}");
            Console.WriteLine($"La variabile m vale: {m}");
            Console.WriteLine($"La somma n+m vale: {sommaNM}");

            //out
            int x1 = 2;
            int x2 = 3;
            //int prodotto;
            int diffX1X2 = DifferenzaEProdotto(x1, x2, out int prodotto);
            Console.WriteLine($"Il prodotto tra x1 e x2 è {prodotto}");


            //TryParse.
            Menu();
            Console.WriteLine("Inserisci la tua scelta: ");
            //int scelta = int.Parse(Console.ReadLine());
            //bool verificaCheSiaIntero = int.TryParse(Console.ReadLine(), out int scelta);
            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
            {
                Console.WriteLine("Scelta errata. Riprova.");
            }
            Console.WriteLine($"La scelta dell'utente è {scelta}");
        }

        //Mi deve sostituire la differenza ma mi interessa anche avere in output il prodotto dei 2 valori passati in input
        private static int DifferenzaEProdotto(int x, int y, out int p)
        {
            int diff = x - y;
            p = x * y; //p viene riconosciuta al di fuori del metodo 

            return diff;
        }

        //Scrivere una funzione che prenda in input 2 interi (il primo per riferimento, il secondo per valore) li incrementa di 1 e resistuisce la loro somma
        private static int SommaDopoIncremento(ref int x, int y)
        {
            x++;
            y++;
            return x + y;
        }


        //Metodo con passaggio per valore
        private static void Cambiovalore(int x)
        { 
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Valore = {x}");
        }

        //Metodo con passagio per riferimento
        private static void CambiovalorePerRif(ref int x)
        {
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Valore = {x}");
        }


        private static void StampaSomma(int x, int y)
        {
            Console.WriteLine($"La somma tra {x} e {y} è {Sum(x,y)}");
        }

        private static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        //Overloading -> guarda solo la signature: nome metodo+ parametri
        //Il valore di ritorno può essere diverso
        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        private static void Menu()
        {
            Console.WriteLine("***MENU***");
            Console.WriteLine("1. Opzione1");
            Console.WriteLine("2. Opzione2");
            Console.WriteLine("3. Opzione3");
        }
    
    }
}
