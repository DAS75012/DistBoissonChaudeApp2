using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistBoissonChaudeLib;

namespace BoissonChaudeUnitTest
{
    [TestClass]
    public class BoissonChaudeTest
    {
        [TestMethod]
        public void Prix_Expresso_Test()
        {
            DistBoissonChaude boissonChaude = new DistBoissonChaude();
            Assert.AreEqual("1,56", boissonChaude.prix(eBoissonChaude.Expresso));
        }

        [TestMethod]
        public void Prix_Allonge_Test()
        {
            DistBoissonChaude boissonChaude = new DistBoissonChaude();
            Assert.AreEqual("1,82", boissonChaude.prix(eBoissonChaude.Allonge));
        }

        [TestMethod]
        public void Prix_Capucino_Test()
        {
            DistBoissonChaude boissonChaude = new DistBoissonChaude();
            Assert.AreEqual("3,51", boissonChaude.prix(eBoissonChaude.Capucino));
        }

        [TestMethod]
        public void Prix_Chocolat_Test()
        {
            DistBoissonChaude boissonChaude = new DistBoissonChaude();
            Assert.AreEqual("5,33", boissonChaude.prix(eBoissonChaude.Chocolat));
        }

        [TestMethod]
        public void Prix_The_Test()
        {
            DistBoissonChaude boissonChaude = new DistBoissonChaude();
            Assert.AreEqual("1,82", boissonChaude.prix(eBoissonChaude.The));
        }
    }
}
