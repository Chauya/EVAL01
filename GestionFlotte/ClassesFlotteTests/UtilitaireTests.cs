using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire u = new Utilitaire("02-BCV-44", "Diesel", 120, 15, 2, 5);
            Assert.AreEqual(13, u.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            Utilitaire u = new Utilitaire("02-BCV-44", "Diesel", 120, 15, 2, 5);
            Entretien e1 = new Entretien(new DateTime(2009, 12, 10), 215000, "OK");
            Entretien e2 = new Entretien(new DateTime(2021, 12, 10), 216000, "OK");
            u.AjouterEntretien(e1);
            Assert.AreEqual(true, u.PrevoirEntretien());
            u.AjouterEntretien(e2);
            Assert.AreEqual(false, u.PrevoirEntretien());
        }
    }
}