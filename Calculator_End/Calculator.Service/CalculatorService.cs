using System;
using Calculator.Service.Interfaces;

namespace Calculator.Service {

    public class CalculatorService : ICalculatorService {

        private readonly IValidationService _validationService;

        public CalculatorService(IValidationService validationService) {
            _validationService = validationService;
        }

        public decimal Add(decimal value1, decimal value2) {
            if (!_validationService.ValidateForAdd(value1, value2)) throw new Exception("DOH");
           return value1 + value2;
        }

    }
}