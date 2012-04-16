using Calculator.Service.Interfaces;
using Calculator.Service.Tests.Unit.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Should;
using StructureMap;

namespace Calculator.Service.Tests.Unit {

    [TestClass]
    public class CalculatorServiceTest
    {

        #region << Private Fields >>

        private IValidationService _validationServiceMock;
        private MockRepository _mockRepository = new MockRepository();

        #endregion

        #region << Setup/Teardown >>

        #endregion

        #region << Add Tests >>

        [TestMethod]
        public void Add_ShouldReturn_Decimal() {
            //Arrange
            _validationServiceMock = _mockRepository.StrictMock<IValidationService>();
            _validationServiceMock.Expect(x => x.ValidateForAdd(1, 2)).Return(true).Repeat.Once();
            ObjectFactory.Initialize(x => x.For<IValidationService>().Use(_validationServiceMock));
            ICalculatorService service = new CalculatorService();
            _mockRepository.ReplayAll();
            //Act
            var result = service.Add(1, 2);
            //Assert
            //Assert.IsInstanceOfType(result, typeof (decimal));
            //Insert using Should Assertion Library (NuGet: Install-Package Should)
            _mockRepository.VerifyAll();
            result.ShouldBeType<decimal>();
        }

        #endregion
    }
}