using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Dobles
{
    class ListaDobleDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {

        



        private ClaseNodo<Tipo> _nodoInicial;
        public ListaDobleDesordenada()
        {
            NodoInicial = null;
            NodoFinal = null;
        }

        private ClaseNodo<Tipo> _nodoFinal;


        public bool Vacia
        {
            get
            {
                if (NodoInicial == null && NodoFinal == null )
                { return true; }
                return false;
            }
        }



        private ClaseNodo<Tipo> NodoInicial
        { get { return _nodoInicial; } set { _nodoInicial = value; } }

        private ClaseNodo<Tipo> NodoFinal
        { get { return _nodoFinal; } set { _nodoFinal = value; } }

        // Metodos 
        public void AgregarNodo(Tipo Objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();

            if (Vacia)
            {

                nuevoNodo.ObjetoRojo = Objeto;
                NodoInicial = nuevoNodo;
                NodoFinal = nuevoNodo;
                nuevoNodo.Siguiente = null;
                nuevoNodo.Anterior = null;
                return;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {
                if (nodoActual.ObjetoRojo.Equals(Objeto))
                {
                    throw new Exception("No se aceptan duplicados");
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;




            } while (nodoActual != null);


            nuevoNodo.ObjetoRojo = Objeto;
            nodoPrevio.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = null;
            nuevoNodo.Anterior = nodoPrevio;
            NodoFinal = nuevoNodo; 
            return;


        }

        public Tipo EliminarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAuxiliar = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                nodoAnterior = NodoInicial;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoRojo))
                    {



                        //Eliminacion del unico nodo
                        if (NodoInicial == NodoFinal)
                        {
                            nodoAuxiliar = nodoActual;
                            NodoInicial = null;
                            NodoFinal = null;
                            nodoActual = null;
                            return (nodoAuxiliar.ObjetoRojo);
                        }
                        else
                        {
                            //Eliminacion al principio
                            if (nodoActual == NodoInicial)
                            {
                                nodoAuxiliar = nodoActual;
                                NodoInicial = nodoActual.Siguiente;
                                NodoInicial.Anterior = null;
                                nodoActual = null;
                                return (nodoAuxiliar.ObjetoRojo);
                            }
                            else
                            {
                                //Eliminacion al final
                                if (nodoActual == NodoFinal)
                                {
                                    nodoAuxiliar = nodoActual;
                                    NodoFinal = nodoActual.Anterior;
                                    NodoFinal.Siguiente = null;
                                    nodoActual = null;
                                    return (nodoAuxiliar.ObjetoRojo);
                                }
                                else
                                {
                                    //Eliminacion intermedia
                                    nodoAuxiliar = nodoActual;
                                    nodoAnterior.Siguiente = nodoActual.Siguiente;
                                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                                    nodoActual = null;
                                    return (nodoAuxiliar.ObjetoRojo);
                                }
                            }
                        }
                    }
                    else
                    {
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("El objeto a buscar no existe");
            }

        }

        public  Tipo  BuscarNodo(Tipo objeto)
        {
            
            if(Vacia)
            {
                throw new Exception("No hay datos almacenados"); 

            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = NodoInicial;

            do
            {
                if(nodoActual.ObjetoRojo.Equals(objeto))
                {
                    return nodoActual.ObjetoRojo; 

                }

                nodoActual = nodoActual.Siguiente; 

            } while(nodoActual != null);
            throw new Exception("El dato no se encuentra"); 

            
            

            



        }

        public void  Vaciar()
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
            return; 
        }


        public IEnumerable<Tipo> HaciaAdelante
        {
            get
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
                {
                    yield break;
                }
            }
        }


        public IEnumerable<Tipo> HaciaAtras
        {
            get
            {

                if (Vacia)
                {

                    yield break;
                }
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoFinal;

                do
                {

                    yield return  ((Tipo)nodoActual.ObjetoRojo);
                    nodoActual = nodoActual.Anterior;

                } while ( nodoActual != null);
                {
                    yield break;
                }
            }
        }

        ~ListaDobleDesordenada()
        {
            this.Vaciar();
        }


    }
}
