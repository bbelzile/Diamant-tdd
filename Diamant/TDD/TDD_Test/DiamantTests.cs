using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Discovery;

namespace TDD.Tests
{
    [TestClass()]
    public class DiamantTests
    {
        [TestMethod()]
        public void Diamant_recoit_lettre_A_en_param_retourne_string()
        {
            var diamant = new Diamant();
            char lettreEnEntree = 'A';
            string resultat;

            resultat = diamant.AfficherDiamant(lettreEnEntree);

            Assert.AreEqual("A", resultat);
        }

        [TestMethod()]
        public void Diamant_recoit_lettre_a_en_param_retourne_A()
        {
            var diamant = new Diamant();
            char lettreEnEntree = 'a';
            string resultat;

            resultat = diamant.AfficherDiamant(lettreEnEntree);

            Assert.AreEqual("A", resultat);
        }

        [TestMethod()]
        public void Diamant_recoit_lettre_b_en_param_retourne_un_diamant_avec_B_en_point_plus_large()
        {
            var diamant = new Diamant();
            char lettreEnEntree = 'b';
            string resultat;

            resultat = diamant.AfficherDiamant(lettreEnEntree);

            Assert.AreEqual(" A \nB B\n A ", resultat);
        }
    }
}