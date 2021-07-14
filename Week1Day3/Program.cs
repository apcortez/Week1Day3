using System;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
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
            int prodotto;
            int diffX1X2 = DifferenzaEProdotto(x1, x2, out prodotto);
            Console.WriteLine($"Il prodotto tra x1 e x2 è {prodotto}");
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

        private static void Menu()
        {
            Console.WriteLine("***MENU***");
            Console.WriteLine("1. Opzione1");
            Console.WriteLine("2. Opzione2");
            Console.WriteLine("3. Opzione3");
        }
    
    }
}
