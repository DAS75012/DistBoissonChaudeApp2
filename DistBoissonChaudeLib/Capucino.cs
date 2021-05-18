using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    class Capucino : BoissonChaude
    {
        protected override float prix_recette()
        {
            return prix_produit[eProduit.Cafe]
                + prix_produit[eProduit.Chocolat]
                + prix_produit[eProduit.Eau]
                + prix_produit[eProduit.Creme];
        }

    }
}
