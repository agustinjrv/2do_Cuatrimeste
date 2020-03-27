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
        public void TrackingID()
        {
            Correo correo = new Correo();
            Paquete p1 = new Paquete("paquete1","123456789");
            Paquete p2 = new Paquete("paquete2","123456789");
            correo += p1;
            try
            {   correo += p2;

            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrakingIdRepetidoException));
            }
        }

    }
}
