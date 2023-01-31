using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;





namespace EDDArregloFloral
{
    class ClaseListaSimpleDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _nodoInicial;
        public ClaseListaSimpleDesordenada()
        {
            NodoInicial = null;
        }
        public bool Vacia
        {
            get
            {
                if (NodoInicial == null)
                { return true; }
                return false;
            }
        }
        private ClaseNodo<Tipo> NodoInicial
        { get { return _nodoInicial; } set { _nodoInicial = value; } }

        public void AgregarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
            if (Vacia)
            {
                nuevoNodo.ObjetoRojo = objeto;
                NodoInicial = nuevoNodo;
                nuevoNodo.Siguiente = null;

                return;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {
                if (nodoActual.ObjetoRojo.Equals(objeto))
                {
                    throw new Exception("No se aceptan duplicados");
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);

            nuevoNodo.ObjetoRojo = objeto;
            nodoPrevio.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = null;

            return;
        }

        public Tipo EliminarNodo(Tipo objeto)
        {

            if (Vacia)
            {
                throw new Exception("La lista esta Vacia");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {
                if (nodoActual.ObjetoRojo.Equals(objeto))
                {
                    ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                    nodoEliminado = nodoActual;


                    if (nodoActual == NodoInicial)
                    {
                        NodoInicial = nodoActual.Siguiente;
                        nodoActual = null;
                        return (nodoEliminado.ObjetoRojo);
                    }
                    else
                    {
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        nodoActual = null;
                        return nodoEliminado.ObjetoRojo;
                    }
                }
                 
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                               
            } while (nodoActual != null);
            throw new Exception("No esta el Objeto");

        }
        public Tipo BuscarNodo(Tipo objeto)
        {

         

            if (Vacia)
            {
                throw new Exception("No hay datos alacenados");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;

            do
            {
                //nodoActual.ObjetoRojo.Equals(objeto)
                if (nodoActual.ObjetoRojo.Equals(objeto) )
                {

                    return (nodoActual.ObjetoRojo);
                }
                nodoActual = nodoActual.Siguiente;



            } while (nodoActual != null);
            throw new Exception("El dato no se Encuentra");
        }
        public void Vaciar()
        {            
                if (Vacia)
                {
                    throw new Exception("La Lista esta vacia ");
                }

                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;

                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                   EliminarNodo(nodoPrevio.ObjetoRojo); 
                   

                } while (nodoActual != null);
                NodoInicial = null;
        }
        public IEnumerator<Tipo> GetEnumerator()
        {

            if (Vacia)
            {
                yield break;
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {
                yield return (nodoActual.ObjetoRojo);
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            yield break;

        }

        ~ClaseListaSimpleDesordenada()
        {
            this.Vaciar();
        }
    }

   

  

}
