using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal zemesRutulioPlotas = ZemesRutulioPlotas();
            decimal zemesRutulioTuris = ZemesRutulioTuris();
            decimal trikampioIzambine = Convert.ToDecimal(Math.Sqrt((double)TrikampioIzambine()));

            decimal kintamujuSuma = zemesRutulioPlotas + zemesRutulioTuris + trikampioIzambine;
            decimal kintamujuVidurkis = kintamujuSuma / 3;

            Console.WriteLine("Zemes rutulio plotas: {0} \n", zemesRutulioPlotas.ToString("N"));
            Console.WriteLine("Zemes rutulio turis: {0} \n", zemesRutulioTuris.ToString("N"));
            Console.WriteLine("Staciojo trikampio izambines ilgis: {0} \n", trikampioIzambine.ToString("N"));
            Console.WriteLine("Visu kintamuju suma: {0} \n", kintamujuSuma.ToString("N"));
            Console.WriteLine("Visu kintauju vidurkis: {0} \n", kintamujuVidurkis.ToString("N"));

            Console.Read();
        }

        private static decimal ZemesRutulioTuris()
        {
            return ((4 * (decimal)Math.PI * (decimal)Math.Pow(6371, 3)) / 3);
        }
        private static decimal TrikampioIzambine()
        {
            return ((decimal)Math.Pow(10, 2) + (decimal)Math.Pow(15, 2));
        }
        private static decimal ZemesRutulioPlotas()
        {
            return (4 * (decimal)Math.PI * (decimal)Math.Pow(6371, 2));
        }
    }
}
