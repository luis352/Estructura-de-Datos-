using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda___Motocicleta
{
    class ClaseNodo<Tipo>
    {
        private Tipo _objetoConDatos;

        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private ClaseNodo<Tipo> _hijoIzquierdo;

        public ClaseNodo<Tipo> HijoIzquierdo
        {
            get { return _hijoIzquierdo; }
            set { _hijoIzquierdo = value; }
        }

        private ClaseNodo<Tipo> _hijoDerecho;

        public ClaseNodo<Tipo> HijoDerecho
        {
            get { return _hijoDerecho; }
            set { _hijoDerecho = value; }
        }

        public ClaseNodo()
        {
            HijoDerecho = null;
            HijoIzquierdo = null;
        }
        ~ClaseNodo()
        {
            this.ObjetoConDatos = default(Tipo);
        }
    }
}
