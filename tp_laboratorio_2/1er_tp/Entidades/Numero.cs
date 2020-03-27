using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);   
            }
        }
        public static string BinarioDecimal(string binario)
        {
          
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero.ToString();
            
        }

        public static string DecimalBinario(double numero)
        {
            long entero;
            string resultado = "Valor invalido";

            if (numero > 0 && numero < double.MaxValue)
            {
                entero = (long)numero;
                resultado = "";
                while (entero != 0)
                {   
                    resultado = (entero % 2).ToString() + resultado;
                    entero /= 2;
                }
            }
            else if (numero == 0)
            {
                resultado = "0";
            }

            return resultado;
        }

        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double aux;
            if(double.TryParse(numero,out aux))
            {
                retorno = DecimalBinario(double.Parse(numero));
            }
            return retorno;
        }
        
        public Numero():this(0)
        {
            
        }

        public Numero(double numero):this(numero.ToString())
        {
            
        }
        
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            

            if(n2.numero==0)
            {
                return double.MinValue;
            }
            
            return n1.numero / n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        private static double ValidarNumero(string strNumero)
        {
            int tam = strNumero.Length;
            int i;
            bool flag=true;
            double retorno=0;

            if(tam>0)
            {
                for (i = 0; i < tam; i++)
                {
                    if (strNumero.ElementAt(i) < '0' || strNumero.ElementAt(i) > '9')
                    {
                        flag = false;
                        break;
                    }

                }
                
                if (flag)
                {
                    retorno = double.Parse(strNumero);
                }
            }
            


            return retorno;

        }
    }
}
