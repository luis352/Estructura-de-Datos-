using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    class ClaseNodo<Tipo>
    {

        private Tipo _objetoRojo;
        
        private ClaseNodo<Tipo> _Hijoizq;
        private ClaseNodo<Tipo> _HijoDer;

       public ClaseNodo()
        {
            Hijoizq = null;
            HijoDer = null; 
            
        }
        public Tipo ObjetoRojo

        {
            get { return _objetoRojo; }
            set { _objetoRojo = value; }
        }

        public ClaseNodo<Tipo> Hijoizq
        {
            get { return _Hijoizq; }
            set { _Hijoizq = value; }

        }

        public ClaseNodo<Tipo> HijoDer
        {
            get { return _HijoDer;  }
            set { _HijoDer = value;  }
        }
     
        ~ClaseNodo()
        {
            ObjetoRojo = default(Tipo);
        }



    }
}
