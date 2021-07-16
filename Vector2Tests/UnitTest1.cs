using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vector2Tests
{
    [TestClass]
    public class Vector2Tests
    {
        [TestMethod]
        public void CreationDefault()
        {
            Assert.IsNotNull(new Vector2());
        }

        [TestMethod]
        public void CreationCopy()
        {
            Vector2 vA = new();
            vA.X = 5f;
            vA.Y = 2f;

            Vector2 vB = new(vA);
            Assert.AreNotSame(vA, vB);
            Assert.AreEqual(vA.X, vB.X);
            Assert.AreEqual(vA.Y, vB.Y);
        }

        [TestMethod]
        public void CreationWithValues()
        {
            Vector2 vA = new(5f, 2f);
            Assert.AreEqual(5f, vA.X);
            Assert.AreEqual(2f, vA.Y);
        }

        [TestMethod]
        public void LengthGetting()
        {
            Vector2 vA = new(3f, 4f);
            Assert.AreEqual(5f, vA.Length);
            Assert.AreEqual(2f, vA.Y);
        }

        [TestMethod]
        public void LengthSetting()
        {
            Vector2 vA = new(3f, 4f);
            vA.Length = 10f;
            Assert.AreEqual(6f, vA.X);
            Assert.AreEqual(8f, vA.Y);
        }

        [TestMethod]
        public void LengthSquaredGetting()
        {
            Vector2 vA = new(3f, 4f);
            Assert.AreEqual(25f, vA.LengthSquared);
            Assert.AreEqual(2f, vA.Y);
        }

        [TestMethod]
        public void LengthSquaredSetting()
        {
            Vector2 vA = new(3f, 4f);
            vA.LengthSquared = 100f;
            Assert.AreEqual(6f, vA.X);
            Assert.AreEqual(8f, vA.Y);
        }

        [TestMethod]
        public void Addition()
        {
            Vector2 vA = new Vector2(1f, 1f);
            Vector2 vB = new Vector2(2f, 2f);
            Vector2 vC = vA + vB;

            Assert.AreEqual(3f, vC.X);
            Assert.AreEqual(3f, vC.Y);
        }

        [TestMethod]
        public void AdditionAndAssign()
        {
            Vector2 vA = new(1f, 1f);
            Vector2 vB = new(2f, 2f);
            vA += vB;

            Assert.AreEqual(3f, vA.X);
            Assert.AreEqual(3f, vA.Y);
        }

        [TestMethod]
        public void Distance()
        {
            Vector2 vA = new(1f, 1f);
            Vector2 vB = new(2f, 1f);
            Assert.AreEqual(1f, vA.Distance(vB));
        }

        [TestMethod]
        public void Invert()
        {
            Vector2 vA = new(1f, 1f);
            vA.Invert();
            Assert.AreEqual(-1f, vA.X);
            Assert.AreEqual(-1f, vA.Y);
        }
    }
}
