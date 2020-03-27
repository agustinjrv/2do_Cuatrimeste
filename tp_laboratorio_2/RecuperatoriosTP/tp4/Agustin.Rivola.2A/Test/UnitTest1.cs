using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// verifica que la lista de Paquetes del Correo esté instanciada
     /// </summary>
        [TestMethod]
        public void PaquetesNoEsNulo()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);

        }
        /// <summary>
        /// verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrakingIdRepetidoException))]
        public void TestMethodIDRepetido()
        {
            Paquete p1 = new Paquete("prueba1", "123456789");
            Paquete p2 = new Paquete("prueba2", "123456789");
            Correo correo = new Correo();
            correo += p1;
            correo += p2;
            Assert.Fail("Error de excepcion tracking repetido");
        }
    }

}

