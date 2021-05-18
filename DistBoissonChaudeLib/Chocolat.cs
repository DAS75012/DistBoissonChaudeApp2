using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    class Chocolat : BoissonChaude
    {
        protected override float prix_recette()
        {
            return (3 * prix_produit[eProduit.Chocolat])
                + (2 * prix_produit[eProduit.Lait])
                + prix_produit[eProduit.Eau]
                + prix_produit[eProduit.Sucre];
        }
        
    }
}
