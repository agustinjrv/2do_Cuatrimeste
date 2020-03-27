using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos = new List<Capitulo>();

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public string Autor
        {
            get
            {
                return this.autor;
            }
        }

        public int CantidadDePaginas
        {
            get
            {
                int cantidad=0;

    
                foreach(Capitulo c in capitulos)
                {
                    cantidad += c.Paginas;
                }
                
                return cantidad;
            }
        }

        public Libro(string titulo,string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public Capitulo this[int index]
        {
            get
            {
                if (index<=this.capitulos.Count && index>= 0)
                {
                    return this.capitulos[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
               

                if(index <= this.capitulos.Count && index>0)
                {
                    this.capitulos.Add(value);
                }
                else if (index == 0)
                {
                    this.capitulos.Insert(index, value);
                }
                   
                
                        
                    

                    
                        
                
            }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                int cantidad = capitulos.Count;
                return cantidad;
            }
        }

    }
}
