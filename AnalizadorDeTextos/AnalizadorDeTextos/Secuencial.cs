using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnalizadorDeTextos
{
    public class Secuencial
    {
        //Variables Globales
        // Secuencial
        public ArrayList S_Perfiles, S_Compras, S_Clientes;

        //Constructor(es)
        public Secuencial()
        {
            S_Perfiles = new ArrayList();
            S_Compras = new ArrayList();
            S_Clientes = new ArrayList();

        }
        // Metodos 

        //Agregar perfil
        public void addPerfil(string per)
        {
            this.S_Perfiles.Add(per);
        }

        //Agregar Compra
        public void addCompra(string com)
        {
            this.S_Compras.Add(com);
        }

        public string getCompra()
        {
            for (int x = 0; x < S_Compras.Count; x++)
            {

                string fech = ((string)S_Compras[x]).Split(',')[6];
                return (string)S_Compras[x];


            }
            return null;
        }

        //Agregar Cliente
        public void addCliente(string cli)
        {
            this.S_Clientes.Add(cli);
        }

        public string getCliente(string cedula)
        {
            for (int x = 0; x < S_Clientes.Count; x++)
            {

                string ced = ((string)S_Clientes[x]).Split(',')[0];
                if (ced.Equals(cedula))
                {
                    return (string)S_Clientes[x];

                }

            }
            return null;
        }


        //
        public bool cargarPerfiles(string fichero)
        {
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            addPerfil(linea);

                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        public bool cargarCompras(string fichero)
        {
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            addCompra(linea);

                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        public bool cargarCliente(string fichero)
        {
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            addCliente(linea);

                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        //
        public string sigFecha(string fecha, int diaF, int mesF, int annoF)
        {
            string[] elementos = fecha.Split('/');
            int d, m, a;
            // Conversion numerica
            try
            {

                d = Int32.Parse(elementos[0]);
                m = Int32.Parse(elementos[1]);
                a = Int32.Parse(elementos[2]);
                d++;
                if (d == 32)
                {
                    d = 1;
                    m++;
                    if (m == 13)
                    {
                        m = 1;
                        a++;
                    }

                }
                if(d==diaF+1 && m==mesF && a == annoF) { return null; }
                return (int)d + "/" + (int)m + "/" + (int)a;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        //
        public string mayorCompra(string fecha, int Fdia, int Fmes, int Fanno)
        {
            string cliente = null; // lo colocamos null para utilizar validaciones en la llamada al metodo
            int mayor = 0; //mayor compra

            do
            {
                // Creamos un array de string de una compra


                foreach (string elemento in S_Compras)
                {
                    string[] compra = elemento.Split(',');    // Separamos segun comas y almacenamos en un Array de strings
                    int Valorcompra = Int32.Parse(compra[5]); // extraemos el monto maximo de una compra
                    string fechaCompra = compra[6];           // Extraemos la fecha de compra.  
                    if (mayor < Valorcompra && fecha == fechaCompra)
                    {
                        Console.WriteLine("M: " + mayor + " ValorCompra: " + Valorcompra);
                        mayor = Valorcompra; // Si el mayor ya no es mayor, sustituimos mayor
                        cliente = getCliente(compra[1]); // localizamos al cliente segun cedula utilizando el metodo respectivo
                                                         //Console.WriteLine("Cli: "+cliente+"  ValorC"+Valorcompra);
                    }
                }
                fecha = sigFecha(fecha, Fdia, Fmes, Fanno); // Probamos con la siguiente fecha avanzando dia a dia
            }while (fecha != null) ; // Cuando la fecha de inicio sobrepase en 1 dia a la fecha final retornara null siendo el punto de parada.
            return cliente; // Finalmente retornamos el cliente.
            Console.WriteLine(cliente);
        }
    }
}
        
    

