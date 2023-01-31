using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace ABB
{
    class ClaseABB<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {

        private ClaseNodo<Tipo> _raiz;

        private ClaseNodo<Tipo> Raiz
        { get { return _raiz; } set { _raiz = value; } }

        public ClaseABB()
        {
            Raiz = null;
        }

        public bool Vacia
        {
            get
            {
                if (Raiz == null)
                { return true; }
                return false;
            }

        }

        public void AgregarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoNuevo = null;
            //Alta en vacio
            if (Vacia)
            {
                nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoRojo = objeto;
                nodoNuevo.Hijoizq = null;
                nodoNuevo.HijoDer = null;
                Raiz = nodoNuevo;

                return;



            }
            ClaseNodo<Tipo> nodoActual = Raiz, nodoPadre = Raiz;
            do
            {

                //En caso duplicados
                if (nodoActual.ObjetoRojo.Equals(objeto))
                {
                    throw new Exception("Objeto duplicado");
                }
                if (objeto.CompareTo(nodoActual.ObjetoRojo) < 0)
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.Hijoizq;
                }
                else
                {
                    nodoPadre = nodoActual;
                    nodoActual = nodoActual.HijoDer;
                }

            } while (nodoActual != null);

            nodoNuevo = new ClaseNodo<Tipo>();
            nodoNuevo.ObjetoRojo = objeto;
            if (objeto.CompareTo(nodoPadre.ObjetoRojo) < 0)
            {
                nodoPadre.Hijoizq = nodoNuevo;
            }
            else
            {
                nodoPadre.HijoDer = nodoNuevo;
            }

        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> padre = new ClaseNodo<Tipo>();
                nodoActual = Raiz;
                padre = null;
                while (objeto.Equals(nodoActual.ObjetoRojo) == false)
                {
                    padre = nodoActual;
                    if (objeto.CompareTo(nodoActual.ObjetoRojo) < 0)
                    {
                        nodoActual = nodoActual.Hijoizq;
                    }
                    else
                    {
                        nodoActual = nodoActual.HijoDer;
                    }
                }
                if (nodoActual == null)
                {
                    throw new Exception("No existe");
                }
                else
                {
                    ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                    nodoEliminado = nodoActual;
                    if (nodoActual.HijoDer == null)
                    {
                        if (padre == null)
                        {
                            Raiz = nodoActual.Hijoizq;
                            return nodoEliminado.ObjetoRojo;
                        }
                        if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) > 0)
                        {
                            padre.Hijoizq = nodoActual.Hijoizq;
                            return nodoEliminado.ObjetoRojo;
                        }
                        if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) < 0)
                        {
                            padre.HijoDer = nodoActual.Hijoizq;
                            return (nodoEliminado.ObjetoRojo);
                        }
                        else
                        {
                            return (nodoEliminado.ObjetoRojo);
                        }


                    }

                    if (nodoActual.HijoDer.Hijoizq == null)
                    {
                        nodoActual.HijoDer.Hijoizq = nodoActual.Hijoizq;
                        if (padre == null)
                        {
                            Raiz = nodoActual.HijoDer;
                            return nodoEliminado.ObjetoRojo;
                        }
                        if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) > 0)
                        {
                            padre.Hijoizq = nodoActual.HijoDer;
                            return nodoEliminado.ObjetoRojo;
                        }
                        if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) < 0)
                        {
                            padre.HijoDer = nodoActual.HijoDer;
                            return nodoEliminado.ObjetoRojo;
                        }
                        else
                        {
                            return nodoEliminado.ObjetoRojo;
                        }
                    }
                    ClaseNodo<Tipo> nodoMenor = new ClaseNodo<Tipo>();
                    ClaseNodo<Tipo> padreNodoMenor = new ClaseNodo<Tipo>();
                    nodoMenor = nodoActual.HijoDer.Hijoizq;
                    padreNodoMenor = nodoActual.HijoDer;
                    while (nodoMenor.Hijoizq != null)
                    {
                        padreNodoMenor = nodoMenor;
                        nodoMenor = nodoMenor.Hijoizq;
                    }
                    padreNodoMenor.Hijoizq = nodoMenor.HijoDer;
                    nodoMenor.Hijoizq = nodoActual.Hijoizq;
                    nodoMenor.HijoDer = nodoActual.HijoDer;
                    if (padre == null)
                    {
                        Raiz = nodoMenor;
                        return nodoEliminado.ObjetoRojo;
                    }
                    if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) > 0)
                    {
                        padre.Hijoizq = nodoMenor;
                        return nodoEliminado.ObjetoRojo;
                    }
                    if (padre.ObjetoRojo.CompareTo(nodoActual.ObjetoRojo) < 0)
                    {
                        padre.HijoDer = nodoMenor;
                        return nodoEliminado.ObjetoRojo;
                    }
                    else
                    {
                        return (nodoEliminado.ObjetoRojo);
                    }

                }
            }









        }







    


          
        

        public Tipo BuscarNodo(Tipo objeto)
        {

            if(Vacia)
            {
                throw new Exception("Datos no ecnontrados"); 
            }
            foreach(Tipo nodoActual in this.RecorrerInOrden())
            {
                if(objeto.Equals(nodoActual))
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
                RecorrerYBorrar(nodoActual.Hijoizq);
                RecorrerYBorrar(nodoActual.HijoDer);
                EliminarNodo(nodoActual.ObjetoRojo);
            }
            return; 
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


        // los 4 iteradores 
        // Recorrer preoOrden
        // reocorrer 


        private IEnumerable<Tipo> RecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
        {


            if (nodoActual != null)
            {

                yield return (nodoActual.ObjetoRojo);


                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.Hijoizq))
                {
                    yield return miNodo;
                }

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }





            }

        }

        private IEnumerable<Tipo> RecorrerInOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {


                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.Hijoizq))
                {
                    yield return miNodo;
                }

                yield return (nodoActual.ObjetoRojo);

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }





            }

        }

        private IEnumerable<Tipo> RecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {


                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.Hijoizq ))
                {
                    yield return miNodo;
                }

                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDer))
                {
                    yield return miNodo;
                }

                yield return (nodoActual.ObjetoRojo);



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

        public void CrearArchivoDot(ref string Resultado)
        {

            // .Substring(15, 4); marca boog 
            if (!Vacia) // Si no está vacío ...
            {
                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\nRaíz->" + Raiz.ObjetoRojo.ToString(); 
                RecorrerNodos(Raiz, ref Resultado);
                Resultado = Resultado + "\n}";
            }
            else
            {
                throw new Exception("No hay datos"); 
                
                
            }

        }

        private void RecorrerNodos(ClaseNodo<Tipo> nodoActual, ref string Resultado)
        {
            if (nodoActual != null)
            {
                if (nodoActual.Hijoizq != null)
                {
                    Resultado = Resultado + "\n" + nodoActual.ObjetoRojo.ToString() + "->" + nodoActual.Hijoizq.ObjetoRojo.ToString() + ";";
                    RecorrerNodos(nodoActual.Hijoizq, ref Resultado);
                }
                if (nodoActual.HijoDer != null)
                {
                    Resultado = Resultado + "\n" + nodoActual.ObjetoRojo.ToString() + "->" + nodoActual.HijoDer.ObjetoRojo.ToString() + ";";
                    RecorrerNodos(nodoActual.HijoDer, ref Resultado);
                }
            }



        }




    }
}
