using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE06
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data06.csv", "Data06#csv", 
                    DataAccessMethod.Sequential)]
        public void TestThayThe()
        {
            var s1 = TestContext.DataRow["s1"].ToString();
            var s2 = TestContext.DataRow["s2"].ToString();
            var s3 = TestContext.DataRow["s3"].ToString();
            var expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();

            string result = methods.ThayThe(s1, s2, s3);
            Assert.IsTrue(result == expectedOutput);
        }
    }
}
