using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APL;

namespace Unit_Test_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJumlah()
        {
            int hasil = Count.Math.pertambahan(30000, 50000);
            Assert.AreEqual(80000, hasil);
        }

        [TestMethod]
        public void TestKurang()
        {
            int hasil = Count.Math.pengurangan(40000, 30000);
            Assert.AreEqual(10000, hasil);
        }

        [TestMethod]
        public void addUser()
        {
            string firstname = "A";
            string lastname = "B";
            string username = "C";
            string password = "D";
            string email = "E";

            pengguna.addUser(firstname, lastname, username, password, email);
        }
    }
}