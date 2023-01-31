using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Plazas_Publicas_de_Nuevo_Laredo
{
    class PlazaPublica : IEquatable<PlazaPublica>
    {
        private int _intNumeroSector;
        private double _dblPresupuesto;
        private string _strNombre;
        private char _chrCantMonumentos;
        private DateTime _dtmFechaApertura;
        private bool _blnCerrado;
        private string _strRutaImagen;
        private string _strTipoCancha;
        private DateTime _dtmHoraEntrada;

        public int NumeroSector { get { return _intNumeroSector; } set { _intNumeroSector = value; } }
        public double Presupuesto { get { return _dblPresupuesto; } set { _dblPresupuesto = value; } }
        public string Nombre { get { return _strNombre; } set { _strNombre = value; } }
        public char CantMonumentos { get { return _chrCantMonumentos; } set { _chrCantMonumentos = value; } }
        public DateTime FechaApertura { get { return _dtmFechaApertura; } set { _dtmFechaApertura = value; } }
        public bool Cerrado { get { return _blnCerrado; } set { _blnCerrado = value; } }
        public string RutaImagen { get { return _strRutaImagen; } set { if (value == null) { throw new Exception("La ruta no puede estar vacia"); } else { _strRutaImagen = value; } } }
        public string TipoCancha { get { return _strTipoCancha; } set { _strTipoCancha = value; } }
        public DateTime HoraEntrada { get { return _dtmHoraEntrada; } set { _dtmHoraEntrada = value; } }

        public PlazaPublica() {  }

        public bool Equals(PlazaPublica miPlaza)
        {
            if (this.NumeroSector == miPlaza.NumeroSector) { return true; }
            return false;
        }

        public int CalcularTiempo()
        {
            TimeSpan Tiempo = new TimeSpan();
            Tiempo = DateTime.Now - this.HoraEntrada;
            return Convert.ToInt32(Tiempo.TotalMinutes);
        }

        public override string ToString()
        {
            string Desicion; if (Cerrado == true) { Desicion = "Si"; } else { Desicion = "No"; }

            return ($"Numero de Sector {NumeroSector}\n" +
                        $"Presupuesto de Plaza {Presupuesto}\n" +
                        $"Nombre de Plaza {Nombre} \n" +
                        $"Cantidad de Monumentos {CantMonumentos} \n" +
                        $"Fecha de Apertura {FechaApertura}  \n" +
                        $"Esta Cerrado{Desicion}  \n" +
                        $"Tipo de Cancha {TipoCancha}");
        }

        ~PlazaPublica() {  }
    }
}
