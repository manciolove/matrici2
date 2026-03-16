namespace matrici2
{
    static class Program
    {
        // funzione esercizio 1 
        static bool VerificaValori(int[,] m, int x, int y)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] < x || m[i, j] > y)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // funzione esercizio 2 
        static bool SommaDiagonali(int[,] m)
        {
            int sP = 0, sS = 0;
            int l = m.GetLength(0) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
            { 
                sP += m[i, i];
                sS = sS + m[i, l];
                
            }
            if (sP == sS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // funzione esercizio 3
        static bool VerificaBordi (int[,] m)
        {
            int n = m[0, 0];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == 0 || i == m.GetLength(0) - 1 || j == 0 || j == m.GetLength(1) - 1)
                    {
                        if (m[i, j] != n)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        // funzione esercizio 4
        static bool Palindroma(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                int sommaInizio = 0;
                int sommaFine = 0;

                for (int j = 0; j < m.GetLength(1); j++)
                {
                    sommaInizio = sommaInizio + m[i, j];
                    sommaFine = sommaFine + m[m.GetLength(0) - 1 - i, j];
                }

                if (sommaInizio != sommaFine)
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            int[,] m = { { 1, 2 }, { 4, 5 }, { 7, 8 } };

            // esercizio 1
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esercizio 1");

            int x = 1;
            int y = 4;
            bool risultato = VerificaValori(m, x, y);
            if (risultato == true)
            {
                Console.WriteLine("i valori tra " + x + " e " + y + " sono compresi");
            }
            else if (risultato == false)
            {
                Console.WriteLine("i valori tra " + x + " e " + y + " non sono compresi");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            // esercizio 2
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esercizio 2");
            int[,] s = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            bool somma = SommaDiagonali(s);
            if (somma == true)
            {
                Console.WriteLine("la somma delle diagonali è uguale");
            }
            else if (somma == false)
            {
                Console.WriteLine("la somma delle diagonali non è uguale");

            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            // esercizio 3
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esercizio 3");


            bool bordi = VerificaBordi(m);
            if (bordi == true)
            {
                Console.WriteLine("i bordi sono uguali");
            }
            else if (bordi == false)
            {
                Console.WriteLine("i bordi non sono uguali");
            } 
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            // esercizio 4
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esercizio 4");
            for (int i = 0; i < m.GetLength(0) / 2; i++)
            {
                    Console.Write(Palindroma(m));
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }
    }
}
