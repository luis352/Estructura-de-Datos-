using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILAS_U2
{
    class ClaseNodo<Tipo>
    {
        private Tipo _objetoRojo;
        private ClaseNodo<Tipo> _siguiente;
        public Tipo ObjetoRojo

        {
            get { return _objetoRojo; }
            set { _objetoRojo = value; }
        }

        public ClaseNodo<Tipo> Siguiente


        {
            get { return _siguiente; }
            set { _siguiente = value; }

        }
        ~ClaseNodo()
        {
            ObjetoRojo = default(Tipo);
        }

    }
}
