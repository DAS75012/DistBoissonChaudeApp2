using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    class Expresso : BoissonChaude
    {
        protected override float prix_recette()
        {
            return prix_produit[eProduit.Cafe]
                + prix_produit[eProduit.Eau];
        }

    }
}
