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
    public partial class frmPlazaPublica : Form
    {
        ClasePilaDinamicaDesordenada<PlazaPublica> miPlazaPublic = new ClasePilaDinamicaDesordenada<PlazaPublica>();
        string Imagen;

        #region IMPRIMIRDATOS()
        public void ImprimirDatos()
        {
            //AQUI IMPRIMIMOS EL  DGBLISTAS
            dtgListas.Rows.Clear();
            foreach (PlazaPublica q in miPlazaPublic)
            {
                dtgListas.Rows.Add(q.NumeroSector, q.Nombre, q.Presupuesto, q.CantMonumentos, q.FechaApertura, q.Cerrado ? "Si" : "No", q.TipoCancha);
            }
        }
        #endregion

        #region LIMPIARDATOS
        public void LimpiarDatos()
        {
            //AQUI LIMPIAMOS LOS TEXBOX
            foreach (Control c in gpbDatosPlaza.Controls) { if (c is TextBox) c.Text = ""; }
            chkCerrado.Checked = false;
            radFut.Checked = true;
            radBas.Checked = false;
            cboCantMonumentos.Text = null;
            dtpFechaApertura.Value = DateTime.Today;
            picFotoCargar.Image = null;
            picFotoCargar.ImageLocation = null;
            lstTabla.Items.Clear();
        }
        #endregion

        #region  FRMPLAZAPUBLICA()
        public frmPlazaPublica()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTON PARA SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region METODO PARA CARGAR IMAGEN
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Archivos JPEG (*.jpeg) | *.jpg", RestoreDirectory = true };
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                picFotoCargar.ImageLocation=openFileDialog.FileName;
                Imagen = picFotoCargar.ImageLocation;
            }
        }
        #endregion

        #region BOTON DE DATOS ALEATORIOS
        private void btnDatosAleatorios_Click(object sender, EventArgs e)
        {
            string[] imagenesaleatorias = { "\\Properties\\i1.jpg",
                        "\\Properties\\i2.jpg", "\\Properties\\i3.jpg",
                        "\\Properties\\i4.jpg", "\\Properties\\i5.jpg",
                        "\\Properties\\i6.jpg", "\\Properties\\i7.jpg",
                        "\\Properties\\i8.jpg", "\\Properties\\i9.jpg",
                        "\\Properties\\i10.jpg", };
            char[] arrayCantMonumentos={ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' , 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'X', 'I', 'Z', };
            bool[] arrayCerrado = {true, false};
            string[] arrayCancha = { "Futbol", "Basket" };
            string dir;
            Random aleatorio = new Random();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    dir = Directory.GetCurrentDirectory() + imagenesaleatorias[aleatorio.Next(0, imagenesaleatorias.Length - 1)];
                    PlazaPublica miPlaza = new PlazaPublica();
                    miPlaza.HoraEntrada = DateTime.Now;
                    miPlaza.NumeroSector = aleatorio.Next(1, 50);
                    miPlaza.Nombre= Guid.NewGuid().ToString().Substring(0, 10);
                    miPlaza.Presupuesto = Math.Round(aleatorio.NextDouble() * 100, 1);
                    miPlaza.CantMonumentos = arrayCantMonumentos[aleatorio.Next(arrayCantMonumentos.Length)];
                    miPlaza.FechaApertura = new DateTime(aleatorio.Next(1940, 2022), aleatorio.Next(1, 12), aleatorio.Next(1, 28));
                    miPlaza.Cerrado = arrayCerrado[aleatorio.Next(arrayCerrado.Length)];
                    miPlaza.TipoCancha = arrayCancha[aleatorio.Next(arrayCancha.Length)];
                    miPlaza.RutaImagen = dir;
                    miPlazaPublic.Push(miPlaza);
                    dtgListas.ClearSelection();
                    ImprimirDatos();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region BOTON PARA AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta = MessageBox.Show("¿Está seguro de Agregar?", "Confirme la operación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    PlazaPublica miPlaza = new PlazaPublica(); //Objeto local de la clase roja

                    miPlaza.NumeroSector = int.Parse(txtNumeroSector.Text);
                    miPlaza.Nombre = txtNombrePlaza.Text;
                    miPlaza.Presupuesto = double.Parse(txtPresupuesto.Text);
                    miPlaza.CantMonumentos = char.Parse(cboCantMonumentos.Text);
                    miPlaza.FechaApertura = DateTime.Parse(dtpFechaApertura.Text);
                    miPlaza.RutaImagen = Imagen;
                    miPlaza.HoraEntrada = DateTime.Now;
                    if (chkCerrado.Checked) { miPlaza.Cerrado = true; } else { miPlaza.Cerrado = false; }
                    if (radBas.Checked) { miPlaza.TipoCancha = "Basket"; } else { miPlaza.TipoCancha = "Futbol"; }
                    miPlazaPublic.Push(miPlaza);//Agregamos un Nodo Nuevo
                    ImprimirDatos(); //Metodo en el cual imprimirmos en el DataWriup
                    LimpiarDatos(); // Metodo para Vaciar los TexBox
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region BOTON PARA ELIMINAR TOP
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PlazaPublica miPlaza = new PlazaPublica();
                DialogResult Respuesta = MessageBox.Show("Esta seguro de Eliminar el Elemento?", "Confirme la Operacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Respuesta == DialogResult.Yes)
                {
                    PlazaPublica plazaBorrada = new PlazaPublica();
                    plazaBorrada = miPlazaPublic.Pop();
                    MessageBox.Show($"Numero de Sector {plazaBorrada.NumeroSector}\n" +
                             $"Presupuesto de Plaza {plazaBorrada.Presupuesto}\n" +
                             $"Nombre de Plaza {plazaBorrada.Nombre} \n" +
                             $"Cantidad de Monumentos {plazaBorrada.CantMonumentos} \n" +
                             $"Fecha de Apertura {plazaBorrada.FechaApertura}  \n" +
                             $"Esta Cerrado? {(plazaBorrada.Cerrado ? "Si" : "No")} \n" +
                             $"Tipo de Cancha {plazaBorrada.TipoCancha}\n" +
                             $"Tiempo estado en la Cola { plazaBorrada.CalcularTiempo()}", "Los Datos Eliminados");

                    picFotoCargar.Image = null;
                    picFotoCargar.ImageLocation = null;
                    LimpiarDatos();
                    ImprimirDatos();
                }
            }
            catch (Exception a) {  MessageBox.Show("Error al Eliminar el Primero" + a.Message);}
        }
        #endregion

        #region BOTON PARA BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Está seguro de buscar?", "Confirme la operación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    PlazaPublica miPlaza = new PlazaPublica();//Objeto local de la clase roja
                    miPlaza.NumeroSector = int.Parse(txtBuscarSector.Text);

                    miPlaza = miPlazaPublic.BuscarNodo(miPlaza);

                    LimpiarDatos();

                    string Desicion; if (miPlaza.Cerrado == true) { Desicion = "Si"; } else { Desicion = "No"; }

                    MessageBox.Show($"Numero de Sector {miPlaza.NumeroSector}\n" +
                             $"Presupuesto de Plaza {miPlaza.Presupuesto}\n" +
                             $"Nombre de Plaza {miPlaza.Nombre} \n" +
                             $"Cantidad de Monumentos {miPlaza.CantMonumentos} \n" +
                             $"Fecha de Apertura {miPlaza.FechaApertura}  \n" +
                             $"Esta Cerrado? {Desicion} \n" +
                             $"Tipo de Cancha {miPlaza.TipoCancha}");

                    picFotoCargar.ImageLocation = miPlaza.RutaImagen; //Aqui buscamos la ruta de la Imagen

                    picFotoCargar.Image = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region CELL CLICK
        private void dgbListas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                picFotoCargar.CancelAsync();
                PlazaPublica miPlaza = new PlazaPublica();
                miPlaza.NumeroSector = int.Parse(dtgListas.CurrentRow.Cells[0].Value.ToString());
                PlazaPublica Buscar = miPlazaPublic.BuscarNodo(miPlaza);
                txtNumeroSector.Text = Buscar.NumeroSector.ToString();
                txtNombrePlaza.Text = Buscar.Nombre.ToString();
                txtPresupuesto.Text = Buscar.Presupuesto.ToString();
                cboCantMonumentos.Text = Buscar.CantMonumentos.ToString();
                dtpFechaApertura.Text = Buscar.FechaApertura.ToString();
                if (Buscar.Cerrado == true) chkCerrado.Checked = true;
                if (Buscar.Cerrado == false) chkCerrado.Checked = false;
                if (Buscar.TipoCancha == "Basket") radBas.Checked = true;
                if (Buscar.TipoCancha == "Futbol") radFut.Checked = true;
                picFotoCargar.LoadAsync(Buscar.RutaImagen);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region BOTON PARA VACIAR
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Objeto local de la clase roja
                PlazaPublica miPlaza = new PlazaPublica();

                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Está seguro de vaciar la lista?", "Confirme la operación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    miPlazaPublic.Vaciar();
                    ImprimirDatos();
                    LimpiarDatos();
                    MessageBox.Show("La Lista se ha Vaciado YOU WIN");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region FRMPLAZAPUBLICA
        private void frmPlazaPublica_Load(object sender, EventArgs e)
        {
            dtgListas.ReadOnly = true;
            dtgListas.AllowUserToAddRows = false;
            dtgListas.AllowUserToDeleteRows = false;
            dtgListas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListas.AllowUserToOrderColumns = false;
            dtgListas.MultiSelect = false;
            dtgListas.AllowUserToOrderColumns = false;
            dtgListas.AllowUserToResizeColumns = false;
            dtgListas.AllowUserToResizeRows = false;
            picFotoCargar.SizeMode = PictureBoxSizeMode.StretchImage;
            dtgListas.Columns.Add("numeroSector", "Numero de Sector");
            dtgListas.Columns.Add("nombrePlaza", "Nombre de Plaza");
            dtgListas.Columns.Add("presupuesto", "Presupuesto");
            dtgListas.Columns.Add("cantMonumentos", "Cant Monumentos");
            dtgListas.Columns.Add("fechaApertura", "Fecha de Apertura");
            dtgListas.Columns.Add("cerrado", "Cerrado");
            dtgListas.Columns.Add("tipoCancha", "Tipo De Canc");
            radFut.Checked = true;
        }
        #endregion

        #region BOTON PARA ELIMINAR RENGLON
        private void btnEliminarSobrecarga_Click(object sender, EventArgs e)
        {
            if (dtgListas.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show("¿Está seguro de Eliminar?", "Confirme la operación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Respuesta == DialogResult.Yes)
                    {
                        PlazaPublica miPlaza = new PlazaPublica();

                        miPlaza.NumeroSector = int.Parse(dtgListas.CurrentRow.Cells[0].Value.ToString());
                        miPlaza.Nombre = dtgListas.CurrentRow.Cells[1].Value.ToString();

                        PlazaPublica plazaBorrada = miPlazaPublic.Pop(miPlaza);
                        ImprimirDatos();
                        MessageBox.Show("La Plaza Publica " + miPlaza.NumeroSector + " fue borrada.");
                        MessageBox.Show($"Numero de Sector {plazaBorrada.NumeroSector}\n" +
                             $"Presupuesto de Plaza {plazaBorrada.Presupuesto}\n" +
                             $"Nombre de Plaza {plazaBorrada.Nombre} \n" +
                             $"Cantidad de Monumentos {plazaBorrada.CantMonumentos} \n" +
                             $"Fecha de Apertura {plazaBorrada.FechaApertura}  \n" +
                             $"Esta Cerrado? {(plazaBorrada.Cerrado ? "Si" : "No")} \n" +
                             $"Tipo de Cancha {plazaBorrada.TipoCancha}\n" +
                             $"Tiempo estado en la Cola { plazaBorrada.CalcularTiempo()}", "Los Datos Eliminados");

                        LimpiarDatos();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        #endregion

        //////////////////////////////////////////////
        
        #region METODO DEVOLVER OBJETO MENOS A 55 MESSAGE BOX
        public int Menos55()
        {
            int Contador; Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector < 55)
                {
                    Contador++;
                }
            }
            return (Contador);
        }
        #endregion

        #region METODO DEVOLVER OBJETO MAS A 55 MESSAGE BOS
        public int Mas55()
        {
            int Contador; Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector > 55)
                {
                    Contador++;
                }
            }
            return (Contador);
        }
        #endregion

        #region METODO DEVOLVER PARES MASSAGE BOX
        public int Pares()
        {
            int Contador; Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector % 2 == 0)
                {
                    Contador++;
                }
            }
            return (Contador);
        }
        #endregion

        #region METODO DEVOLVER IMPARES LIST BOX
        public void Impares()
        {
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector % 2 != 0)
                {
                    lstTabla.Items.Add(t.ToString() );

                }
            }
        }
        #endregion

        #region METODO DEVOLVER MENOR A 13 LIST BOX
        public void Menos13()
        {
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector < 13)
                {
                    lstTabla.Items.Add(t.ToString());
                }
            }
        }
        #endregion

        #region METODO DEVOLVER OBJETO MENOS A 44 MESSAGE BOX
        public int Menos44()
        {
            int Contador; Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.NumeroSector < 44)
                {
                    Contador++;
                }
            }
            return (Contador);
        }
        #endregion

        #region METODO PARA IMPRIMIR CADENA MAYOR MESSAGE BOX
        public void CadenaMasLarga()
        {
            PlazaPublica miPlaza = new PlazaPublica();
            miPlaza.Nombre = "W";
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length > miPlaza.Nombre.Length)
                {
                    miPlaza = t;
                }
            }
            MessageBox.Show(miPlaza.ToString(), "Objeto con Mayor Cadena");
        }
        #endregion

        #region METODO PARA IMPRIMIR CADENA MENOR MESSAGE BOX
        public void CadenaMasCorta()
        {
            PlazaPublica miPlaza = new PlazaPublica();
            miPlaza.Nombre = "QQQQQQQQQQQQ";
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length < miPlaza.Nombre.Length)
                {
                    miPlaza = t;
                }
            }
            MessageBox.Show(miPlaza.ToString());
        }
        #endregion

        public void Valorminimodoble()
        {
            PlazaPublica miPlza = new PlazaPublica();
            miPlza .Presupuesto = 999999;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (miPlza.Presupuesto > t.Presupuesto)
                {
                    miPlza = t;

                }


            }
            MessageBox.Show(miPlza.ToString());


            //PlazaPublica miPlaza = new PlazaPublica();
            //miPlaza.Presupuesto = 999999;
            //foreach (PlazaPublica t in miPlazaPublic)
            //{
            //    if (miPlaza.Presupuesto > t.Presupuesto)
            //    {
            //        miPlaza = t;
            //    }
            //}
            //MessageBox.Show(miPlaza.ToString());

        }
        public void CadenaMenor7()
        {
            PlazaPublica miPlaza = new PlazaPublica();
            miPlaza.Nombre = "QQQQQQQQQQQQ";
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length < 7  )
                {
                    miPlaza = t;
                    lstTabla.Items.Add(miPlaza.ToString() );
                    MessageBox.Show(miPlaza.ToString()); 
                }
            }
            
        }

        #region METODO IMPRIMIR EL PROMEDIO LONGUITUDINAL DE LA CADENA MESSAGE BOX
        public void PromedioLonguitudinal()
        {
            int Contador = 0;
            int Var = 0;

            foreach (PlazaPublica t in miPlazaPublic)
            {
                Contador = t.Nombre.Length + Contador;
                Var++;
            }
            Contador = Contador / Var;
            MessageBox.Show($"El Promedio es: {Contador}");
        }
        #endregion

        #region METODO IMPRIMIR CANTIDAD MENOR A 15 LONGITUDINAL
        public void Menor15Longitudinal()
        {
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length < 15)
                {
                    MessageBox.Show(t.ToString());

                    //MessageBox.Show($"Numero de Sector {t.NumeroSector}\n" +
                    //    $"Presupuesto de Plaza {t.Presupuesto}\n" +
                    //    $"Nombre de Plaza {t.Nombre} \n" +
                    //    $"Cantidad de Monumentos {t.CantMonumentos} \n" +
                    //    $"Fecha de Apertura {t.FechaApertura}  \n" +
                    //    $"Esta Cerrado: {(t.Cerrado ?  "Si" : "No")}  \n" +
                    //    $"Tipo de Cancha {t.TipoCancha}");
                }
            }
        }
        #endregion

        #region METODO PARA IMPRIMIR LA CANTIDAD DE CADENAS PARES
        private void CadenaPar()
        {
            int Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length % 2 == 0)
                {
                    Contador++;
                    MessageBox.Show(t.ToString()); 
                   
                }
            }
            MessageBox.Show($"La Cantidad de Cadenas Pares es: {Contador}" );
        }
        #endregion

        #region METODO PARA IMPRIMIR LA CANTIDAD DE CADENAS PARES
        private void CadenaImpar()
        {
            int Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length % 2 != 0)
                {
                    Contador++;
                }
            }
            MessageBox.Show($"La Cantidad de Cadenas Impares es: {Contador}");
        }
        #endregion

        #region METODO PARA IMPRIMIR OBJETOS DE CADENA IMPAR
        public void CadenaImparLongitud()
        {
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.Nombre.Length % 2 != 0)
                {
                    lstTabla.Items.Add(t.ToString());
                }
            }
        }
        #endregion

        #region METODO PARA IMPRIMIR DE CHAR EN MESSAGEBOX Y LISTBOX
        public void CadenaValor2()
        {
            int Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.CantMonumentos == '2')
                {
                    Contador++;
                    lstTabla.Items.Add(t.ToString()); //Forma en ListBox
                }
            }
            //Forma en MessageBox
            MessageBox.Show($"La Cantidad de Cadenas Impares es: {Contador}");
        }
        #endregion

        #region METODO PARA IMPRIMIR CHAR DE UN ADIGITO MAYOR QUE OTRO EN MESSAGEBOX
        public void MayorQue3()
        {
            int Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                if (t.CantMonumentos.CompareTo('1') > 0 && t.CantMonumentos.CompareTo('9') < 0)
                {
                    Contador++;
                }
            }
            MessageBox.Show($"La Cantidad de Cadenas Impares es: {Contador}");
        }
        #endregion

        #region METODO PARA SUMAR EL TIEMPO DEL OBJETO EN LA COLA
        public int SumaCola()
        {
            int Contador = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                Contador = t.CalcularTiempo() + Contador;
            }
            return Contador;
        }
        #endregion

        #region METODO PARA OBTENER EL PROMEDIO DE LA COLA
        public double PromedioCola()
        {
            int Contador = 0;
            double Total = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                Total = t.CalcularTiempo() + Total;
                Contador++;
            }
            Total = Total / Contador;
            return Total;
        }
        #endregion

        public double GananciaTotalCola()
        {
            double Costo = 0.5, Total = 0;
            foreach (PlazaPublica t in miPlazaPublic)
            {
                Total = (t.CalcularTiempo() * Costo) + Total;
            }
            //Por cada 30 segundos se cobra 1.5 pesos
            //Total = (CalcularTiempo() / 30) * 1.5

            return Total;
        }





        private void  CalcularGanaciadeObjeto()
        {

            double CostoMinuto = 3.50, Total = 0;

            foreach (PlazaPublica t in miPlazaPublic)
            {
                Total = (t.CalcularTiempo() * CostoMinuto);
                MessageBox.Show("Ganacia objeto" + Total); 

            }


            
            
                
           



            
        }

        //////////////////////////////////////////////

        #region BOTON DEVOLVER OBJETO MENOS A 55 MESSAGE BOX
        private void btnMenos55_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = Menos55();
            MessageBox.Show($"La Cantidad de Objetos Mayor a 55 es: {Cantidad}");
        }
        #endregion

        #region BOTON DEVOLVER OBJETO MAS A 55 MESSEAGE BOX
        private void btnMas55_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = Mas55();
            MessageBox.Show($"La Cantidad de Objetos Mayor a 55 es: {Cantidad}");
        }
        #endregion

        #region BOTON DEVOLVER PARES MASSAGE BOX
        private void btnPar_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = Pares();
            MessageBox.Show($"La Cantidad de Objetos Mayor a 55 es: {Cantidad}");
        }
        #endregion

        #region BOTON DEVOLVER IMPARES LIST BOX
        private void btnImpar_Click(object sender, EventArgs e)
        {




            lstTabla.Items.Clear();
            Impares();
        }
        #endregion

        #region BOTON DEVOLVER MENOR A 13 LIST BOX
        private void btnMenos13_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            Menos13();
        }


        private int ValordeB()
        {
            int contador = 0; 
            foreach(PlazaPublica t in miPlazaPublic)
            {
                if(t.CantMonumentos == 'B')
                {
                    contador++; 
                }
            }
            return (contador); 
        }


        #endregion

        #region BOTON DEVOLVER OBJETO MENOS A 44 MESSAGE BOX
        private void btnMenos44_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = Menos44();
            MessageBox.Show($"La Cantidad de Objetos Mayor a 44 es: {Cantidad}");
        }
        #endregion

        #region BOTON PARA IMPRIMIR CADENA MAYOR MESSAGE BOX
        private void btnCadenaMayor_Click(object sender, EventArgs e)
        {
            CadenaMasLarga();
        }
        #endregion

        #region BOTON PARA IMPRIMIR CADENA MENOR MESSAGE BOX
        private void btnCadenaMenor_Click(object sender, EventArgs e)
        {
            CadenaMasCorta();
        }
        #endregion

        #region BOTON IMPRIMIR EL PROMEDIO LONGUITUDINAL DE LA CADENA MESSAGE BOX
        private void btnLonguitudPromedio_Click(object sender, EventArgs e)
        {
            PromedioLonguitudinal();
        }
        #endregion

        #region BOTON IMPRIMIR CANTIDAD MENOR A 15 LONGITUDINAL
        private void btnMenor15Long_Click(object sender, EventArgs e)
        {
             Menor15Longitudinal();
        }
        #endregion

        #region BOTON PARA IMPRIMIR LA CANTIDAD DE CADENAS PARES
        private void btnCadenaPar_Click(object sender, EventArgs e)
        {
            CadenaPar();
        }
        #endregion

        #region BOTON PARA IMPRIMIR LA CANTIDAD DE CADENAS IMPARES
        private void btnCadenaImpar_Click(object sender, EventArgs e)
        {
            CadenaImpar();
        }
        #endregion

        #region BOTON PARA IMPRIMIR OBJETOS DE CADENA IMPAR
        private void btnCadenaImparLongitud_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            CadenaImparLongitud();
        }
        #endregion

        #region BOTON PARA IMPRIMIR DE CHAR EN MESSAGEBOX Y LISTBOX
        private void btnCaracter2_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            CadenaValor2();
        }
        #endregion

        #region BOTON PARA IMPRIMIR CHAR DE UN ADIGITO MAYOR QUE OTRO EN MESSAGEBOX
        private void btnMayorque3_Click(object sender, EventArgs e)
        {
            MayorQue3();
        }
        #endregion

        #region BOTON PARA SUMAR EL TIEMPO DEL OBJETO EN LA COLA
        private void button1_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = SumaCola();
            MessageBox.Show($"El tiempo de la Cola es: {Cantidad}");
        }
        #endregion

        #region BOTON PARA OBTENER EL PROMEDIO DE LA COLA
        private void btnPromedioCola_Click(object sender, EventArgs e)
        {
            double Cantidad;
            Cantidad = PromedioCola();
            MessageBox.Show($"El promedio de la Cola es: {Cantidad}");

        }
        #endregion

        private void btnGananciaCola_Click(object sender, EventArgs e)
        {
            double Cantidad;
            Cantidad = GananciaTotalCola();
            MessageBox.Show($"El Total de la Ganancia es: {Cantidad}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalcularGanaciadeObjeto(); 

            


        }

        private void btncadena7_Click(object sender, EventArgs e)
        {

            CadenaMenor7(); 
        }

        private void campo3valorb_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            cantidad = ValordeB();
            MessageBox.Show("La cantidad es " + cantidad); 

        }

        private void datomenordoble_Click(object sender, EventArgs e)
        {
            Valorminimodoble(); 
        }
    }
}
