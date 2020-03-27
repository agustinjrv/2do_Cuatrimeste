using System;
using System.Globalization;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Entidades.SP;
using System.Data.SqlClient;

namespace SP
{
    //DESARROLLAR DENTRO DEL NAMESPACE RAIZ ENTIDADES.SP EN UN PROYECTO DE TIPO CLASS LIBRARY

    public partial class SegundoParcial: Form
    {
        private Manzana _manzana;
        private Banana _banana;
        private Durazno _durazno;
        public Cajon<Manzana> c_manzanas;
        public Cajon<Banana> c_bananas;
        public Cajon<Durazno> c_duraznos;
        private static SqlConnection conexion;
        private static SqlCommand cmd;

        public SegundoParcial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Rivola Agustin 2A.");
        }

        //Crear la siguiente jerarquía de clases:
        //Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
        //constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)
        //Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
        //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
        //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
        //Crear una instancia de cada clase e inicializar los atributos del form _manzana, _banana y _durazno. 
        


        private void btnPunto1_Click(object sender, EventArgs e)
        {
            this._manzana = new Manzana("verde", 2, "rio negro");
            this._banana = new Banana("amarillo", 5.3, "ecuador");
            this._durazno = new Durazno("rojo", 2.5, 53);
            

            MessageBox.Show(this._manzana.ToString());
            MessageBox.Show(this._banana.ToString());
            MessageBox.Show(this._durazno.ToString());

        }

        //Crear la clase Cajon<T>
        //atributos: _capacidad:int, _elementos:List<T> y _precioUnitario:double (todos protegidos)        
        //Propiedades
        //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
        //PrecioTotal:(sólo lectura) retorna el precio total del cajón (precio * cantidad de elementos).
        //Constructor
        //Cajon(), Cajon(int), Cajon(double, int); 
        //El por default: es el único que se encargará de inicializar la lista.
        //Métodos
        //ToString: Mostrará en formato de tipo string, la capacidad, la cantidad total de elementos, el precio total 
        //y el listado de todos los elementos contenidos en el cajón. Reutilizar código.
        //Sobrecarga de operador
        //(+) Será el encargado de agregar elementos al cajón, siempre y cuando no supere la capacidad del mismo.
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            this.c_manzanas = new Cajon<Manzana>(1.58, 3);
            this.c_bananas = new Cajon<Banana>(15.96, 4);
            this.c_duraznos = new Cajon<Durazno>(21.5, 1);

            this.c_manzanas += new Manzana("roja", 1, "neuquen");
            this.c_manzanas += this._manzana;
            this.c_manzanas += new Manzana("amarilla", 3, "san juan");

            this.c_bananas += new Banana("verde", 3, "brasil");
            this.c_bananas += this._banana;

            this.c_duraznos += this._durazno;

            MessageBox.Show(this.c_manzanas.ToString());
            MessageBox.Show(this.c_bananas.ToString());
            MessageBox.Show(this.c_duraznos.ToString());


        }

        
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Fruta aux = null;

            if (this._manzana.Xml("manzana.xml"))
            {
                MessageBox.Show("Manzana serializada OK");
            }
            else
            {
                MessageBox.Show("NO Serializado");
            }

            if (((IDeserializar)this._manzana).Xml("manzana.xml", out aux))
            {
                MessageBox.Show("Manzana deserializada OK");
                MessageBox.Show(((Manzana)aux).ToString());
            }
            else
            {
                MessageBox.Show("NO Deserializado");
            }

            if (this.c_manzanas.Xml("manzanas.xml"))
            {
                MessageBox.Show("Cajon de Manzanas serializado OK");
            }
            else
            {
                MessageBox.Show("NO Serializado");
            }
            

        }

        //Si se intenta agregar frutas al cajón y se supera la cantidad máxima, se lanzará un CajonLlenoException, 
        //cuyo mensaje explicará lo sucedido.
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //implementar estructura de manejo de excepciones

            try
            {
                this.c_duraznos += this._durazno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Si el precio total del cajon supera los 55 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cajon. 
        //Crear el manejador necesario para que se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total del precio del cajón en un nuevo renglón.
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            //Asociar manejador de eventos y crearlo en la clase Manejadora (de instancia).
            this.c_bananas.EventoPrecio -= new Cajon<Banana>.Precio(Manejadora<Banana>.EventoPrecio);
            this.c_bananas.EventoPrecio += new Cajon<Banana>.Precio(Manejadora<Banana>.EventoPrecio);
            this.c_bananas += new Banana("verde",5, "argentina");
            this.c_bananas += new Banana("amarilla",4, "ecuador");
        }

        //Obtener de la base de datos (sp_lab_II) el listado de frutas:
        //frutas { id(autoincremental - numérico) - nombre(cadena) - peso(numérico) - precio(numérico) }. 
        //Invocar al método ObtenerListadoFrutas.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SegundoParcial.ObtenerListadoFrutas());
        }

        //Agregar en la base de datos las frutas del formulario (_manzana, _banana y _durazno).
        //Invocar al metodo AgregarFrutas():bool
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            if (SegundoParcial.AgregarFrutas(this))
            {
                MessageBox.Show("Se agregaron las frutas a la Base de Datos");
            }
            else
            {
                MessageBox.Show("NO se agregaron las frutas a la Base de Datos");
            }
        }

        //Agregar un método de extensión a la clase Cajon que:
        //Reciba como parámetro un entero (será usado como valor del campo ID)
        //Elimine de la base de datos la fruta cuyo ID coincida con el parámetro recibido
        //Retorne un booleano que indique: 
        //TRUE, si se ha eliminado la fruta. 
        //FALSE, si no se elimino.
        //Excepción, si se probocó algún error en la base de datos
        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //implementar manejo de excepciones
            try
            {
                if (this.c_manzanas.EliminarFruta(3))
                {
                    MessageBox.Show("Se ha eliminado la fruta de la base de datos");
                }
                else
                {
                    MessageBox.Show("No se ha eliminado la fruta de la base de datos");
                }
            }
            catch (Exception)
            {
                
            }

            try
            {
                if (this.c_manzanas.EliminarFruta(3))
                {
                    MessageBox.Show("Se ha eliminado la fruta de la base de datos");
                }
                else
                {
                    MessageBox.Show("No se ha eliminado la fruta de la base de datos");
                }
            }
            catch (Exception)
            {
                
            }

            //implementar manejo de excepciones
            
            
        }


        //Obtener de la base de datos (sp_lab_II) el listado de frutas:
        //frutas { id(autoincremental - numérico) - nombre(cadena) - peso(numérico) - precio(numérico) }. 
        //Invocar al método ObtenerListadoFrutas.
        private static string ObtenerListadoFrutas()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.conexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("SELECT * FROM frutas");

                SqlDataReader sqlRead = cmd.ExecuteReader();

                while (sqlRead.Read())
                {
                    object id = sqlRead[0];
                    object nombre = sqlRead[1];
                    object peso = sqlRead[2];
                    object precio = sqlRead[3];

                    sb.AppendLine("id: " + id.ToString());
                    sb.AppendLine("Nombre: " + nombre.ToString());
                    sb.AppendLine("Peso: " + peso.ToString());
                    sb.AppendLine("Precio: " + precio.ToString());
                    sb.AppendLine();

                }
            }
            catch (Exception)
            {
                   
            }
            finally
            {
                conexion.Close();
            }
            
            return sb.ToString();
        }

        private static bool AgregarFrutas(SegundoParcial frm)
        {
            bool retorno = false;
            float numero = 10.1f;
            try
            {
                conexion = new SqlConnection(Properties.Settings.Default.conexion);
                conexion.Open();
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("INSERT INTO frutas(nombre, peso, precio)");
                cmd.CommandText += "VALUES ('" + frm._banana.Nombre + "', " + frm._banana.Peso.ToString(new CultureInfo("en-US")) + ", " + numero.ToString(new CultureInfo("en-US")) + ")";
                cmd.CommandText += String.Format("INSERT into frutas(nombre, peso, precio) values('{0}',{1},{2})", frm._banana.Nombre,frm._banana.Peso.ToString(new CultureInfo("en-US")), 20.2.ToString(new CultureInfo("en-US")));
                cmd.CommandText += String.Format("INSERT into frutas(nombre, peso, precio) values('{0}',{1},{2})", frm._durazno.Nombre, frm._durazno.Peso.ToString(new CultureInfo("en-US")), 30.3.ToString(new CultureInfo("en-US")));
                cmd.ExecuteNonQuery();
                
                retorno = true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                conexion.Close();
            }
            
            return retorno;
        }
        //Si el precio total del cajon supera los 55 pesos, se disparará el evento EventoPrecio. 
        //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cajon. 
        //Crear el manejador necesario para que se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total del precio del cajón en un nuevo renglón.


       

    }
}
