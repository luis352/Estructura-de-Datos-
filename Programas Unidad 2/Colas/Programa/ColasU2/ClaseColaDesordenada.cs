using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasU2
{
    class ClaseColaDinamicaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {

        private ClaseNodo<Tipo> _frente;
        private ClaseNodo<Tipo> _final; 

        public ClaseColaDinamicaDesordenada()
        {
            Final = null;
            Frente = null; 
            
        }

        private ClaseNodo<Tipo> Frente
        { get { return _frente; } set { _frente = value; } }

        private ClaseNodo<Tipo> Final
        { get { return _final; } set { _final = value; } }


        public bool Vacia
        {
            get
            {
                if (Frente == null && Final == null  )
                { return true; }
                return false;
            }

        }

        public void Encolar(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>(); 
            if (Vacia)
            {
                nuevoNodo.ObjetoRojo = objeto;
                Frente = nuevoNodo;
                Final = nuevoNodo;
                nuevoNodo.Siguiente = null;
                return; 
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            do
            {
                if(nodoActual.ObjetoRojo.Equals(objeto))
                {
                    throw new Exception("No se Aceptan datos duplicados "); 


                }
                nodoActual = nodoActual.Siguiente; 


            } while (nodoActual!= null );

            nuevoNodo.ObjetoRojo = objeto;
            Final.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = null;
            Final = nuevoNodo; 



        }

        public Tipo Desencolar()
        {
            
            if (Vacia)
            {
                throw new Exception("Esta Lista esta vacia ");
            }
           
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();

            if(Frente == Final)
            {
                nodoEliminado = Frente;
                Frente = null;
                Final = null; 
            }
            else
            {
                ClaseNodo<Tipo> Nuevonodo = new ClaseNodo<Tipo>();
                Nuevonodo = Frente;
                Frente = Nuevonodo.Siguiente;
                nodoEliminado = Nuevonodo;
                Nuevonodo = null; 
            }
            return (nodoEliminado.ObjetoRojo); 
        }


        public Tipo Desencolar(Tipo objeto)
        {

            if (Vacia) { throw new Exception("La Cola esta Vacia"); }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                nodoPrevio = Frente;
                do
                {
                    if (nodoActual.ObjetoRojo.Equals(objeto))
                    {
                        if (Frente == Final)
                        {
                            //Eliminacion del Unico Nodo
                            nodoEliminado = nodoActual;
                            Frente = null;
                            Final = null;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoRojo);
                        }
                        else
                        {
                            if (nodoActual == Frente)
                            {
                                //Eliminacion del Nodo al Principio
                                nodoEliminado = nodoActual;
                                Frente = nodoActual.Siguiente;
                                nodoActual = null;
                                return (nodoEliminado.ObjetoRojo);
                            }
                            else
                            {
                                if (nodoActual == Final)
                                {
                                    //Eliminacion del Nodo al Final
                                    nodoEliminado = nodoActual;
                                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                                    nodoActual = null;
                                    Final = nodoPrevio;
                                    return (nodoEliminado.ObjetoRojo);
                                }
                                else
                                {
                                    //Eliminacion al Nodo Intermedio
                                    nodoEliminado = nodoActual;
                                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                                    nodoActual = null;
                                    return (nodoEliminado.ObjetoRojo);
                                }
                            }
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

        public Tipo Buscar(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Esta Lista esta Vacia ");
            }
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Frente;

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
            if (Vacia)
            {
                throw   new Exception("La Lista esta Vacia "); 
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            nodoActual = Frente;


            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = null;
                
            } while (nodoActual != null);
            Frente = null;
            Final = null; 
            return; 

        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Frente;

            do
            {
                yield return (nodoActual.ObjetoRojo);
                nodoActual = nodoActual.Siguiente;

            } while (nodoActual != null);
            yield break;
        }


        ~ClaseColaDinamicaDesordenada()
        {
            this.Vaciar();
        }



    }
}
