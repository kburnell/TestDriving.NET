﻿using Calculator.Service.Interfaces;

namespace Calculator.Service {

    public class CalculatorService : ICalculatorService {

        public decimal Add(decimal value1, decimal value2) {
           return value1 + value2;
        }

    }
}