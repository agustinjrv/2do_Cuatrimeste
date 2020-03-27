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

    [TestMethod]
    public void EsNulo()
    {

            Universidad uni = new Universidad();

            Assert.IsNull(a.Nombre);
            Assert.IsNull(a.Nombre);
            Assert.IsNull(a.Nombre);



        }

    }
}
