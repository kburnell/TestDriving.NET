using System;
using Calculator.Service.Interfaces;
using Calculator.Shared;

namespace Calculator.Service {

    public class CalculatorService : ICalculatorService {
        private IValidationService _validationService;

        #region << Private Fields >>


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
            decimal calculatedResult = 0;
            if (_validationService.ValidateForAdd(value1, value2)) {
                
            }
            return calculatedResult;
        }

        #endregion

    }
}