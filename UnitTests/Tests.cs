using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            Check.That(Solution.DoIt("[()]")).IsTrue();
        }

        [TestMethod]
        public void Test2()
        {
            Check.That(Solution.DoIt("(()[])")).IsTrue();
        }

        [TestMethod]
        public void Test3()
        {
            Check.That(Solution.DoIt("([)]")).IsFalse();
        }
        [TestMethod]
        public void Test4()
        {
            Check.That(Solution.DoIt("((")).IsFalse();
        }
        [TestMethod]
        public void Test5()
        {
            Check.That(Solution.DoIt("[(()])")).IsFalse();
        }
        [TestMethod]
        public void Test6()
        {
            Check.That(Solution.DoIt("([(([[(([]))]]))])")).IsTrue();
        }
        [TestMethod]
        public void Test7()
        {
            Check.That(Solution.DoIt("[](()()[[]])()[]([])")).IsTrue();
        }
        [TestMethod]
        public void Test8()
        {
            Check.That(Solution.DoIt("([((([(([]))])))))])")).IsFalse();
        }

        [TestMethod]
        public void Test9()
        {
            Check.That(Solution.DoIt("[](()()[[]])[][[([])")).IsFalse();
        }

        [TestMethod]
        public void Test10()
        {
            Check.That(Solution.DoIt("")).IsTrue();
        }

        [TestMethod]
        public void Test11()
        {
            Check.That(Solution.DoIt(null)).IsTrue();
        }

        [TestMethod]
        public void Test12()
        {
            Check.That(Solution.DoIt("([])))]]]")).IsFalse();
        }
    }
}