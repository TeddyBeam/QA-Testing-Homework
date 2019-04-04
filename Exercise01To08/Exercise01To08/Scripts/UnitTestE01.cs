using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE01
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data01.csv", "Data01#csv", 
                    DataAccessMethod.Sequential)]
        public void TestSolveQuadratic()
        {
            var a = int.Parse(TestContext.DataRow["a"].ToString());
            var b = int.Parse(TestContext.DataRow["b"].ToString());
            var c = int.Parse(TestContext.DataRow["c"].ToString());
            var expectedOutput = int.Parse(TestContext.DataRow["ExpectedOutput"].ToString());

            var result = methods.Max(a, b, c);
            Assert.IsTrue(result == expectedOutput);
        }
    }
}
