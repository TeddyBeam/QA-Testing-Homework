using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE02
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data02.csv", "Data02#csv", 
                    DataAccessMethod.Sequential)]
        public void TestSolveQuadratic()
        {
            var a = int.Parse(TestContext.DataRow["a"].ToString());
            var b = int.Parse(TestContext.DataRow["b"].ToString());
            var c = int.Parse(TestContext.DataRow["c"].ToString());
            var expectedX1 = float.Parse(TestContext.DataRow["x1"].ToString());
            var expectedX2 = float.Parse(TestContext.DataRow["x2"].ToString());
            var expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();

            var result = methods.SolveQuadratic(a, b, c, out float x1, out float x2);
            Assert.IsTrue(x1 == expectedX1 && x2 == expectedX2 && result == expectedOutput);
        }
    }
}
