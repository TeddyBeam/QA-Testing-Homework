using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE05
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data05.csv", "Data05#csv", 
                    DataAccessMethod.Sequential)]
        public void TestHuyChuoi()
        {
            var s = TestContext.DataRow["s"].ToString();
            var n = int.Parse(TestContext.DataRow["n"].ToString());
            var p = int.Parse(TestContext.DataRow["p"].ToString());
            var expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();

            string result = methods.HuyChuoi(s, n, p);
            Assert.IsTrue(result == expectedOutput);
        }
    }
}
