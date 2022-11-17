using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Application
{
    internal class Program
    {
        private double ZemesRutulioPlatas()
        {
            int zemesSpindulys = 6371;
            return 4 * Math.PI * Math.Pow((zemesSpindulys), 2);
        }
        private double TrikampioIzambine()
        {
            int pirmaKrastine = 10;
            int antraKrastine = 15;
            return Math.Pow((Math.Pow((pirmaKrastine), 2) + Math.Pow((pirmaKrastine), 2)), 0.5);
            ;
        }
        static void Main(string[] args)
        {

            var program = new Program();

            double zemesRutulioPlatas = program.ZemesRutulioPlatas();
            decimal zemesRutulioTuris = 0;
            double trikampioIzambine = program.TrikampioIzambine();
        }
    }
}
