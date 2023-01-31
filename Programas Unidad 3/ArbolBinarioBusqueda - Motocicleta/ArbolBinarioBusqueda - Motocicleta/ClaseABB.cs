using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda___Motocicleta
{
    class ClaseABB<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        public void CrearArchivoDot(ref string Resultado)
        {
            if (!EstaVacio()) // Si no está vacío ...
            {
                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\nRaíz->" + Raiz.ObjetoConDatos.ToString().Substring(15,4) + ";";
                RecorrerNodos(Raiz, ref Resultado);
                Resultado = Resultado + "\n}";
            }

        }

        private void RecorrerNodos(ClaseNodo<Tipo> nodoActual, ref string Resultado)
        {
            if (nodoActual != null)
            {
                if (nodoActual.HijoIzquierdo != null)
                    Resultado = Resultado + "\n" + nodoActual.ObjetoConDatos.ToString().Substring(15, 4) + "->" + nodoActual.HijoIzquierdo.ObjetoConDatos.ToString().Substring(15, 4) + ";";
                if (nodoActual.HijoDerecho != null)
                    Resultado = Resultado + "\n" + nodoActual.ObjetoConDatos.ToString().Substring(15, 4) + "->" + nodoActual.HijoDerecho.ObjetoConDatos.ToString().Substring(15, 4) + ";";

                RecorrerNodos(nodoActual.HijoIzquierdo, ref Resultado);
                RecorrerNodos(nodoActual.HijoDerecho, ref Resultado);

            }



        }





        private ClaseNodo<Tipo> _raiz;

        public ClaseNodo<Tipo> Raiz
        {
            get { return _raiz; }
            private set { _raiz = value; }
        }



        public ClaseABB()
        {
       
            Raiz = null;
        }


        public bool Vacia
        {
            get
            {
                if (Raiz == null)
                {
                    return true;
                }
                return false;
            }

        }


        public bool EstaVacio()
        {

            if (Vacia)
            {
                return true;
            }
            return false;
        }

        public void AgregarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoNuevo = null;
            //Alta en vacio

            
            if (Vacia)
            {
                nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                Raiz = nodoNuevo;
                return;

            }

            
            ClaseNodo<Tipo> nodoActual = Raiz, nodoPadre = Raiz;


            do
            {

                //En caso duplicados
                if (nodoActual.ObjetoConDatos.Equals(objeto))
                {
                    throw new Exception("Objeto duplicado");
                }

                if (objeto.CompareTo(nodoActual.ObjetoConDatos) < 0)
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.HijoIzquierdo;
                }
                else
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.HijoDerecho;
                }

            } while (nodoActual != null);


            nodoNuevo = new ClaseNodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            if (objeto.CompareTo(nodoPadre.ObjetoConDatos) < 0)
            {
                nodoPadre.HijoIzquierdo = nodoNuevo;
            }
            else
            {
                nodoPadre.HijoDerecho = nodoNuevo;
            }



        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoActual = null, nodoPadre = null, nodoEliminado = null;

            if (Vacia)
            {
                throw new Exception("No existen datos");
            }
            nodoActual = Raiz;
            nodoPadre = Raiz;


            do
            {
                if (objeto.CompareTo(nodoActual.ObjetoConDatos) < 0)
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.HijoIzquierdo;
                }
                if (objeto.CompareTo(nodoActual.ObjetoConDatos) > 0)
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.HijoDerecho;
                }

                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    //Si es la raiz
                    if (nodoActual == Raiz)
                    {
                        nodoEliminado = nodoActual;
                        Raiz = default;
                        Raiz = null;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    //Si es una hoja
                    if (nodoActual.HijoIzquierdo == null && nodoActual.HijoDerecho == null)
                    {
                        nodoEliminado = nodoActual;
                        if (nodoActual.ObjetoConDatos.CompareTo(nodoPadre.ObjetoConDatos) < 0)
                        {
                            nodoPadre.HijoIzquierdo = null;
                        }
                        else
                        {
                            nodoPadre.HijoDerecho = null;
                        }
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;


                    }
                    //Si tiene hoja izq
                    if (nodoActual.HijoDerecho == null)
                    {
                        nodoEliminado = nodoActual;
                        if (nodoActual.ObjetoConDatos.CompareTo(nodoPadre.ObjetoConDatos) < 0)
                        {
                            nodoPadre.HijoIzquierdo = nodoActual.HijoIzquierdo;
                        }
                        else
                        {
                            nodoPadre.HijoDerecho = nodoActual.HijoIzquierdo;
                        }
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    //Si tiene hoja der
                    if (nodoActual.HijoIzquierdo == null)
                    {
                        nodoEliminado = nodoActual;
                        if (nodoActual.ObjetoConDatos.CompareTo(nodoPadre.ObjetoConDatos) < 0)
                        {
                            nodoPadre.HijoIzquierdo = nodoActual.HijoDerecho;
                        }
                        else
                        {
                            nodoPadre.HijoDerecho = nodoActual.HijoDerecho;
                        }
                        nodoActual = default;
                        return nodoEliminado.ObjetoConDatos;
                    }
                    //Si tiene ambas hojas

                    nodoEliminado = nodoActual;
                    if (nodoActual.ObjetoConDatos.CompareTo(nodoPadre.ObjetoConDatos) < 0)
                    {
                        nodoPadre.HijoIzquierdo = nodoActual.HijoIzquierdo;
                        nodoActual.HijoIzquierdo.HijoDerecho = nodoActual.HijoDerecho;
                    }
                    else
                    {
                        nodoPadre.HijoDerecho = nodoActual.HijoDerecho;
                        nodoActual.HijoDerecho.HijoIzquierdo = nodoActual.HijoIzquierdo;
                    }

                    nodoActual = default;
                    return nodoEliminado.ObjetoConDatos;

                }

            } while (nodoActual != null);
            throw new Exception("No existe el objeto");
        }
        public Tipo BuscarNodo(Tipo objeto)
        {

            if (Vacia)
            {
                throw new Exception("Datos no encontrados");
            }



            foreach (Tipo nodoActual in this.RecorrerInOrden())
            {

                if (objeto.Equals(nodoActual))
                {
                    return nodoActual;
                }

            }


            throw new Exception("El objeto no existe");

        }


        public void RecorrerYBorrar(ClaseNodo<Tipo> nodoActual)
        {

            if (nodoActual != null)
            {
                RecorrerYBorrar(nodoActual.HijoIzquierdo);
                RecorrerYBorrar(nodoActual.HijoDerecho);
                EliminarNodo(nodoActual.ObjetoConDatos);
            }

        }

        public void Vaciar()
        {

            if (Vacia)
            {
                return;
            }

            RecorrerYBorrar(Raiz);

            Raiz = null;

        }
        ~ClaseABB()
        {
            this.Vaciar();
        }

        private IEnumerable<Tipo> RecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
        {


            if (nodoActual != null)
            {

                yield return (nodoActual.ObjetoConDatos);


                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoIzquierdo))
                {
                    yield return miNodo;
                }

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDerecho))
                {
                    yield return miNodo;
                }





            }

        }

        private IEnumerable<Tipo> RecorrerInOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {


                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoIzquierdo))
                {
                    yield return miNodo;
                }

                yield return (nodoActual.ObjetoConDatos);

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDerecho))
                {
                    yield return miNodo;
                }





            }

        }

        private IEnumerable<Tipo> RecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {


                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoIzquierdo))
                {
                    yield return miNodo;
                }

                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDerecho))
                {
                    yield return miNodo;
                }

                yield return (nodoActual.ObjetoConDatos);



            }

        }

        public IEnumerable<Tipo> RecorrerInOrden()
        {
            return (this.RecorrerInOrden(this.Raiz));
        }
        public IEnumerable<Tipo> RecorrerPreOrden()
        {
            foreach (Tipo miNodo in RecorrerPreOrden(this.Raiz))
            {

                yield return miNodo;

            }

            yield break;
        }
        public IEnumerable<Tipo> RecorrerPostOrden()
        {
            foreach (Tipo miNodo in RecorrerPostOrden(this.Raiz))
            {
                yield return miNodo;
            }

            yield break;
        }






    }
}
