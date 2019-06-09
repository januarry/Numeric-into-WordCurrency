using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursiveMoneyWord;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
            
        //}

        [TestMethod]
        public void TestConvertCurrency1()
        {
            Program p = new Program();
            p.InitializedValueMoneyDict();
            string test = "1111111111";
            Assert.AreEqual("ONE BILLION ONE HUNDRED ELEVEN MILLION ONE HUNDRED ELEVEN THOUSAND ONE HUNDRED ELEVEN", 
                p.PrintWordOfNum(test,test.Length));
        }

        [TestMethod]
        public void TestConvertCurrency2()
        {
            Program p = new Program();
            p.InitializedValueMoneyDict();
            string test = "1101101101";
            Assert.AreEqual("ONE BILLION ONE HUNDRED AND ONE MILLION ONE HUNDRED AND ONE THOUSAND ONE HUNDRED AND ONE",
                p.PrintWordOfNum(test, test.Length));
        }

        [TestMethod]
        public void TestConvertCurrenct3()
        {
            Program p = new Program();
            p.InitializedValueMoneyDict();
            string test = "321321321";
            Assert.AreEqual("THREE HUNDRED TWENTY-ONE MILLION THREE HUNDRED TWENTY-ONE THOUSAND THREE HUNDRED TWENTY-ONE",
                p.PrintWordOfNum(test,test.Length));
        }
    }
}
