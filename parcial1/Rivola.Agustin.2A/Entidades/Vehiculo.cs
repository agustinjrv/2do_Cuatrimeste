using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get
            {
                if(this.velocidadMaxima==0)
                {
                    this.velocidadMaxima = generadorDeVelocidades.Next(100,280);    
                }

                return this.velocidadMaxima;
                
            }
        }

        static Vehiculo()
        {
            generadorDeVelocidades = new Random();
        }

        public Vehiculo(float precio,string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }

        public Vehiculo(string marca,EPais pais,string modelo,float precio):this(precio,modelo,new Fabricante(marca,pais))
        {

        }

        public static bool operator ==(Vehiculo a,Vehiculo b)
        {
            bool retorno = false;

            if(a.fabricante==b.fabricante && a.modelo==b.modelo)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "\nFabricante : " + this.fabricante + "\nModelo" +this.modelo+ "\nPrecio :" +this.precio.ToString()+ "\nVelocidad maxima :" +this.VelocidadMaxima.ToString();
        }








    }
}
