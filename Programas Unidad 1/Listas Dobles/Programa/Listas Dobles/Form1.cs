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
namespace Listas_Dobles
{
    public partial class Form1 : Form
    {
        ListaDobleDesordenada<ArregloFlorar> miArregloList = new ListaDobleDesordenada<ArregloFlorar>();
        ArregloFlorar miArregloFlorar = new ArregloFlorar();


        private string _strImagenya;

        public string Imagenya
        {
            get { return _strImagenya; }
            set { _strImagenya = value; }
        }

        private string CargarImagen()
        {

            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                return (strNombreArchivo);


            }
            else return (null);

        }

        private void MostrarImagen(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.Image = (Image)miImagen;
            picFoto.Refresh();
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {

            Imagenya = CargarImagen();
            if (Imagenya != null)
                MostrarImagen(Imagenya);


        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            





        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {

            Random aleatorio = new Random();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    ArregloFlorar miAflor = new ArregloFlorar();

                    miAflor.NumeroVenta = aleatorio.Next(1, 101);



                    miAflor.Precio = aleatorio.NextDouble() * 1000000;



                    miAflor.Nombre = Guid.NewGuid().ToString().Substring(0, 10);




                    cboincialpedido.Text = cboincialpedido.Items[aleatorio.Next(0, cboincialpedido.Items.Count - 1)].ToString();


                    miAflor.Artificial = aleatorio.Next(100) < 50 ? true : false;



                    string[] Tamaño1 = { "Chico", "Mediano", "Grande" };

                    string[] Imagenes = {
                         @"..\..\Resources\Flor11.jpg",
                @"..\..\Resources\Flor15.jpg",
                @"..\..\Resources\Flor2.jpg",
                @"..\..\Resources\Flor3.jpg",
                @"..\..\Resources\Flor4.jpg",
                @"..\..\Resources\Flor5.jpg",
                @"..\..\Resources\Flor6.jpg",
                @"..\..\Resources\Flor7.jpg",
                @"..\..\Resources\Flor8.jpg",
                @"..\..\Resources\Flor81.jpg",
                 @"..\..\Resources\Flor83.jpg",
                  @"..\..\Resources\Flor900.jpg",



                     };

                    miAflor.UrlImagen = Imagenes[aleatorio.Next(Imagenes.Length)];
                    miAflor.Tamaño = Tamaño1[aleatorio.Next(Tamaño1.Length)];
                    if (rbtchico.Checked) { miAflor.Tamaño = "Chico"; }
                    if (rbtmediano.Checked) { miAflor.Tamaño = "Mediano"; }
                    if (rbtgrande.Checked) { miAflor.Tamaño = "Grande"; }


                    DateTime dtmFechaApertura = new DateTime(1980, 1, 1);
                    int rangoDias = (DateTime.Today - dtmFechaApertura).Days;
                    miAflor.FechaEntrega = dtmFechaApertura.AddDays(aleatorio.Next(rangoDias));

                    txtnumeroventa.Text = miAflor.NumeroVenta.ToString();
                    txtprecio.Text = miAflor.Precio.ToString();
                    txtnombre.Text = miAflor.Nombre;

                    miArregloList.AgregarNodo(miAflor);
                    

                    miAflor.inicialPedido = char.Parse(cboincialpedido.Text);

                    MostarData(); 

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private ArregloFlorar selecionarRenglon()
        {
            ArregloFlorar MISelecionar = new ArregloFlorar();

            DataGridViewRow renglonSeleccionado = dataGridView1.CurrentRow;

            if (renglonSeleccionado == null)
            {
                MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                try
                {
                    MISelecionar.NumeroVenta = int.Parse(renglonSeleccionado.Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            MISelecionar = miArregloList.BuscarNodo(MISelecionar);

            return MISelecionar;

        }



        private void MostrarLogotipo(string strImagen)
        {
            Bitmap Logotipoo = new Bitmap(strImagen);

            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.Image = (Image)Logotipoo;
            picFoto.Refresh();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArregloFlorar miflorar = new ArregloFlorar();

                miflorar.NumeroVenta = int.Parse(txtnumeroventa.Text);
                miflorar.Precio = double.Parse(txtprecio.Text);
                miflorar.Nombre = txtnombre.Text;
                miflorar.inicialPedido = char.Parse(cboincialpedido.Text);

                miflorar.FechaEntrega = Convert.ToDateTime(dateTimePicker1.Text);

                if (chbArtificial.Checked)
                {

                    miflorar.Artificial = true;

                }
                else
                {
                    miflorar.Artificial = false;
                }

                if (rbtchico.Checked)
                {
                    miflorar.Tamaño = "Chico";
                }

                if (rbtmediano.Checked)
                {
                    miflorar.Tamaño = "Mediano";
                }


                if (rbtgrande.Checked)
                {
                    miflorar.Tamaño = "Grande";
                }


                miflorar.UrlImagen = Imagenya;


                if (miflorar.UrlImagen == null)
                {
                    throw new Exception("PONGA LA IMAGEN PERRO"); 
                }
                else
                {
                    miArregloList.AgregarNodo(miflorar);
                }



                MostarData(); 




            }
            catch (Exception)
            {
                MessageBox.Show("No se aceptan datos duplicados , Recuerde Introducir los datos correctos , Recuerde Cargar la imagen al momento de agregar ");




            }
        }


        // Mostrar Data 

        private void MostarData()
        {
            
            try
            {

                if (rbtadelante.Checked == true)
                {
                    dataGridView1.Rows.Clear();
                    foreach (ArregloFlorar q in miArregloList.HaciaAdelante)
                    {
                        dataGridView1.Rows.Add(q.NumeroVenta, q.Precio, q.Nombre, q.inicialPedido, q.FechaEntrega.ToShortDateString(), q.Artificial ? "Si" : "No", q.Tamaño);

                    }
                    
                }
                else
                {

                    if (rbtatras.Checked == true)
                    {
                        dataGridView1.Rows.Clear();
                        foreach (ArregloFlorar q in miArregloList.HaciaAtras)
                        {
                            dataGridView1.Rows.Add(q.NumeroVenta, q.Precio, q.Nombre, q.inicialPedido, q.FechaEntrega.ToShortDateString(), q.Artificial ? "Si" : "No", q.Tamaño);

                        }
                        
                    }
                }

                

            }
            catch(Exception)
            {
                
            }



        }






        // eliminar 

        // buscar 


        // Vaciar 



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                ArregloFlorar miarreglo = new ArregloFlorar();

                miarreglo = selecionarRenglon();
                miarreglo = miArregloList.BuscarNodo(miarreglo);
                picFoto.Visible = true;
                MostrarLogotipo(miarreglo.UrlImagen);


                if (miarreglo != null)
                {

                    txtnumeroventa.Text = miarreglo.NumeroVenta.ToString();

                    txtprecio.Text = miarreglo.Precio.ToString();

                    txtnombre.Text = miarreglo.Nombre.ToString();

                    cboincialpedido.Text = miarreglo.inicialPedido.ToString();

                    dateTimePicker1.Text = miarreglo.FechaEntrega.ToString();

                    if (miarreglo.Artificial == true)
                    {
                        chbArtificial.Checked = true;


                    }


                    if (miarreglo.Artificial == false)
                    {
                        chbArtificial.Checked = false;


                    }

                    if (miarreglo.Tamaño.ToString() == "Chico")
                    {
                        rbtchico.Checked = true;
                    }


                    if (miarreglo.Tamaño.ToString() == "Mediano")
                    {
                        rbtmediano.Checked = true;

                    }

                    if (miarreglo.Tamaño.ToString() == "Grande")
                    {
                        rbtgrande.Checked = true;
                    }

                    




                }



            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error en el sistema");
            }
        
         }

        private void rbtadelante_CheckedChanged(object sender, EventArgs e)
        {
            MostarData(); 
             
        }

        private void rbtatras_CheckedChanged(object sender, EventArgs e)
        {
            MostarData(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {


                ArregloFlorar unArregloF = new ArregloFlorar();


                unArregloF.NumeroVenta = int.Parse(txtnumeroventa.Text);


                unArregloF = miArregloList.BuscarNodo(unArregloF);
                if (unArregloF != null)
                {

                    MessageBox.Show("Numero de venta: " + unArregloF.NumeroVenta + "\n" + "precio " + unArregloF.Precio + "\n"
                            + "nombre  " + unArregloF.Nombre + "\n"
                            + "inicial pedido " + unArregloF.inicialPedido + "\n"
                            + "fecha de enterga " + unArregloF.FechaEntrega.ToShortDateString() + "\n"
                            + "es artifical " + (unArregloF.Artificial ? "Si" : "No") + "\n"
                            + "tamaño " + unArregloF.Tamaño, "LOS DATOS SON LOS SIGUIENTES:");

                }
                txtnombre.Clear();
                txtnumeroventa.Clear();
                txtprecio.Clear();
                



            }
            catch (Exception)
            {
                MessageBox.Show("No podemos buscar por que no hay datos ");
            }




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ArregloFlorar miArregloFlor = new ArregloFlorar();
            miArregloFlor = selecionarRenglon();
            if (miArregloFlor != null)
            {
                if (MessageBox.Show("Quiere eleminar el objeto" + miArregloFlor.NumeroVenta + "?", "eliminar areglo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (miArregloList.EliminarNodo(miArregloFlor) != null)
                    {
                        picFoto.Image = null;
                        MessageBox.Show("Se eleminado el arreglo florar");
                    }
                    else
                    {
                        throw new Exception("No se pudo elimianr ");
                    }
                }

                else
                {
                    MessageBox.Show("Operacion Cancelada ");


                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                MessageBox.Show("Numero de venta: " + miArregloFlor.NumeroVenta + "\n" + "precio " + miArregloFlor.Precio + "\n"
                        + "nombre  " + miArregloFlor.Nombre + "\n"
                        + "inicial pedido " + miArregloFlor.inicialPedido + "\n"
                        + "fecha de enterga " + miArregloFlor.FechaEntrega.ToShortDateString() + "\n"
                        + "es artifical " + (miArregloFlor.Artificial ? "Si" : "No") + "\n"
                        + "tamaño " + miArregloFlor.Tamaño, "LOS DATOS DEL OBJETO SE HAN ELIMANDO ");

            }


            txtnombre.Clear();
            txtnumeroventa.Clear();
            txtprecio.Clear();

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Está seguro?", "Confirme la operación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    miArregloList.Vaciar();
                    MessageBox.Show("La Lista se ha Vaciado ");

                    MostarData();

                    txtnombre.Clear();
                    txtnumeroventa.Clear();
                    txtprecio.Clear();


                }
            }


            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
