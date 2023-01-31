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
    class ClaseNodo<Tipo>
    {
        private Tipo _objetoRojo;
        public ClaseNodo<Tipo> _siguiente;
        public Tipo ObjetoRojo { get { return _objetoRojo; } set { _objetoRojo = value; } }
        public ClaseNodo<Tipo> Siguiente { get { return _siguiente; } set { _siguiente = value; } }
        ~ClaseNodo() { ObjetoRojo = default(Tipo); }
    }
}
