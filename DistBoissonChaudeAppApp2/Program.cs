using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistBoissonChaudeLib;

namespace DistBoissonChaudeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DistBoissonChaude distBoissonChaude = new DistBoissonChaude();

            Console.WriteLine("Distributeur automatique de boisson chaude : ");
            Console.WriteLine("-- Prix Expresso = {0}", distBoissonChaude.prix(eBoissonChaude.Expresso));
            Console.WriteLine("-- Prix Allonge = {0}", distBoissonChaude.prix(eBoissonChaude.Allonge));
            Console.WriteLine("-- Prix Chocolat = {0}", distBoissonChaude.prix(eBoissonChaude.Capucino));
            Console.WriteLine("-- Prix Capucino = {0}", distBoissonChaude.prix(eBoissonChaude.Chocolat));
            Console.WriteLine("-- Prix The = {0}", distBoissonChaude.prix(eBoissonChaude.Chocolat));
            Console.ReadLine();

        }
    }
}
