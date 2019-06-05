using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDependencyInjectionExample
{
    public interface IHojaCalculo
    {
        int PrimerNumero { get; set; }

        int SegundoNumero { get; set; }

        int CalcularDiferenciaEntreSumaTotalYPrimerNumero();

        int CalcularDiferenciaEntreSumaTotalYSegundoNumero();
    }
}
