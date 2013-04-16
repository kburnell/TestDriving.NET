using FluentAssertions;
using NUnit.Framework;

namespace Calculator.Service.Tests.Unit {

    [TestFixture]
    public class CalculatorServiceTest {

        [Test]
        public void Add_ShouldReturn_12_When_Passed_8_And_4()
        {
            //Arrange
            decimal input1 = 8;
            decimal input2 = 4;
            CalculatorService classUnderTest = new CalculatorService();
            //Act
            var result = classUnderTest.Add(input1, input2);
            //Assert
            result.Should().Be(12);
        }

    }
}