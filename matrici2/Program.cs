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
        static bool Somma(int[,] m)
        {
            int cont = 0;
            int cont2 = 0;
            int j = m.GetLength(0) - 1;
            bool c = false;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                 cont = cont + m[i, j];
                cont2= cont2 + m[i, j];
                j -= 1;
            }
            if (cont == cont2)
            {
                return c = true;
            }
            else
            {
                return c;
            }
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
                Console.WriteLine($"i valori tra {x} e {y} sono compresi");
            }
            else if (risultato == false)
            {
                Console.WriteLine($"i valori tra {x} e {y} non sono compresi");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            // esercizio 2
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esercizio 2");
            bool somma = Somma(m);
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
        }
    }
}
