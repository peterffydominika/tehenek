using Microsoft.VisualStudio.TestTools.UnitTesting;
using tehenek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehenek.Tests
{
    [TestClass()]
    public class TehenTests
    {
        [TestMethod()]
        public void hetiAtlagTest()
        {
            Tehen tehenke = new Tehen("BAB6");
            tehenke.EredmenytRogzit("0", "10");
            tehenke.EredmenytRogzit("3", "20");
            tehenke.EredmenytRogzit("5", "20");

            Assert.AreEqual(50, tehenke.hetiAtlag());
        }
        [TestMethod()]
        public void hetiAtlagTest2()
        {
            Tehen tehenke = new Tehen("B6");
            tehenke.EredmenytRogzit("0", "10");
            tehenke.EredmenytRogzit("2", "5");
            tehenke.EredmenytRogzit("4", "20");

            Assert.AreEqual(35, tehenke.hetiAtlag());
        }
        [TestMethod()]
        public void hetiAtlagTest3()
        {
            Tehen tehenke = new Tehen("46");
            tehenke.EredmenytRogzit("0", "10");
            tehenke.EredmenytRogzit("1", "5");
            tehenke.EredmenytRogzit("7", "40");

            Assert.AreEqual(55, tehenke.hetiAtlag());
        }
    }
}
