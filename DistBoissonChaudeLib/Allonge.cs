using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    class Allonge : BoissonChaude
    {
        protected override float prix_recette()
        {
            return prix_produit[eProduit.Cafe]
                + (2 * prix_produit[eProduit.Eau]);
        }
    }
}
