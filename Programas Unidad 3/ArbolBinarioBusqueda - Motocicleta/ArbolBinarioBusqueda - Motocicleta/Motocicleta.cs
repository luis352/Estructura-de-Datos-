using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda___Motocicleta
{
    class Motocicleta : IEquatable<Motocicleta>, IComparable<Motocicleta>
    {
        private int _intNumeroFabricacion;

        public int NumeroFabricacion
        {
            get { return _intNumeroFabricacion; }
            set { _intNumeroFabricacion = value; }
        }


        private int _intVelocidadMaxima;

        public int VelocidadMax
        {
            get { return _intVelocidadMaxima; }
            set { _intVelocidadMaxima = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private string _strCodigoSerie;

        public string CodigoDeSerie
        {
            get { return _strCodigoSerie; }
            set { _strCodigoSerie = value; }
        }

        private char _chrVersion;

        public char Version
        {
            get { return _chrVersion; }
            set { _chrVersion = value; }
        }

        private DateTime _dtmFechaLanzamiento;

        public DateTime FechaDeLanzamiento
        {
            get { return _dtmFechaLanzamiento; }
            set { _dtmFechaLanzamiento = value; }
        }

        private bool _blnCoberturaDeDaños;

        public bool CoberturaDeDatos
        {
            get { return _blnCoberturaDeDaños; }
            set { _blnCoberturaDeDaños = value; }
        }

        private string _strRutaFoto;

        public string RutaFoto
        {
            get { return _strRutaFoto; }
            set { _strRutaFoto = value; }
        }


        public bool Equals(Motocicleta Motocicleta)
        {

            return (this.NumeroFabricacion == Motocicleta.NumeroFabricacion);

        }

        public int CompareTo(Motocicleta Motocicleta)
        {
            if (this.NumeroFabricacion > Motocicleta.NumeroFabricacion)
            {
                return 1;
            }
            if (this.NumeroFabricacion < Motocicleta.NumeroFabricacion)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {


            return "N°Fabricación: " + this.NumeroFabricacion.ToString("D4") +
                "\nVelocidad Max.: " + this.VelocidadMax +
                "\nPreio: " + this.Precio.ToString("C") +
                "\nCódigo de serie: " + this.CodigoDeSerie +
                "\nVersion: " + this.Version +

                "\nCobertura: " + (this.CoberturaDeDatos ? "Vigente" : "No") +
                "\nFecha de publicación: " + this.FechaDeLanzamiento.ToLongDateString();
        }

    }
}
