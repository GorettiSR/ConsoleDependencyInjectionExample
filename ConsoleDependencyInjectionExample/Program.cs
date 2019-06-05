using System;
using Unity;

namespace ConsoleDependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer unityContainer = new UnityContainer();

            // Registro en el container las clases que quiero que me devuelva cada interfaz que use. 
            // HojaCalculo usa en su constructor la interface "ICalculadora". Aquí decimos que cuando
            // esa interface la use alguien, que a ese alguien se le de una clase "Calculadora"
            unityContainer.RegisterType<ICalculadora, Calculadora>();

            // Creamos la clase hojaCalculo
            IHojaCalculo hojaCalculo = unityContainer.Resolve<HojaCalculo>();

            // Ahora podemos hacer cosas con la hoja de calculo.
            hojaCalculo.PrimerNumero = 3;
            hojaCalculo.SegundoNumero = 2;

            int resultado = hojaCalculo.CalcularDiferenciaEntreSumaTotalYPrimerNumero();

            Console.WriteLine("La diferencia del primer numero respecto al total es: " + resultado);

            resultado = hojaCalculo.CalcularDiferenciaEntreSumaTotalYSegundoNumero();

            Console.WriteLine("La diferencia del segundo numero respecto al total es: " + resultado);
            Console.ReadKey();
        }
    }
}
