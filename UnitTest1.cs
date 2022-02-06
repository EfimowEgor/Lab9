using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Money m1 = new Money(0, 0);
            // Act
            Money m2 = new Money();
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestMoneyStaticMinus()
        {
            // Arrange
            Money m1 = new Money(10, 113);
            Money m2 = new Money(8, 11);
            Money res = new Money(3, 2);
            // Act
            m1 = Money.Minus(m1, m2);
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestMoneyStaticMinusNegative()
        {
            // Arrange
            Money m1 = new Money(7, 100);
            Money m2 = new Money(9, 11);
            Money res = new Money(0, 0);
            // Act
            m1 = Money.Minus(m1, m2);
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestMoneyMinus()
        {
            // Arrange 
            Money m1 = new Money(7, 99);
            Money m2 = new Money(2, 99);
            Money res = new Money(5, 0);
            // Act
            m1 = m1.Minus(m2);
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestMoneyMinusNegative()
        {
            // Arrange 
            Money m1 = new Money(1, 0);
            Money m2 = new Money(1, 1);
            Money res = new Money();
            // Act
            m1 = m1.Minus(m2);
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestIncrementOverload()
        {
            // Arrange
            Money m1 = new Money(0, 99);
            Money m2 = new Money(1, 0);
            // Act
            m1++;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestDecrementOverload()
        {
            // Arrange 
            Money m1 = new Money(1, 0);
            Money m2 = new Money(0, 99);
            // Act
            m1--;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestDecrementOverloadNegative()
        {
            // Arrange
            Money m1 = new Money();
            Money res = new Money(0, 0);
            // Act
            m1--;
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestImplicitConverse()
        {
            // Arrange
            Money m1 = new Money(12, 345);
            int res = 15;
            // Act
            int ans = m1;
            // Assert
            Assert.AreEqual(res, ans);
        }
        [TestMethod]
        public void TestExplicitConverse()
        {
            // Arrange
            Money m1 = new Money(12, 345);
            double res = 0.45;
            // Act
            double ans = (double)m1;
            // Assert
            Assert.AreEqual(res, ans);
        }
        [TestMethod]
        public void TestMinusNumberMoneyRight()
        {
            // Arrange
            Money m1 = new Money(9, 18);
            int n = 213;
            Money m2 = new Money(7, 5);
            // Act
            m1 = m1 - n;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestMinusNumberMoneyRightNegative()
        {
            // Arrange
            Money m1 = new Money(12, 96);
            int n = 1300;
            Money m2 = new Money(0, 0);
            // Act
            m1 = m1 - n;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestMinusNumberMoneyLeft()
        {
            // Arrange 
            Money m1 = new Money(8, 33);
            int n = 900;
            Money m2 = new Money(0, 67);
            // Act
            m1 = n - m1;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestMinusNumberMoneyLeftNegative()
        {
            // Arrange 
            Money m1 = new Money(10, 112);
            int n = 700;
            Money m2 = new Money(0, 0);
            // Act
            m1 = n - m1;
            // Assert
            Assert.AreEqual(m1, m2);
        }
        [TestMethod]
        public void TestMinusMoneyBoth()
        {
            // Arrange
            Money m1 = new Money(10, 123);
            Money m2 = new Money(4, 13);
            Money res = new Money(7, 10);
            // Act
            m1 = m1 - m2;
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestMinusMoneyBothNegative()
        {
            // Arrange
            Money m1 = new Money(8, 123);
            Money m2 = new Money(10, 0);
            Money res = new Money(0, 0);
            // Act
            m1 = m1 - m2;
            // Assert
            Assert.AreEqual(m1, res);
        }
        [TestMethod]
        public void TestFindMax()
        {
            // Arrange
            MoneyArr test = new MoneyArr(5);
            Money res = new Money(834, 53);
            Money ans = new Money();
            // Act
            ans = test.FindMax();
            // Assert
            Assert.AreEqual(ans, res);
        }
        [TestMethod]
        public void TestInd()
        {
            //
            // Arrange
            Money res = new Money(761, 64);
            MoneyArr test = new MoneyArr(5);
            Money m1 = new Money();
            // Act
            m1 = test[0];
            // Assert
            Assert.AreEqual(res, m1);
        }
    }
}
