using Calculator.Service.Interfaces;
using FluentAssertions;
using NUnit.Framework;
using Rhino.Mocks;
using StructureMap;

namespace Calculator.Service.Tests.Unit {

    [TestFixture]
    public class CalculatorServiceTest {


        [Test]
        public void Add_ShouldReturn_12_When_Passed_8_And_4()
        {
            //Arrange
            const decimal input1 = 8;
            const decimal input2 = 4;
            MockRepository mockRepository = new MockRepository();
            IValidationService validationServiceMock = mockRepository.StrictMock<IValidationService>();
            validationServiceMock.Expect(x => x.ValidateForAdd(input1, input2)).Return(true).Repeat.Once();
            ObjectFactory.Initialize(x =>
            {
                x.For<ICalculatorService>().Use<CalculatorService>();
                x.For<IValidationService>().Use(validationServiceMock);
            });

            mockRepository.ReplayAll();
            ICalculatorService classUnderTest = ObjectFactory.GetInstance<ICalculatorService>();
            //Act
            var result = classUnderTest.Add(input1, input2);
            //Assert
            mockRepository.VerifyAll();
            result.Should().Be(12);
        }

    }
}