using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Application
{
    internal class Program
    {
        private static double ZemesRutulioPlotas()
        {
            int zemesSpindulys = 6371;
            return 4 * Math.PI * Math.Pow((zemesSpindulys), 2);
        }
        private static double TrikampioIzambine()
        {
            int pirmaKrastine = 10;
            int antraKrastine = 15;
            return Math.Pow((Math.Pow((pirmaKrastine), 2) + Math.Pow((pirmaKrastine), 2)), 0.5);
            ;
        }
        static void Main(string[] args)
        {

            var program = new Program();

            double zemesRutulioPlotas = ZemesRutulioPlotas();
            double zemesRutulioTuris = ZemesRutulioTuris();
            double trikampioIzambine = TrikampioIzambine();

            double kintamujuSuma = zemesRutulioPlotas + zemesRutulioTuris + trikampioIzambine;
            double kintamujuVidurkis = kintamujuSuma / 3;

            Console.WriteLine("Zemes rutulio plotas: {0} \n", zemesRutulioPlotas.ToString("N"));
            Console.WriteLine("Zemes rutulio turis: {0} \n", zemesRutulioTuris.ToString("N"));
            Console.WriteLine("Staciojo trikampio izambines ilgis: {0} \n", trikampioIzambine.ToString("N"));
            Console.WriteLine("Visu kintamuju suma: {0} \n", kintamujuSuma.ToString("N"));
            Console.WriteLine("Visu kintauju vidurkis: {0} \n", kintamujuVidurkis.ToString("N"));

            Console.Read();
        }

        private static double ZemesRutulioTuris()
        {
            return ((4 * Math.PI * Math.Pow(6371, 3)) / 3);
        }
        //private static decimal TrikampioIzambine()
        //{
        //    return ((decimal)Math.Pow(10, 2) + (decimal)Math.Pow(15, 2));
        //}
        //private static decimal ZemesRutulioPlotas()
        //{
        //    return (4 * (decimal)Math.PI * (decimal)Math.Pow(6371, 2));
        //}
    }
}
