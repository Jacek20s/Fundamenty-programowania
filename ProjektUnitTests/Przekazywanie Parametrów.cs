using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Zlozenia;

namespace ProjektUnitTests
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PrzekazywanieParametrowWartoscKlasa()
        {
            //Arrange
            Karta karta = new Karta();
            karta.Nazwa = "Marcin";
            //Act
            ustawNazwe(karta);
            //Assert
            Assert.AreEqual(karta.Nazwa, "Nowa nazwa");
        }

        private void ustawNazwe(Karta karta)
        {
            karta.Nazwa = "Nowa nazwa";
        }
        [TestMethod]
        public void PrzekazywanieParametrowWartoscInt()
        {
            //Arrange
            int x = 10;
            //Act
            zwiekszWartosc(x);
            //Assert
            Assert.AreEqual(10, x);
        }

        private int zwiekszWartosc(int x)
        {
            return x++;
        }
    }
}
