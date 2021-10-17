using System;
using System.Diagnostics;
using System.IO;

namespace TareaCapitulo10y12
{
    class Program
    {

        //Capitulo 10
        //Ejercicio 1 - Crear el diseño de una clase para llevar el inventario de una tienda

        class Inventario
        {
            private int productoId;
            private string nombreProducto;
            private int cantidad;
            private float precio;
            private float costo;


            public Inventario()
            {
                productoId = 0;
                nombreProducto = "";
                cantidad = 0;
                precio = 0.00f;
                costo = 0.00f;

            }

            public Inventario(int ProductoId, string NombreProducto, int Cantidad, float Precio, float Costo)
            {
                this.productoId = ProductoId;
                this.nombreProducto = NombreProducto;
                this.cantidad = Cantidad;
                this.precio = Precio;
                this.costo = Costo;

            }

            public int ProductoId
            {
                get
                {
                    return productoId;
                }

                set
                {
                    if (value <= 0)
                        productoId = 1;
                    else
                        productoId = value;
                }
            }

            public string NombreProducto
            {
                get
                {
                    return nombreProducto;
                }

                set
                {
                    nombreProducto = value;
                }
            }

            public int Cantidad
            {
                get
                {
                    return cantidad;
                }

                set
                {
                    if (value < 0)
                        cantidad = 0;
                    else
                        cantidad = value;
                }
            }

            public float Precio
            {
                get
                {
                    return precio;
                }

                set
                {
                    if (value < 0)
                        precio = 0.00f;
                    else
                        precio = value;
                }
            }

            public float Costo
            {
                get
                {
                    return costo;
                }

                set
                {
                    if (value < 0)
                        costo = 0.00f;
                    else
                        costo = value;
                }

            }


            public override string ToString()
            {
                string Mensaje = "";
                Mensaje += "ProductoId: " + ProductoId.ToString() + "\n" + "Nombre Producto: " +
                    NombreProducto + "\n" + "Cantidad: " + Cantidad.ToString() + "\n" +
                    "Precio: " + Precio.ToString() + "\n" + "Costo: " + Costo.ToString();
                return Mensaje;
            }

        }

        //Ejercicio 2 -  Crear una clase para llevar la información de los estudiantes de una escuela.
        class Estudiante
        {
            private string id;
            private string nombre;
            private string apellido;
            private DateTime fechaNacimiento;
            private int edad;
            private string tutor;
            private string telefonoTutor;
            private string centroEducativo;
            private string grado;
            private string seccion;

            public Estudiante()
            {
                id = "";
                nombre = "";
                apellido = "";
                fechaNacimiento = DateTime.Now;
                edad = 5;
                tutor = "";
                telefonoTutor = "";
                centroEducativo = "";
                grado = "";
                seccion = "";
            }

            public Estudiante(string id,
                string nombre,
                string apellido,
                DateTime fechaNacimiento,
                string tutor,
                string telefonoTutor,
                string centroEducativo,
                string grado,
                string seccion)
            {
                this.id = id;
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechaNacimiento = fechaNacimiento;
                this.tutor = tutor;
                this.telefonoTutor = telefonoTutor;
                this.centroEducativo = centroEducativo;
                this.grado = grado;
                this.seccion = seccion;
            }


            public string Id
            {
                get
                {
                    return id;
                }
                set
                {
                    if (value == "")
                        id = "Sin Asignar";
                    else
                        id = value;
                }
            }

            public string Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    if (value == "")
                        nombre = "Sin Asignar";
                    else
                        nombre = value;
                }
            }

            public string Apellido
            {
                get
                {
                    return apellido;
                }
                set
                {
                    if (value == "")
                        apellido = "Sin Asignar";
                    else
                        apellido = value;
                }
            }

            public DateTime FechaNacimiento
            {
                get
                {
                    return fechaNacimiento;
                }
                set
                {
                    fechaNacimiento = value;
                }
            }

            public int Edad
            {
                get
                {
                    return DateTime.Now.Year - fechaNacimiento.Year;
                }
            }

            public string Tutor
            {
                get
                {
                    return tutor;
                }
                set
                {
                    if (value == "")
                        tutor = "Sin Asignar";
                    else
                        tutor = value;
                }
            }

            public string TelefonoTutor
            {
                get
                {
                    return telefonoTutor;
                }
                set
                {
                    if (value == "")
                        telefonoTutor = "Sin Asignar";
                    else
                        telefonoTutor = value;
                }
            }

            public string CentroEducativo
            {
                get
                {
                    return centroEducativo;
                }
                set
                {
                    if (value == "")
                        centroEducativo = "Sin Asignar";
                    else
                        centroEducativo = value;
                }
            }

            public string Grado
            {
                get
                {
                    return grado;
                }
                set
                {
                    if (value == "")
                        grado = "Sin Asignar";
                    else
                        grado = value;
                }
            }

            public string Seccion
            {
                get
                {
                    return seccion;
                }
                set
                {
                    if (value == "")
                        seccion = "Sin Asignar";
                    else
                        seccion = value;
                }
            }

            public override string ToString()
            {
                string Mensaje = "";
                Mensaje += "Id: " + Id + "\n" + "Nombre: " + Nombre + "\n" +
                    "Apellido: " + Apellido + "\n" + "Fecha de Nacimiento: " + FechaNacimiento.ToString() + "\n" +
                    "Edad: " + Edad.ToString() + "\n" + "Tutor: " + Tutor + "\n" + "Telefono del Tutor: " + TelefonoTutor + "\n" +
                    "Centro Educativo: " + CentroEducativo + "\n" + "Grado: " + Grado + "\n" + "Seccion: " + Seccion;
                return Mensaje;
            }


        }

        //Ejercicio 3 -  Crear una clase para polígonos con sobrecarga del constructor.
        class Poligono
        {
            private int largo;
            private int ancho;
            private int alto;

            public Poligono()
            {
                largo = 0;
                ancho = 0;
                alto = 0;
            }

            public Poligono(int largo, int ancho, int alto)
            {
                this.largo = largo;
                this.ancho = ancho;
                this.alto = alto;
            }

            public int Largo
            {
                get
                {
                    return largo;
                }

                set
                {
                    if (value < 0)
                        largo = 0;
                    else
                        largo = value;
                }
            }

            public int Ancho
            {
                get
                {
                    return ancho;
                }

                set
                {
                    if (value < 0)
                        ancho = 0;
                    else
                        ancho = value;
                }
            }

            public int Alto
            {
                get
                {
                    return alto;
                }

                set
                {
                    if (value < 0)
                        alto = 0;
                    else
                        largo = value;
                }
            }

            public override string ToString()
            {
                string Mensaje = "";
                Mensaje += "Largo: " + Largo.ToString() + "\n" + "Ancho: " + Ancho.ToString() + "\n" + "Alto: " + Alto.ToString();
                return Mensaje;
            }

        }

        //Capitulo 12 - Ejercicio 1
        //Usar la depuración paso a paso para observar cómo cambia el valor de la variable en el programa del factorial.

        public static int Factorial(int n)
        {
            if (n < 2)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //Ejercicio 1 - Cap 10
            Inventario inventario = new(1, "Jeans", 25, 350.00f, 230.00f);
            Console.WriteLine("Capitulo 10 - Ejercicio 1");
            Console.WriteLine(inventario.ToString());

            //Ejercicio 2 - Cap 10
            DateTime fecha = new(1999,11,7);
            Estudiante estudiante = new("402-1093944-9", "Frankelyn", "Garcia", fecha, "Ana Marina", "829-639-5593", "Liceo Max Henriquez Ureña", "6to", "B");
            Console.WriteLine("Capitulo 10 - Ejercicio 2");
            Console.WriteLine(estudiante.ToString());

            //Ejercicio 3-5 - Cap 10
            Poligono poligono = new(3, 4, 6);
            Console.WriteLine("Capitulo 10 - Ejercicio 3-5");
            Console.WriteLine(poligono.ToString());

            //Ejercicio 1 - Cap12
            string n;
            int num;

            Console.WriteLine("Calculando Factorial de un numero");
            Console.Write("Digite el numero: ");
            n = Console.ReadLine();
            int.TryParse(n, out num);
            Console.WriteLine("El factorial es: {0}", Factorial(num));

            Debug.WriteLine("El factorial es: {0}", Factorial(num));
            
        }
    }
}
