using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Service;
using Calculator.Service.Interfaces;
using StructureMap;

namespace Calculator.Console
{
    public static class BootStrapper {
        public static void Bootstrap() {
            ObjectFactory.Initialize(x => { x.For<IValidationService>().Use<ValidationService>(); });
        }
    }
}
