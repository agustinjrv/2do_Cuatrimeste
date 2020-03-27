using System;

namespace Clases_4.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return this.entero.ToString() +"---"+ this.cadena + "---" + this.fecha.ToString();
        }

        public void EstablecerValor(int number)
        {
            this.entero = number;

        }

        public void EstablecerValor(string str)
        {
            this.cadena= str;
        }

        public void EstablecerValor(DateTime date)
        {
            this.fecha = date;
        }

        public Cosa()
        {          
            this.entero = -1;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string str):this()
        {
            this.cadena = str;
        }

        public Cosa(string str,DateTime date):this(str)
        {
            this.fecha = date;
        }

        public Cosa(string str, DateTime date,int number):this(str,date)
        {
            this.entero = number;
        }

    }
}
