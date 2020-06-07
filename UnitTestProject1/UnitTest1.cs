using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lab05_3.Hour Test = new Lab05_3.Hour();
            List<Lab05_3.Hour> list = new List<Lab05_3.Hour>();
            for (int i = 0; i < 5; i++)
            {
                Lab05_3.Hour nw = new Lab05_3.Hour
                {
                    Name = "Name" + i,
                    ListNumberRoute = "12,834"+20*i,
                    NumberPassegers = 15+i,
                    Comentar = "ss"+i+20*i,
                };
                list.Add(nw);
            }
            int res = Lab05_3.Hour.AllNumPass(list);
            Assert.AreEqual(res, 85);
        }

    }
}
