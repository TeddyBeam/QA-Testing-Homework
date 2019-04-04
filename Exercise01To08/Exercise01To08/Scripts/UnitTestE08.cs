using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE08
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data08.csv", "Data08#csv", 
                    DataAccessMethod.Sequential)]
        public void TestQuickSort()
        {
            var list = TestContext.DataRow["list"].ToString();
            var array = list.Split(',').Select(i => int.Parse(i)).ToArray();
            var left = int.Parse(TestContext.DataRow["left"].ToString());
            var right = int.Parse(TestContext.DataRow["right"].ToString());

            var expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();
            var expectedOutputArray = expectedOutput.Split(',').Select(i => int.Parse(i)).ToArray();

            methods.QuickSort(array, left, right);
            Assert.IsTrue(array.SequenceEqual(expectedOutputArray));
        }
    }
}
