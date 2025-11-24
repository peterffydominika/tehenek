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
            Tehen tehen1 = new Tehen("19");
            tehen1.EredmenytRogzit("0", "14");
            tehen1.EredmenytRogzit("2", "5");
            tehen1.EredmenytRogzit("5", "8");

            Assert.AreEqual(17, tehen1.hetiAtlag());
        }
    }
}