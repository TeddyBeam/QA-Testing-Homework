using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE07
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data07.csv", "Data07#csv", 
                    DataAccessMethod.Sequential)]
        public void TestLargest()
        {
            var a = TestContext.DataRow["a"].ToString();
            var aArray = a.Split(',').Select(i => int.Parse(i)).ToArray();
            var expectedOutput = int.Parse(TestContext.DataRow["ExpectedOutput"].ToString());
            
            var result = methods.Largest(aArray);
            Assert.IsTrue(result == expectedOutput);
        }
    }
}
