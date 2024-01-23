using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFollentiSP1
{
    public class Archivo
    {
        //propiedades
        public string NombreArchivo { get; set; }
        //metodos
        //recibirá un objeto de tipo Repuesto y devolverá un valor booleano para informar el resultado de la grabación.
        public bool GrabarRepuestos(Repuesto repuesto)
        {
            // recibe un objeto de tipo Repuesto y lo graba en el archivo
            bool resultado = false;
            if (NombreArchivo != "")
            {
                // crea el stream en modo append
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                // graba la linea con los valores de los campos
                sw.WriteLine(repuesto.codigo + "," +
                repuesto.nombre + "," +
                repuesto.marca + "," +
                repuesto.precio.ToString("#.00", CultureInfo.InvariantCulture) +
                "," +
                repuesto.origen);
                sw.Close(); // cerrar el stream
                sw.Dispose(); // liberar los recursos
                resultado = true;
            }
            return resultado;
        }
        /* recibe el código del repuesto que se quiere buscar y devuelve verdadero si ese código ya existe en el archivo de
        repuestos, en caso contrario devolverá falso.Este método nos permitirá controlar que no se graben repuestos con código repetido.*/
        public bool BuscarCodigoRepuesto(string codigo) 
        {
            // recibe el código del repuesto a buscar
            // devuelve falso si el código no existe en el archivo
            // devuelve verdadero si el código ya está grabado
            bool resultado = false;
            string Linea;
            string CodigoRepuesto;
            // verificar que el archivo existe
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                // crear el stream en modo lectura
                StreamReader sr = new StreamReader(NombreArchivo);
                // leer hasta el final
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea completa
                                           // el código está en el primer valor de cada línea
                    CodigoRepuesto = Linea.Split(',')[0];
                    // comparar el código buscado con el del archivo
                    if (codigo == CodigoRepuesto)
                    {
                        // si son iguales devuelve verdadero
                        resultado = true;
                        break; // sale del ciclo de lectura
                    }
                }
                sr.Close(); // cerrar el stream
                sr.Dispose(); // liberar los recursos
            }
            return resultado;

        }
        //debe leer el archivo completo y devolver una lista(List<Repuesto>) de objetos Repuesto.
        public List<Repuesto> ObtenerRepuestos() 
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos 'Repuesto'
            List<Repuesto> Lista = new List<Repuesto>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea del archivo
                    // crea un objeto 'Repuesto' y rellena sus propiedades
                    Repuesto repuesto = new Repuesto();
                    repuesto.codigo = Linea.Split(',')[0];
                    repuesto.nombre = Linea.Split(',')[1];
                    repuesto.marca = Linea.Split(',')[2];
                    // el valor decimal se formatea sin formatos regionales
                    // para mantener el punto como separador decimal
                    repuesto.precio =decimal.Parse(Linea.Split(',')[3], CultureInfo.InvariantCulture);
                    repuesto.origen = Linea.Split(',')[4];
                    Lista.Add(repuesto); // se agrega el repuesto a la lista
                }
                sr.Close(); // cerrar
                sr.Dispose(); // liberar recursos
            }
            // devuelve la lista de repuestos completa
            return Lista;
        }
        //la lista estará ordenada por el campo Nombre de repuesto, también devolverá una lista de objetos Repuesto.
        public List<Repuesto> ObtenerRepuestosOrdenados()
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos 'Repuesto'
            List<Repuesto> Lista = ObtenerRepuestos();
            // convertir la lista en un arreglo con el método "ToArray()"
            Repuesto[] repuestosArray = Lista.ToArray();
            // ordenar el arreglo con el método de Burbuja
            // por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < repuestosArray.Length - 1; i++)
            {
                for (int j = 0; j < repuestosArray.Length - 1; j++)
                {
                    // se comparan los nombres de los repuestos
                    // usando el método 'Compare' de la clase string
                    if (string.Compare(repuestosArray[j].nombre,
                    repuestosArray[j + 1].nombre) > 0)
                    {
                        // se intercambian si el nombre en j es mayor al nombre en j+1
                        Repuesto aux = repuestosArray[j];
                        repuestosArray[j] = repuestosArray[j + 1];
                        repuestosArray[j + 1] = aux;
                    }
                }
            }
            // convertir el arreglo ya ordenado en una lista
            List<Repuesto> Ordenados = repuestosArray.ToList<Repuesto>();
            // devuelve la lista de respuestos ordenada por nombre en forma ascendente
            return Ordenados;
        }

    }
}
