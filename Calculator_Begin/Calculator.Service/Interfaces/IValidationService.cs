namespace Calculator.Service.Interfaces {

    public interface IValidationService {
        bool ValidateForAdd(decimal value1, decimal value2);
    }
}