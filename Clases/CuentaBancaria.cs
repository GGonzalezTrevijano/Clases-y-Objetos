using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_Clases_y_Objetos
{
    class CuentaBancaria
    {
        //Propiedades automáticas
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        
        //Backing field (necesario para una propiedad completa)
        private decimal _saldo;

        //Propiedad Completa
        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                //Evitar que el saldo sea negativo
                if (value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------

        //Propiedad estática
        public static string Banco { get; set; }    //static sirve para convertir la propiedad en estatica


        #region constructores                   //region sirve para crear a la izquierda un campo en el que minimizar el código
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;        
        }

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            Saldo = saldo;        
        }
        //Constructor Vacío (default)
        public CuentaBancaria() { }
        #endregion

        //-------------------------------------------------------------------------------------------------------------------------------------

        #region Métodos de instancia
        //Métodos de instancia

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;  // No continua leyendo el código si no se cumple la condicion
            }

            Saldo -= cantidad; //Esto quiere decir Saldo = Saldo - Cantidad.
        }

        public void Depostiar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return string.Format("NoCuenta: {0}, Usuario: {1}, Saldo: {2}$", NoCuenta, Usuario, Saldo);  //Con está llamada generas un texto que luego se va a mostrar en el programa principal
        }
        #endregion

        public static void AsignarBanco(string banco)
        {
            Console.WriteLine("Asignando nuevo banco...");
            Banco = banco;
        }
    }
}
