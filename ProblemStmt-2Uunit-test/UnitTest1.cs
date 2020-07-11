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
           
            Random _random = new Random();
            int choice = _random.Next(1, 7);
            RuleEngineFactory factory = new RuleEngineFactory();
            var result = factory.ExecuteRule(choice);
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void TestChoice2()
        {
            Random _random = new Random();
            int choice = _random.Next(8,100);
            bool result = false;
            RuleEngineFactory factory = new RuleEngineFactory();
            try
            {
                  result = factory.ExecuteRule(choice);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(result, false);
            }
        }


    }
}
