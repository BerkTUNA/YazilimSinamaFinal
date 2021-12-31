using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCPServer;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            sifreleme sifrele = new sifreleme();
            string sonuc = sifrele.BinaryToString("01101101 01100101 01110011 01100001 01101010");
            Assert.AreEqual(sonuc, "mesaj");

        }
        [TestMethod]
        public void TestMethod2()
        {
            sifreleme sifrele = new sifreleme();
            string sonuc = sifrele.StringToBinary("mesaj");
            Assert.AreEqual(sonuc, "01101101 01100101 01110011 01100001 01101010");

        }
        public void TestMethod3()
        {
            sifreleme sifrele = new sifreleme();
            string sonuc = sifrele.SHA_256_sifreleme("mesaj");
            Assert.AreEqual(sonuc, "90ccb74816866ce720a6b5bd2137ed1730e656426f2b60a35e0d9b1e93942dcd");

        }
        public void TestMethod4()
        {
            sifreleme sifrele = new sifreleme();
            string sonuc = sifrele.SPN16("yaz");
            Assert.AreEqual(sonuc, "{S");

        }
        public void TestMethod5()
        {
            sifreleme sifrele = new sifreleme();
            string sonuc = sifrele.HashToByte(Encoding.UTF8.GetBytes("mesaj"));
            Assert.AreEqual(sonuc, "6d6573616a");

        }

    }
}
