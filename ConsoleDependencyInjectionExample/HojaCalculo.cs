namespace ConsoleDependencyInjectionExample
{
    public class HojaCalculo : IHojaCalculo
    {
        int mPrimerNumero;
        int mSegundoNumero;

        ICalculadora mCalculadora;

        public HojaCalculo(ICalculadora calculadora) {
            mCalculadora = calculadora;
        }

        public int PrimerNumero {
            get
            {
                return mPrimerNumero;
            }

            set
            {
                if (mPrimerNumero != value)
                {
                    mPrimerNumero = value;
                }
            }
        }

        public int SegundoNumero
        {
            get
            {
                return mSegundoNumero;
            }

            set
            {
                if (mSegundoNumero != value)
                {
                    mSegundoNumero = value;
                }
            }
        }

        public int CalcularDiferenciaEntreSumaTotalYPrimerNumero()
        {
            int sumaTotal = mCalculadora.Sumar(PrimerNumero, SegundoNumero);
            int resultado = sumaTotal - PrimerNumero;

            return resultado;
        }

        public int CalcularDiferenciaEntreSumaTotalYSegundoNumero()
        {
            int sumaTotal = mCalculadora.Sumar(PrimerNumero, SegundoNumero);
            int resultado = sumaTotal - SegundoNumero;

            return resultado;
        }
    }
}
