using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILAS_U2
{
    class ClasePilaDinamicaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _top;

        public ClasePilaDinamicaDesordenada()
        {
            Top = null;
        }

        private ClaseNodo<Tipo> Top
        { get { return _top; } set { _top = value; } }


        public bool Vacia
        {
            get
            {
                if(Top == null)
                { return true;  }
                return false; 
            }

        }

        public void Push(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
            if (Vacia)
            {
                
               
                nuevoNodo.ObjetoRojo = objeto;
                nuevoNodo.Siguiente = null;
                Top = nuevoNodo;
                return; 
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                if (nodoActual.ObjetoRojo.Equals(objeto))
                {
                   throw new Exception("No se acepatan duplicados ");
                 

                }
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);

          // ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
            nuevoNodo.ObjetoRojo = objeto;
            nuevoNodo.Siguiente = Top;
            Top  = nuevoNodo;

            return; 
        }

        public Tipo Pop()
        {
            if(Vacia)
            {
                throw new Exception("Esta Lista esta vacia "); 

            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
           ClaseNodo < Tipo >nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Top;
            Top = nodoActual.Siguiente;
            nodoEliminado = nodoActual;
            nodoActual = null;
            return (nodoEliminado.ObjetoRojo); 
        }
        public Tipo Pop(Tipo objeto)
        {
           
            if(Vacia)
            {
                throw new Exception("Esta Lista esta vacia "); 
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {

                if (nodoActual.ObjetoRojo.Equals(objeto))
                {
                    if(nodoActual == Top)
                    {
                        ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                        Top = nodoActual.Siguiente;
                        nodoEliminado = nodoActual;
                        nodoActual = null;
                        return (nodoEliminado.ObjetoRojo); 
                    }
                    else
                    {
                        ClaseNodo<Tipo> nodoEliminaado = new ClaseNodo<Tipo>();
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        nodoEliminaado = nodoActual;
                        nodoActual = null;
                        return (nodoEliminaado.ObjetoRojo); 
                    }

                }
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente; 

                   
            } while (nodoActual != null);
            throw new Exception("No encontro "); 

           
        }

        public Tipo BuscarNodo(Tipo objeto)
        {

            if (Vacia)
            {
                throw new Exception("Esta Lista esta Vacia ");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                //nodoActual.ObjetoRojo.Equals(objeto)
                if (nodoActual.ObjetoRojo.Equals(objeto))
                {

                    return (nodoActual.ObjetoRojo);
                }
                nodoPrevio = nodoActual; 
                nodoActual = nodoActual.Siguiente; 


            } while (nodoActual != null);
            throw new Exception("El dato no se Encuentra");
        }


        public void Vaciar()
        {
            if(Vacia)
            {
                return;  
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = null; 
                    
            } while (nodoActual != null);
            Top = null; 



        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if(Vacia)
            {
                yield break; 
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                yield return (nodoActual.ObjetoRojo);
                nodoActual = nodoActual.Siguiente; 

            } while (nodoActual != null);
            yield break; 
        }


        ~ClasePilaDinamicaDesordenada()
        {
            this.Vaciar(); 
        }
    }
}
