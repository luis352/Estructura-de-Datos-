using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda___Motocicleta
{
    public partial class Form1 : Form
    {

        ClaseABB<Motocicleta> ArbolBinarioBusqueda = new ClaseABB<Motocicleta>();

        public Form1()
        {
            InitializeComponent();
        }



        private void DibujarFigura()
        {
            string Resultado = CrearArchivoDot();
            InvocaDibujar();

            MessageBox.Show("Código para generar el archivo FIGURA.jpg con la " +
                "imagen:\n\n" + Resultado + "\n\nEjecutar mediante: DOT - TJPG - O \\Figura", "CREACIÓN" +
                "DEL ARCHIVO EN LENGUAJE DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CrearNuevaFormaConFigura();
        }

        private string CrearArchivoDot()
        {
            string Resultado = "";
            ArbolBinarioBusqueda.CrearArchivoDot(ref Resultado);
            System.IO.StreamWriter AliasArchivo = new System.IO.StreamWriter(@"" + RutaDOT + "\\Figura");
            AliasArchivo.WriteLine(Resultado);
            AliasArchivo.Close();
            return (Resultado);
        }

        private void InvocaDibujar()
        {


            // El archivo por lotes DIBUJAR.bat contiene el siguiente código:
            // @echo off
            // del \Figura.jpg
            // \"Archivos de programa\Graphviz 2.28"\bin\DOT -Tjpg -O \Figura
            // Ejecuta DIBUJAR.bat ubicado en la carpeta raíz de la unidad de disco

            System.Diagnostics.Process.Start(@"" + RutaBat + "\\DIBUJAR.bat");
        }

        private void CrearNuevaFormaConFigura()
        {
            Form frmNuevaVentana = new Form();
            frmNuevaVentana.Width = 1000;
            frmNuevaVentana.Height = 600;
            frmNuevaVentana.AutoScroll = true;
            frmNuevaVentana.Text = "F I G U R A";
            frmNuevaVentana.StartPosition = FormStartPosition.CenterScreen;
            frmNuevaVentana.Show();

            PictureBox picABB = new PictureBox();
            picABB.Parent = frmNuevaVentana;
            picABB.Width = 990;
            picABB.Height = 565;
            picABB.SizeMode = PictureBoxSizeMode.Zoom;
            System.IO.FileStream AliasFigura;
            try
            {
                AliasFigura = new System.IO.FileStream(@""+RutaJPG+"\\Figura.jpg",
                    System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo abrir el archivo \\Figura.jpg", "E R R OR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmNuevaVentana.Close();
                return;
            }
            try
            {
                picABB.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo \\FIGURA.jpg",
                    "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close();
                frmNuevaVentana.Close();
                return;
            }
            AliasFigura.Close();
            picABB.Refresh();
        }



        public void RefrescarDGV()
        {

            dgvMotos.Rows.Clear();


            if (ArbolBinarioBusqueda.Vacia)
            {
                return;
            }

            if (rdInOrder.Checked)
            {
                foreach (Motocicleta motocicleta in ArbolBinarioBusqueda.RecorrerInOrden())
                {


                    dgvMotos.Rows.Add(
                        motocicleta.NumeroFabricacion.ToString(),
                        motocicleta.VelocidadMax.ToString(),
                        motocicleta.Precio.ToString("C"),
                        
                        motocicleta.CodigoDeSerie,
                        motocicleta.Version,
                         motocicleta.CoberturaDeDatos ? "Vigente" : "No",
                        motocicleta.FechaDeLanzamiento.ToLongDateString()
                        );

                }
            }
            if (rdPostOrden.Checked)
            {
                foreach (Motocicleta motocicleta in ArbolBinarioBusqueda.RecorrerPostOrden())
                {


                    dgvMotos.Rows.Add(
                        motocicleta.NumeroFabricacion.ToString(),
                        motocicleta.VelocidadMax.ToString(),
                        motocicleta.Precio.ToString("C"),
                        
                        motocicleta.CodigoDeSerie,
                        motocicleta.Version,
                         motocicleta.CoberturaDeDatos ? "Vigente" : "No",
                        motocicleta.FechaDeLanzamiento.ToLongDateString()
                        );

                }
            }
            if (rdPreOrden.Checked)
            {
                foreach (Motocicleta motocicleta in ArbolBinarioBusqueda.RecorrerPreOrden())
                {


                    dgvMotos.Rows.Add(
                        motocicleta.NumeroFabricacion.ToString(),
                        motocicleta.VelocidadMax.ToString(),
                        motocicleta.Precio.ToString("C"),
                        
                        motocicleta.CodigoDeSerie,
                        motocicleta.Version,
                         motocicleta.CoberturaDeDatos ? "Vigente" : "No",
                        motocicleta.FechaDeLanzamiento.ToLongDateString()
                        );

                }
            }


        }
        string RutaFoto;
        public void LimpiarControles()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
            
            pictureBox1.CancelAsync();
            pictureBox1.LoadAsync("https://cdn.pixabay.com/photo/2017/11/10/05/24/select-2935439_960_720.png");
            RutaFoto = "";
        }

        public bool fifty()
        {
            Random fifty = new Random();
            if (fifty.NextDouble() > 0.4)
            {
                return true;
            }
            return false;
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ArbolBinarioBusqueda.EstaVacio()) // Si no está vacío ..
                    DibujarFigura(); // Invoca el método para dibujar la figura
                else
                    MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

            
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Motocicleta unaMoto;
            Random random = new Random();

            string[] listaFotos = new string[15]
                {"https://i.pinimg.com/550x/b8/54/ea/b854eacdbc35e1368b02be25e7c9639f.jpg",
                "https://cloudfront-us-east-1.images.arcpublishing.com/infobae/JLM7MD7QBNFWJBXDW2X4VFT3EM.jpg",
                "https://exclusivomotos.com/wp-content/uploads/2020/09/KTM-1290-Super-Duke-R-12-scaled.jpg",
                "https://a5i4f6g5.stackpathcdn.com/images/cms/cbf125.png",
                "https://resources.sears.com.mx/medios-plazavip/fotos/productos_sears1/original/3314776.jpg",
                "https://img.remediosdigitales.com/98cdc8/voge-500r-1/450_1000.jpg",
                "https://www.wilock.com/wp-content/uploads/2018/09/Dodge-Tomahawk-V10-Superbike.jpg",
                "https://media.revistagq.com/photos/61cdd0f759ab05088d9a51c7/master/w_1600%2Cc_limit/6BDB4FF4-A0E9-4CB4-9BAE-97206B7AD05E.jpeg",
                "https://revistacentrozaragoza.com/wp-content/uploads/2019/05/motos3-1024x632.jpg",
                "https://img.remediosdigitales.com/c165a8/honda_sh125/450_1000.jpg",
                "https://blog.coppel.com/wp-content/uploads/2020/02/interior_chopper.png",
                "https://www.hibridosyelectricos.com/media/hibridos/images/2019/06/17/2019061712442294588.jpg?width=1200&enable=upscale",
                "https://as01.epimg.net/mexico/imagenes/2020/07/10/masdeporte/1594354408_537364_1594354608_noticia_normal_recorte1.jpg",
                "https://www.motocarrostvs.com/wp-content/uploads/2020/12/rr1.jpg",
                "https://media.gq.com.mx/photos/5ff4909934f0ef41de7cf420/master/pass/FOTO%20PORTADA.jpg"
                };


            for (int i = 0; i < 10; i++)
            {
                try
                {
                    unaMoto = new Motocicleta();


                    unaMoto.NumeroFabricacion = random.Next(1, 1000);
                    unaMoto.VelocidadMax = random.Next(100, 300);
                    unaMoto.Precio = random.Next(3000, 30000);

                    unaMoto.FechaDeLanzamiento = new DateTime(random.Next(1960, 2022), random.Next(1, 12), random.Next(1, 28));
                    unaMoto.CoberturaDeDatos = fifty();
                    if (fifty() == true)
                    {
                        unaMoto.Version = 'A';
                    }
                    else
                    {
                        unaMoto.Version = 'B';
                    }

                    //Version:A,B - N 
                    unaMoto.CodigoDeSerie = unaMoto.Version + "-" + unaMoto.NumeroFabricacion ;
                    unaMoto.RutaFoto = listaFotos[random.Next(0, 14)];


                    ArbolBinarioBusqueda.AgregarNodo(unaMoto);
                }


                catch (Exception x)
                {

                    MessageBox.Show(x.Message);

                }

            }

            RefrescarDGV();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            string Serie = "";

            if (rdInOrder.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerInOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }

            }
            if (rdPostOrden.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPostOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }
            if (rdPreOrden.Checked)
            {

                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPreOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }

            MessageBox.Show(Serie);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            MessageBox.Show("Llene todos los campos para validar la captura");
                            return;
                        }
                    }

                }
                Motocicleta unaMoto = new Motocicleta();

                unaMoto.CodigoDeSerie = txtCodigoSerie.Text;
                unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);
                unaMoto.VelocidadMax = int.Parse(txtVelMax.Text);
                unaMoto.Precio = double.Parse(txtPrecio.Text);
                
                unaMoto.FechaDeLanzamiento = dtmFechaDeLanzamiento.Value;
                unaMoto.CoberturaDeDatos = chkCobertura.Checked;
                if (rdVerA.Checked)
                {
                    unaMoto.Version = 'A';
                }
                else
                {
                    unaMoto.Version = 'B';
                }
                if (RutaFoto == "")
                {
                    RutaFoto = "https://images.fineartamerica.com/images-medium-large-5/broken-bike-at-oxford-carl-purcell.jpg";
                }

                unaMoto.RutaFoto = RutaFoto;

                ArbolBinarioBusqueda.AgregarNodo(unaMoto);


            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            RefrescarDGV();
            LimpiarControles();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Esta seguro de quemar el arbol?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
            if (decision == DialogResult.No)
            {
                return;
            }
            try
            {
                ArbolBinarioBusqueda.Vaciar();
                MessageBox.Show("Se ha completado el vaciado del arbol");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
            RefrescarDGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Motocicleta unaMoto = new Motocicleta();
                unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);
                unaMoto = ArbolBinarioBusqueda.BuscarNodo(unaMoto);
                MessageBox.Show(unaMoto.ToString());
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            try
            {
                DialogResult decision = MessageBox.Show("¿Esta seguro de borrar este articulo?", "ADVERTENCIA!!!", MessageBoxButtons.YesNo);
                if (decision == DialogResult.No)
                {
                    return;
                }
                Motocicleta unaMoto = new Motocicleta();
                unaMoto.NumeroFabricacion = int.Parse(txtNFab.Text);
                unaMoto = ArbolBinarioBusqueda.EliminarNodo(unaMoto);
                MessageBox.Show(unaMoto.ToString());
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            RefrescarDGV();
            LimpiarControles();
        }

        private void txtNFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtVelMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvMotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMotos.CurrentCell.Value == null)
            {
                return;
            }

            pictureBox1.CancelAsync();
            Motocicleta unaMoto = new Motocicleta();
            unaMoto.NumeroFabricacion = int.Parse(dgvMotos.CurrentRow.Cells[0].Value.ToString());

            try
            {
                unaMoto = ArbolBinarioBusqueda.BuscarNodo(unaMoto);

                txtCodigoSerie.Text = unaMoto.CodigoDeSerie;
                txtNFab.Text = unaMoto.NumeroFabricacion.ToString();
                txtVelMax.Text = unaMoto.VelocidadMax.ToString();
                txtPrecio.Text = unaMoto.Precio.ToString();
                
                dtmFechaDeLanzamiento.Value = unaMoto.FechaDeLanzamiento;
                chkCobertura.Checked = unaMoto.CoberturaDeDatos;
                pictureBox1.CancelAsync();
                pictureBox1.LoadAsync(unaMoto.RutaFoto);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void rdVerA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdVerA.Checked)
            {
                txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
            }
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text  + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void chkCobertura_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        private void txtNFab_TextChanged(object sender, EventArgs e)
        {
            txtCodigoSerie.Text = (rdVerA.Checked ? "A-" : "B-") + txtNFab.Text + "-" + (chkCobertura.Checked ? "GV" : "GC");
        }

        Form frmRutas;
        public void GenerarFormaRutas() 
        {
            int y = 35;
            frmRutas = new Form();
            GroupBox grupo = new GroupBox();
            frmRutas.Width = 650;
            frmRutas.Height = 250;

            frmRutas.Text = "Rutas de acceso";
            frmRutas.StartPosition = FormStartPosition.CenterScreen;
            frmRutas.Show();


            grupo.Location = new Point(5, 5);
            grupo.Text = "Rutas de acceso";
            grupo.Parent = frmRutas;
            grupo.Width = 625;
            grupo.Height = 200;


            for (int i = 0; i < 3; i++)
            {
                Label etiqueta = new Label();
                if (i == 2)
                {
                    etiqueta.Text = "Donde guardar el archivo Figura.jpg:";
                }
                if (i == 1)
                {
                    etiqueta.Text = "Donde guardar el archivo Figura sin extension:";
                }
                if (i == 0)
                {
                    etiqueta.Text = "Archivo .BAT para ejecutar DOT:";
                }

                etiqueta.AutoSize = true;
                etiqueta.Location = new Point(15, y);
                y += 30;
                grupo.Controls.Add(etiqueta);
            }
            y = 35;
            for (int i = 0; i < 3; i++)
            {
                TextBox txtRuta = new TextBox();
                if (i == 2)
                {
                    txtRuta.Text = RutaJPG;
                }
                if (i == 1)
                {
                    txtRuta.Text = RutaDOT;
                }
                if (i == 0)
                {
                    txtRuta.Text = RutaBat;
                }

                txtRuta.Name = "txtRuta" + i.ToString();
                txtRuta.Size = new Size(250, 20);
                txtRuta.Location = new Point(250, y);
                y += 30;
                grupo.Controls.Add(txtRuta);
            }
            y = 35;
            for (int i = 0; i < 3; i++)
            {
                Button boton = new Button();
                boton.Name = "Examinar" + i.ToString();
                boton.Text = "Examinar";
                boton.Size = new Size(75, 25);
                boton.Location = new Point(515, y);
                y += 30;
                boton.Click += new System.EventHandler(this.btnExaminar);
                grupo.Controls.Add(boton);
            }
        }
        
        private void btnRutas_Click(object sender, EventArgs e)
        {
            GenerarFormaRutas();

          
        }
        string RutaBat="",RutaDOT="",RutaJPG="";

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.CancelAsync();
                RutaFoto = Microsoft.VisualBasic.Interaction.InputBox("Introduzca la URL de su imagen");
                pictureBox1.LoadAsync(RutaFoto);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void rdInOrder_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            string Serie = "";

            if (rdInOrder.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerInOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }

            }
            if (rdPostOrden.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPostOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }
            if (rdPreOrden.Checked)
            {

                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPreOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }

            
        }

        private void rdPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            string Serie = "";

            if (rdInOrder.Checked)
            {     
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerInOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }

            }
            if (rdPostOrden.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPostOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }
            if (rdPreOrden.Checked)
            {

                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPreOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }

           
        }

        private void rdPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarDGV();
            string Serie = "";

            if (rdInOrder.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerInOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }

            }
            if (rdPostOrden.Checked)
            {
                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPostOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }
            if (rdPreOrden.Checked)
            {

                foreach (Motocicleta moto in ArbolBinarioBusqueda.RecorrerPreOrden())
                {
                    Serie += " -> " + moto.ToString().Substring(15, 4);
                }
            }

          
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (RutaBat != "")
            {
                bool existe = System.IO.File.Exists(@"" + RutaBat + "\\DIBUJAR.bat");

                if (existe)
                {
                    MessageBox.Show("Tiene un archivo existente .BAT");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No cuenta con un archivo .BAT, ¿Desea crear uno?", "Creacion .BAT", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string comando = "@echo off" +
                            "\nc:" +
                            "\ncd "+RutaBat +
                            "\ndel \\Figura.jpg" +
                            "\ndot.exe -Tjpg Figura -o Figura.jpg";

                        System.IO.File.WriteAllText(@"" + RutaBat + "\\DIBUJAR.bat", comando);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }


                }

            }
        }

        private void btnExaminar(object sender, EventArgs e)
        {
            if (((Button)sender).Name=="Examinar0")
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Seleccione la ruta de guardado:" })
                {
                    if (fbd.ShowDialog()==DialogResult.OK)
                    {
                        RutaBat = new Uri(fbd.SelectedPath).ToString().Substring(8);
                        
                    }
                }


            }
            if (((Button)sender).Name == "Examinar1")
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Seleccione la ruta de guardado:" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        RutaDOT = new Uri(fbd.SelectedPath).ToString().Substring(8);
                     
                    }
                }
            }
            if (((Button)sender).Name == "Examinar2")
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Seleccione la ruta de guardado:" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        RutaJPG = new Uri(fbd.SelectedPath).ToString().Substring(8);
                   
                    }
                }
            }
         
            frmRutas.Close();
           
            GenerarFormaRutas();

        }


    }
}
