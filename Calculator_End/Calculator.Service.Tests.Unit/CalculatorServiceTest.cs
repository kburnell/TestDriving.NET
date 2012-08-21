using Calculator.Service.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Should;
using StructureMap;

namespace Calculator.Service.Tests.Unit {

    [TestClass]
    public class CalculatorServiceTest {

        #region << Setup/Teardown >>



        #endregion

        #region << Add Tests >>

        [TestMethod]
        public void Add_ShouldReturn_Decimal() {
            //Arrange
            
            decimal val1 = 1.23m;
            decimal val2 = 3.21m;
            MockRepository mockRepository = new MockRepository();
            IValidationService validationServiceMock = mockRepository.StrictMock<IValidationService>();
            validationServiceMock.Expect(x => x.ValidateForAdd(val1, val2)).Return(true).Repeat.Once();
            ObjectFactory.Initialize(x => x.For<IValidationService>().Use(validationServiceMock));
            mockRepository.ReplayAll();
            ICalculatorService service = new CalculatorService();
            //Act
            var result = service.Add(val1, val2);
            //Assert
            mockRepository.VerifyAll();
            result.ShouldBeType<decimal>();
        }

        #endregion
    }
}