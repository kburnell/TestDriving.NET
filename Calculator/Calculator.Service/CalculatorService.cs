using System;
using Calculator.Service.Interfaces;
using Calculator.Shared;

namespace Calculator.Service {

    public class CalculatorService : ICalculatorService {

        #region << Private Fields >>

        private IValidationService _validationService;

        #endregion

        #region << Constructors >>

        public CalculatorService() {
            _validationService = DependencyResolver.GetConcreteInstanceOf<IValidationService>();
        }

        #endregion

        #region << Public Properties >>


        #endregion

        #region << Public Methods >>

        public decimal Add(decimal value1, decimal value2) {
            if (!_validationService.ValidateForAdd(value1, value2)) throw new InvalidOperationException("Doh!");
            decimal calculatedValue = 0;
            return calculatedValue;
        }

        #endregion

    }
}