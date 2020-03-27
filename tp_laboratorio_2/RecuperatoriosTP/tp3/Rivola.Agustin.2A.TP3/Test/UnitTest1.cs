using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;
using Archivos;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test para validar la excepcion TestNacionalidadInvalidaExceptio
        /// </summary>
        [TestMethod]
        
        public void TestNacionalidadInvalidaException()
        {
            try
            {
                Alumno a = new Alumno(2, "carlos", "gonzales", "12345678", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
        /// <summary>
        /// Test para validar la excepcion DniInvalidoExeption
        /// </summary>
        [TestMethod]
        public void DniInvalidoExeption()
        {
            try
            {
                Alumno a = new Alumno(2, "carlos", "gonzales", "1234f678", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }
        /// <summary>
        /// Valida que no sean valores nulos
        /// </summary>
        [TestMethod]
        public void NoEsNulo()
        {

            Universidad uni = new Universidad();
            Assert.IsNotNull(uni.Alumnos);
            Assert.IsNotNull(uni.Instructor);
            Assert.IsNotNull(uni.Jornadas);
        }
        /// <summary>
        /// verifica que la cantidad de alumnos sea correcta en la lista
        /// </summary>
        [TestMethod]
        public void ValidarNumerico()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "pedro", "lopez","12345678",Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(2, "santiago", "sosa", "97654321",Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            uni += a1;
            uni += a2;
            Assert.AreEqual(2, uni.Alumnos.Count);
        }

    }
}
