using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE04
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data04.csv", "Data04#csv", 
                    DataAccessMethod.Sequential)]
        public void TestSum()
        {
            var s0 = long.Parse(TestContext.DataRow["s0"].ToString());
            var s = long.Parse(TestContext.DataRow["s"].ToString());
            var k = long.Parse(TestContext.DataRow["k"].ToString());

            var result = methods.Sum(s0, out long resultK);
            Assert.IsTrue(result == s && resultK == k);
        }
    }
}
