using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    public enum eBoissonChaude
    {
        Expresso,
        Allonge,
        Capucino,
        Chocolat,
        The
    }

    public class DistBoissonChaude
    {
        Dictionary<eBoissonChaude, BoissonChaude> prix_boisson_chaude;
        public DistBoissonChaude()
        {
            prix_boisson_chaude = new Dictionary<eBoissonChaude, BoissonChaude>();
            prix_boisson_chaude[eBoissonChaude.Expresso] = new Expresso();
            prix_boisson_chaude[eBoissonChaude.Allonge] = new Allonge();
            prix_boisson_chaude[eBoissonChaude.Capucino] = new Capucino();
            prix_boisson_chaude[eBoissonChaude.Chocolat] = new Chocolat();
            prix_boisson_chaude[eBoissonChaude.The] = new The();
        }

        public string prix(eBoissonChaude boissonChaude)
        {
            return prix_boisson_chaude[boissonChaude].prix();
        }
    }
}
