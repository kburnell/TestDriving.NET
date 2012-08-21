using Calculator.Service;

namespace Calculator.Console {
    class Program {

        private static decimal _value1;
        private static decimal _value2;
        private static CalculatorService _calculatorService;

        static void Main(string[] args) {
            //_calculatorService = new CalculatorService();
            System.Console.Write("Value 1: ");
            _value1 = decimal.Parse(System.Console.ReadLine());
            System.Console.Write("Value 2: ");
            _value2 = decimal.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Calculated Value: " + _calculatorService.Add(_value1, _value2));
            System.Console.ReadKey();
        }
    }
}