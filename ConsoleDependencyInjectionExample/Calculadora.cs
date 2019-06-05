namespace ConsoleDependencyInjectionExample
{
    public class Calculadora : ICalculadora
    {
        public int Sumar(int a, int b)
        {
            int resultado = a + b;

            return resultado;
        }
    }
}
