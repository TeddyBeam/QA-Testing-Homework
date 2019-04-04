using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods = MethodLibrary.MethodLibrary;

namespace Exercise01To08
{
    [TestClass]
    public class UnitTestE03
    {
        public TestContext TestContext { get; set; }

        private readonly Methods methods = new Methods();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @"|DataDirectory|\Data\Data03.csv", "Data03#csv", 
                    DataAccessMethod.Sequential)]
        public void TestTinhTienDien()
        {
            var chiSoCu = int.Parse(TestContext.DataRow["ChiSoCu"].ToString());
            var chiSoMoi = int.Parse(TestContext.DataRow["ChiSoMoi"].ToString());
            var expectedOutput = double.Parse(TestContext.DataRow["ExpectedOutput"].ToString());

            var result = methods.TinhTienDien(chiSoCu, chiSoMoi);
            Assert.IsTrue(result == expectedOutput);
        }
    }
}
