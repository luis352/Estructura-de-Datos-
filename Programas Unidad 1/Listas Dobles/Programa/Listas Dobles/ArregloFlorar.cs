using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Dobles
{
    class ArregloFlorar : IEquatable<ArregloFlorar>
    {

        private int _intNumeroVenta;

        public int NumeroVenta
        {
            get { return _intNumeroVenta; }
            set { _intNumeroVenta = value; }
        }

        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private char _chrinicialPedido;

        public char inicialPedido
        {
            get { return _chrinicialPedido; }
            set { _chrinicialPedido = value; }
        }

        public DateTime FechaEntrega { get; set; }

        private bool _blnArtifcial;
        public bool Artificial
        {
            get { return _blnArtifcial; }
            set { _blnArtifcial = value; }
        }

        private String _strTamaño;

        public String Tamaño
        {
            get { return _strTamaño; }
            set { _strTamaño = value; }
        }

        private string _strUrlImagen;

        public string UrlImagen
        {
            get { return _strUrlImagen; }

            set
            {


                if (value == null)
                {
                    throw new Exception("Cargue la imagen  ");

                }
                else
                {
                    _strUrlImagen = value;
                }

            }



        }
        // contructor 
        public ArregloFlorar()
        {

        }

        public bool Equals(ArregloFlorar miArreglo)
        {
            if (this.NumeroVenta == miArreglo.NumeroVenta)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return
            ($"Numero de Venta {NumeroVenta}\n" + $"nombre {Nombre}\n" + $"Precio arreglo{Precio} \n" + $"Inicial de pedido  {inicialPedido} \n" + $"Fecha de entrega {FechaEntrega}  \n" + $"Son artificial {Artificial}  \n" + $"Tamaño {Tamaño}");

        }













    }
}
