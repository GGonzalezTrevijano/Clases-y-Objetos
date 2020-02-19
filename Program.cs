using System;

namespace Proyecto2_Clases_y_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJETOS

            //Crear un objeto de tipo rectangulo

            Console.WriteLine("Creación de Objetos");
                
            Console.Write("\r\n");

            Rectangulo rec = new Rectangulo();
            rec.Base = 10;
            rec.Altura = 5;

            int area = rec.CalcularArea();

            Console.WriteLine("El area del Rectangulo con Base {0} y Altura {1} es = {2}", rec.Base, rec.Altura, area);

            //-------------------------------------------------------------------------------------------------------------------------------------

            //Otra forma de crear un objeto
            Rectangulo rec2 = new Rectangulo { Base = 3, Altura = 8 };

            int area2 = rec2.CalcularArea();
               
            Console.WriteLine("El area del Rectangulo con Base {0} y Altura {1} es = {2}", rec2.Base, rec2.Altura, area2);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //CONSTRUCTORES

            Console.WriteLine("Creación de Constructores");

            Console.Write("\r\n");

            CuentaBancaria cuenta1 = new CuentaBancaria("01", "Juan Guaido", 5000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                cuenta1.Usuario, cuenta1.Saldo);

            CuentaBancaria cuenta2 = new CuentaBancaria("02", "Guillermo Gonzalez", 10000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);

            Console.Write("\r\n");

            Console.WriteLine("Prueba de Propiedades");

            Console.Write("\r\n");

            CuentaBancaria cuenta3 = new CuentaBancaria();

            cuenta3.Saldo = -5; 
            Console.WriteLine("El Saldo es: {0}", cuenta3.Saldo);

            cuenta3.Saldo = 10;
            Console.WriteLine("El Saldo tras el ingreso es: {0}", cuenta3.Saldo);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //Metodos de Instancia

            Console.WriteLine("Prueba de Metodos de instancia");

            Console.Write("\r\n");

            CuentaBancaria cuenta4 = new CuentaBancaria("03", "Santiago Abascal", 5000);
            CuentaBancaria cuenta5 = new CuentaBancaria("04", "Pablo Iglesias", 1000);

            Console.WriteLine("Depostiar $50 euros en cuenta4");
            cuenta4.Depostiar(50);  //Ingresa 50 euros en la cuenta4

            Console.WriteLine("Retirar $20 euros en cuenta5");
            cuenta5.Retirar(20);    //Retira 20 euros en la cuenta5

            Console.Write("\r\n");

            Console.WriteLine(cuenta4.ToString());  //La llamada ToString imprime la cadena creada en la clase con los valores asigados a esta.
            Console.WriteLine(cuenta5.ToString());

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //Miembros estáticos

            //Para acceder a los miembros estáticos se usa solo el nombre de la clase

            Console.WriteLine("Prueba de Métodos estaticos");

            Console.Write("\r\n");

            CuentaBancaria.Banco = "Mi banco";

            Console.WriteLine(cuenta4);
            Console.WriteLine(cuenta5);

            Console.Write("\r\n");

            Console.WriteLine("Cambiando el banco...");

            Console.Write("\r\n");

            CuentaBancaria.AsignarBanco("Otro banco");

            Console.Write("\r\n");

            Console.WriteLine(cuenta4);
            Console.WriteLine(cuenta5);
        }
    }
}
