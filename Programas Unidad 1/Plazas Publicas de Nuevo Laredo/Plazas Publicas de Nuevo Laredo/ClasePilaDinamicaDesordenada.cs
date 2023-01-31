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
    class ClasePilaDinamicaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _top;

        public ClasePilaDinamicaDesordenada()
        {
            Top = null;
        }

        public bool Vacia  { get { if (Top == null) { return true; } return false; }  }

        private ClaseNodo<Tipo> Top { get { return _top; } set { _top = value; } }

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
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;

                do
                {
                    if (nodoActual.ObjetoRojo.Equals(objeto)) { throw new Exception("No se Aceptan Duplicados"); }
                    nodoActual = nodoActual.Siguiente;

                } while (nodoActual != null);
            }
            nuevoNodo.ObjetoRojo = objeto;
            nuevoNodo.Siguiente = Top;
            Top = nuevoNodo;
            return;
        }

        public Tipo Pop()
        {
            if (Vacia) { throw new Exception("La Pila esta Vacia"); }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Top;
                Top = nodoActual.Siguiente;
                nodoEliminado = nodoActual;
                nodoActual = null;
                return (nodoEliminado.ObjetoRojo);
            }
        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia) { throw new Exception("La Pila esta Vacia"); }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    if (nodoActual.ObjetoRojo.Equals(objeto))
                    {
                        if (nodoActual == Top)
                        {
                            nodoEliminado = nodoActual;
                            Top = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoRojo);
                        }
                        else
                        {
                            nodoEliminado = nodoActual;
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoRojo);
                        }
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontro el Objeto");
            }
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia) { throw new Exception("No hay datos alacenados"); }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;

            do
            {
                if (objeto.Equals(nodoActual.ObjetoRojo)) { return (nodoActual.ObjetoRojo); }
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            throw new Exception("El dato no se Encuentra");
        }

        public void Vaciar()
        {
            if (Vacia) { throw new Exception("La Lista ya esta Vacia"); }

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
            return;
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia) { yield break; }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Top;
                do
                {
                    yield return (nodoActual.ObjetoRojo);
                    nodoActual = nodoActual.Siguiente;

                } while (nodoActual != null);
                yield break;
            }
        }

        ~ClasePilaDinamicaDesordenada() { this.Vaciar(); }
    }
}
