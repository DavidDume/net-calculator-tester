namespace net_calculator_tester
{
    public class Tests
    {

        private Calculator calc = new Calculator();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
            Assert.AreEqual(0, calc.Add(2, -2));
        }
        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(1, calc.Subtract(3, 2));
            Assert.AreEqual(0, calc.Subtract(2, 2));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(6, calc.Multiply(2, 3));
            Assert.AreEqual(-4, calc.Multiply(2, -2));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(2, calc.Divide(4, 2));
        }
    }

    public class Calculator
    {
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}