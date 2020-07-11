using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Rule.Engine;
using Business.Rule.Engine;
using System;

namespace ProblemStmt_2Uunit_test
{
    [TestClass]
    public class UnitTest1
    {




        [TestMethod]
        public void TestChoice1()
        {
            var choice = 1;

            RuleEngineFactory factory = new RuleEngineFactory();
            var result = factory.ExecuteRule(choice);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestChoice8()
        {
            var choice = 8;

            RuleEngineFactory factory = new RuleEngineFactory();
            var result = factory.ExecuteRule(choice);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
    "Invalid Choice")]
        public void NullUserIdInConstructor()
        {
            var choice = 8;

            RuleEngineFactory factory = new RuleEngineFactory();
            var result = factory.ExecuteRule(choice);
        }
    }
}
