using Calculator.Service.Interfaces;

namespace Calculator.Service.Tests.Unit.Fakes {
    public class FakeValidationService : IValidationService {
        public bool ValidateForAdd(decimal value1, decimal value2) {
            return true;
        }
    }
}