using System;

namespace Week1Day3.Esercizio1
{
        class Program
        {
            static void Main(string[] args)
            {
                //Indovina valore: Creare e inizializzare un array di interi dimensione N=4;
                //Chiedere all'utente di provare ad indovinare un numero. Verificare se il numero inserito dall'utente c'è nell'array
                //Se c'è stampa "hai vinto", se non c'è stampa "Hai perso".

                Console.WriteLine("Indovina un numero nell'array");
                int[] ArrayNumero = { 1, 5, 6, 10 };
                StampaArray(ArrayNumero);
                bool vinto;
                do
                {
                    Console.WriteLine("Inserisci un numero da 1 a 10: ");
                    bool isnumero = int.TryParse(Console.ReadLine(), out int numero);
                    if (isnumero)
                    {
                        vinto = Confronta(ArrayNumero, numero);
                        if (vinto)
                        {
                            Console.WriteLine("HAI VINTO!");
                        }
                        else
                        {
                            Console.WriteLine("HAI PERSO!");
                        }
                    }
                    Console.WriteLine("\nVuoi continuare? Scrivi 'si' per continuare");

                } while (Console.ReadLine() == "si");


            }

            private static void StampaArray(int[] arrayNumero)
            {
                for (int x = 0; x < arrayNumero.Length; x++)
                {
                    Console.Write(arrayNumero[x] + "\t");
                }

                Console.WriteLine("\n");
            }

            private static bool Confronta(int[] arrayNumero, int n)
            {

                for (int x = 0; x < arrayNumero.Length; x++)
                {
                    if (n == arrayNumero[x])
                    {
                        return true;

                    }

                }

                return false;
            }
        }
    }

