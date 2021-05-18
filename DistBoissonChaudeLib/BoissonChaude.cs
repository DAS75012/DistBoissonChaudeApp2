using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistBoissonChaudeLib
{
    public enum eProduit
    { 
        Cafe,
        Sucre,
        Creme,
        The,
        Eau,
        Chocolat,
        Lait
    }

    abstract class BoissonChaude
    {
        const float marge = 1.30F;
        protected Dictionary<eProduit, float> prix_produit;

        public BoissonChaude()
        {
            prix_produit = new Dictionary<eProduit, float>();
            prix_produit[eProduit.Cafe] = 1.0F;
            prix_produit[eProduit.Sucre] = 0.1F;
            prix_produit[eProduit.Creme] = 0.5F;
            prix_produit[eProduit.The] = 2.0F;
            prix_produit[eProduit.Eau] = 0.2F;
            prix_produit[eProduit.Chocolat] = 1.0F;
            prix_produit[eProduit.Lait] = 0.4F;
        }

        public string prix() { return (prix_recette() * marge).ToString("n2"); }

        protected abstract float prix_recette();

    }
}
