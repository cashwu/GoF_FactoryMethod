using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethod.Tests
{
    [TestClass()]
    public class HamburgStoreTests
    {
        [TestMethod()]
        public void createHamburgTest()
        {
            HamburgStore store = new TainanHamburgStore();
            Hamburg ham = store.createHamburg("pork");
            Assert.AreEqual(typeof(SweetPorkHamburg), ham.GetType());

            ham = store.createHamburg("beef");
            Assert.AreEqual(typeof(SweetBeefHamburg), ham.GetType());

            try
            {
                ham = store.createHamburg("test");
                Assert.Fail();
            }
            catch (Exception)
            {
            }
        }
    }
}