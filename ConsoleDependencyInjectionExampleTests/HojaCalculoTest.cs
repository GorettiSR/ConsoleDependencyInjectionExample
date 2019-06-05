using ConsoleDependencyInjectionExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ConsoleDependencyInjectionExampleTests
{
    [TestClass]
    public class HojaCalculoTest
    {
        #region Campos

        ICalculadora calculadoraMock;

        HojaCalculo testObject;

        #endregion

        #region Inicializacion

        [TestInitialize]
        public void TestInitialize()
        {
            calculadoraMock = Substitute.For<ICalculadora>();

            testObject = new HojaCalculo(calculadoraMock)
            {
                PrimerNumero = 2,
                SegundoNumero = 3
            };
        }

        #endregion

        #region Tests

        [TestMethod]
        public void CuandoLlamoCalcularDiferenciaEntreSumaTotalYPrimerNumero_EntoncesObtengoElResultadoCorrecto()
        {
            // Arrange.
            calculadoraMock.Sumar(2, 3).Returns(5);

            int resultadoEsperado = 3;

            // Act.
            int resultadoObtenido = testObject.CalcularDiferenciaEntreSumaTotalYPrimerNumero();

            // Assert.
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        #endregion
    }
}