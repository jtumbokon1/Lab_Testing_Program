using BasicMathApp;

namespace BasicMathTest
{
    public class Tests
    {
        public BasicMath? tests; // sample testing

        [SetUp]
        public void Setup()
        {
            tests = new BasicMath();
        }

        [TearDown]
        public void TearDown()
        {
            tests = null;
        }
        // test if add method works
        [Test]
        public void Test_AddMethod()
        {
            // Arrange
            double num1 = 2;
            double num2 = 4;
            double expected = 6;

            // Act
            double actual = tests!.Add(num1, num2);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // test if subtract method works
        [Test]
        public void Test_SubtractMethod()
        {
            // Arrange
            double num1 = 2;
            double num2 = 4;
            double expected = -2;

            // Act
            double actual = tests!.Subtract(num1, num2);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // test if multiply method works
        [Test]
        public void Test_MultiplyMethod()
        {
            // Arrange
            double num1 = 2;
            double num2 = 4;
            double expected = 8;

            // Act
            double actual = tests!.Multiply(num1, num2);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // test if divide method works
        [Test]
        public void Test_DivideMethod()
        {
            // Arrange
            double num1 = 2;
            double num2 = 4;
            double expected = 0.5;

            // Act
            double actual = tests!.Divide(num1, num2);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    } // class
} // namespace