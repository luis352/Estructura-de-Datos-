using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Examen_Base
{

   class Vehiculo : IEquatable<Vehiculo>

    {

        private string _strPlacas;

        public string Placas
        {
            get { return _strPlacas; }
            set { _strPlacas = value; }
        }



        private int  _intModelo;

        public int Modelo
        {
            get { return _intModelo; }
            set { _intModelo = value; }
        }


        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }


        private int _intCapacidad;

        public int Capacidad
        {
            get { return _intCapacidad; }
            set { _intCapacidad = value; }
        }


        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }



        private DateTime _dtmIngresoEstacionamiento;
        

        public DateTime ingresoEstacionamiento
        {
            get { return _dtmIngresoEstacionamiento; }
            set { _dtmIngresoEstacionamiento = value; }
        }


      public  Vehiculo()
        {


        }


        public bool Equals(Vehiculo miVehiculo)
        {
            if (this.Placas == miVehiculo.Placas) { return true; }
            return false;
        }


        public override string ToString()
        {


            return ($"Numero placas {Placas}\n" +
                            $"nombre: {Nombre}\n" +
                            $"capacidad  {Capacidad} \n" +
                            $" modelo   {Modelo} \n" +
                            $"tipo {Tipo }\n" +
                            $" ingreso a estacionamiento {ingresoEstacionamiento}");





        }















    }













}
