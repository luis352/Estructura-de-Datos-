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


namespace EDDArregloFloral
{
    public partial class FrmArregloFloral : Form
    {
        ClaseListaSimpleDesordenada<ArregloFlorar> miArregloList = new ClaseListaSimpleDesordenada<ArregloFlorar>();


        #region CargaImagen 
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

        #endregion

        #region MostrarIMa
        private void MostrarImagen(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.Image = (Image)miImagen;
            picFoto.Refresh();
        }
        #endregion

        public FrmArregloFloral()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagen(strNombreArchivo);

            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                picFoto.ImageLocation = abrirImagen.FileName;
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        #region GenerarDatos
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



                    //char[] InicialP = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'I', 'J' };
                    cboincialpedido.Text = cboincialpedido.Items[aleatorio.Next(0, cboincialpedido.Items.Count - 1)].ToString();


                    miAflor.Artificial = aleatorio.Next(100) < 50 ? true : false;



                    string[] Tamaño1 = { "Chico", "Mediano", "Grande" };


                    string[] Imagen1 = { "https://image.shutterstock.com/image-photo/floral-arrangement-made-lily-chrysanthemum-260nw-232693345.jpg" , "https://thumbs.dreamstime.com/z/sistema-de-los-arreglos-florales-121216472.jpg" , "https://img.freepik.com/vector-gratis/coleccion-arreglos-florales-rosa-purpura-acuarela_65186-3215.jpg"
                            , "https://www.lysaflores.com/blog/wp-content/uploads/2019/05/arreglos-florales.jpg" , " https://www.floresdelparque.com/wp-content/uploads/2020/11/FP-061-300x300.jpg"  , "https://www.mrsflowers.com.mx/wp-content/uploads/2019/03/Arreglo-floral-con-12-rosas-y-10-tulipanes.jpg.webp"   };


                    miAflor.UrlImagen = Imagen1[0];

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
                    dataGridView1.Rows.Clear();

                    miAflor.inicialPedido = char.Parse(cboincialpedido.Text);


                    foreach (ArregloFlorar q in miArregloList)
                    {
                        //char Datocaracter; 
                        //Datocaracter =   miAflor.inicialPedido = InicialP[aleatorio.Next(InicialP.Length)];

                        //Datocaracter = 

                        

                        dataGridView1.Rows.Add(q.NumeroVenta, q.Precio, q.Nombre, q.inicialPedido, q.FechaEntrega, q.Artificial ? "Si" : "No", q.Tamaño);



                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
        #endregion 

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
                    MISelecionar.NumeroVenta =   int.Parse(renglonSeleccionado.Cells[0].Value.ToString()); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            MISelecionar = miArregloList.BuscarNodo(MISelecionar);

            return MISelecionar; 
           
            //if (MISelecionar != null)
            //{
            //    MostrarLogotipo(MISelecionar.UrlImagen);
            //    return MISelecionar; 

            //}
            //else
            //{
            //    MessageBox.Show("No exixte ese proveedor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}


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

                if(rbtchico.Checked)
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
               
               miArregloList.AgregarNodo(miflorar);
                
              // miPlazaPublic.AgregarNodo(miPlazita); miPlazaPublica = miPlazita;

               dataGridView1.Rows.Clear();
                foreach (ArregloFlorar unArreglo in miArregloList)
                {
                    dataGridView1.Rows.Add

                        (unArreglo.NumeroVenta, unArreglo.Precio, unArreglo.Nombre, unArreglo.inicialPedido,
                        unArreglo.FechaEntrega.ToShortDateString(), unArreglo.Artificial  ? "Si" : "No"  , unArreglo.Tamaño);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se aceptan datos duplicados ");
            }
           

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MostarData()
        {
            //dataGridView1.Columns.Clear();


            dataGridView1.Rows.Remove(dataGridView1.CurrentRow); 
            

            foreach (ArregloFlorar q in miArregloList)
            {
                dataGridView1.Rows.Add(q.NumeroVenta, q.Precio, q.Nombre, q.inicialPedido, q.FechaEntrega.ToShortDateString(), q.Artificial ? "Si" : "No"  , q.Tamaño);

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
                        + "es artifical " + miArregloFlor.Artificial + "\n"
                        + "tamaño " + miArregloFlor.Tamaño);

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ArregloFlorar unArregloF = new ArregloFlorar();
            unArregloF = selecionarRenglon();

            unArregloF = miArregloList.BuscarNodo(unArregloF); 
            if(unArregloF != null)
            {

                MessageBox.Show("Numero de venta: " + unArregloF.NumeroVenta + "\n" + "precio " + unArregloF.Precio + "\n"
                        + "nombre  " + unArregloF.Nombre + "\n"
                        + "inicial pedido " + unArregloF.inicialPedido + "\n"
                        + "fecha de enterga " + unArregloF.FechaEntrega.ToShortDateString() + "\n"
                        + "es artifical " + unArregloF.Artificial + "\n"
                        + "tamaño " + unArregloF.Tamaño);

            }
            else
            {
                throw new Exception("NO FUNCIONA ");
            }

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

                    dataGridView1.Rows.Clear();
                    foreach (ArregloFlorar q in miArregloList)
                    {
                        dataGridView1.Rows.Add(q.NumeroVenta, q.Precio, q.Nombre, q.inicialPedido, q.FechaEntrega.ToShortDateString(), q.Artificial ? "si" : "no", q.Tamaño);

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dtglistaarregloflorar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtnumeroventa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cboincialpedido.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Si"  )
                {
                    chbArtificial.Checked = true;
                }

                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "No" )
                {
                    chbArtificial.Checked = false;
                }

                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Chico")
                {
                   
                    rbtchico.Checked = true; 
                }
                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Mediano")
                {
                    rbtmediano.Checked = true;
                }
                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Grande")
                {
                    rbtgrande.Checked = true;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error en el sistema");
            }
        }

        private void chbArtificial_CheckedChanged(object sender, EventArgs e)
        {

            ArregloFlorar miArreglo2 = new ArregloFlorar(); 
            if (chbArtificial.Checked ==  true)
            {
                chbArtificial.Text =  "¿Es Artificial?" ; 
            }

            if (chbArtificial.Checked == false )
            {
                chbArtificial.Text = "¿Es Artificial?";
            }

        }
    }
    
}
