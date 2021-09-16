using System;

namespace GitHarjoitus2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terve Laskin!");

            Laskin laskimeni = new Laskin();

            Console.WriteLine("Laske lukujen 148 ja 56 erotus");
            int erotus = laskimeni.Erotus(148, 56);
            Console.WriteLine("erotus on: " + erotus);

            Console.WriteLine("Laske lukujen 305 ja 453 summa");
            int summa = laskimeni.Summa(305, 453);
            Console.WriteLine("summa on: " + summa);

            Console.WriteLine("Laske lukujen 15 ja 4 jakojäännös");
            int jakojaannos = laskimeni.JakoJaannos(15, 4);
            Console.WriteLine("Jakojäännös on: " + jakojaannos);

            Console.WriteLine("Laske lukujen 15 ja 7 tulo");
            int tulo = laskimeni.Tulo(15, 7);
            Console.WriteLine("Tulo on: " + tulo);

            Console.WriteLine("Laske lukujen 250 ja 10 jako");
            int jako = laskimeni.JakoLasku(250, 10);
            Console.WriteLine("Jakolasku on: "+ jako);
        }

    }
}
