using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Dobles
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

        private ClaseNodo<Tipo> _anterior; 

        public ClaseNodo<Tipo> Siguiente


        {
            get { return _siguiente; }
            set { _siguiente = value; }

        }

        public ClaseNodo<Tipo> Anterior
        {
            get { return _anterior; }
            set { _anterior = value;  } 
        }


        ~ClaseNodo()
        {
            ObjetoRojo = default(Tipo); 

        }








    }
}
