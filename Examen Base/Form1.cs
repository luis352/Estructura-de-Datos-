using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Base
{
    public partial class Form1 : Form
    {

         ClaseColaDinamicaDesordenada <Vehiculo> miListaVehiculo = new   ClaseColaDinamicaDesordenada<Vehiculo>();
                                                                                                                                

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
                  Vehiculo miVehiculo = new Vehiculo();
                    
                    miVehiculo.Placas = Guid.NewGuid().ToString().Substring(0, 10);
                    miVehiculo.Modelo = aleatorio.Next(1, 1000);
                    
                   miVehiculo.ingresoEstacionamiento = new DateTime(aleatorio.Next(1940, 2022), aleatorio.Next(1, 12), aleatorio.Next(1, 28));

                    miVehiculo.Capacidad = aleatorio.Next(1, 10000);
                    miVehiculo.Tipo = cbotipo.Items[aleatorio.Next(0, cbotipo.Items.Count - 1)].ToString();
                    miVehiculo.Nombre = Guid.NewGuid().ToString().Substring(0, 10);


                    miListaVehiculo.Encolar(miVehiculo);

                    dataGridView1.Rows.Clear();
                    foreach (Vehiculo q in miListaVehiculo)
                    {
                        dataGridView1.Rows.Add(q.Placas, q.Nombre, q.Modelo, q.Tipo, q.Capacidad, q.ingresoEstacionamiento.ToShortDateString());

                    }






                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }










        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo miVehiculo = new Vehiculo();

                miVehiculo.Nombre = txtnombre.Text;
                miVehiculo.Placas = txtPlacas.Text; 
                miVehiculo.Modelo =  int.Parse(txtmodelo.Text);
                miVehiculo.Tipo = cbotipo.Text;
                miVehiculo.Capacidad = int.Parse(txtCapacidad.Text); 
                miVehiculo.ingresoEstacionamiento = Convert.ToDateTime(dateTimePicker1.Text);

             

                miVehiculo.ingresoEstacionamiento = DateTime.Now;

               
                
                
                    miListaVehiculo.Encolar(miVehiculo);

                dataGridView1.Rows.Clear();
                foreach (Vehiculo q in miListaVehiculo)
                {
                    dataGridView1.Rows.Add(q.Placas, q.Nombre,  q.Modelo, q.Tipo, q.Capacidad, q.ingresoEstacionamiento.ToShortDateString());

                }



            }
            catch (Exception)
            {
                MessageBox.Show("No se aceptan datos duplicados , Recuerde Introducir los datos correctos , Recuerde Cargar la imagen al momento de agregar");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {


               Vehiculo mivehiculo = new Vehiculo();

                // miArregloFlor = selecionarRenglon();



                if (MessageBox.Show("Quiere eleminar el objeto" + "?", "eliminar areglo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    mivehiculo  = miListaVehiculo.Desencolar();

                    //picFoto.Image = null;
                    MessageBox.Show("Se eleminado el arreglo florar");


                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                    MessageBox.Show("placas " + mivehiculo.Placas+ "\n"  + "NOMBRE " + mivehiculo.Nombre + "\n"
                           + "Modelo " + mivehiculo.Modelo + "\n"
                            + "inicial pedido " + mivehiculo.Tipo + "\n"
                            + "fecha de enterga " + mivehiculo.ingresoEstacionamiento.ToShortDateString() + "\n"
                            + "es artifical " + mivehiculo.Capacidad  + "\n"
                             

                           + "LOS DATOS DEL OBJETO SE HAN ELIMANDO ");


                    dataGridView1.Rows.Clear();
                    foreach (Vehiculo q in miListaVehiculo)
                    {
                        dataGridView1.Rows.Add(q.Placas, q.Modelo, q.Tipo, q.Capacidad, q.ingresoEstacionamiento.ToShortDateString());

                    }



                    txtmodelo.Clear();
                    txtCapacidad.Clear();
                    txtPlacas.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eror al elminar el frente");
            }



        }


        private Vehiculo selecionarRenglon()
        {
            Vehiculo MISelecionar = new Vehiculo();

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
                    MISelecionar.Placas = renglonSeleccionado.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            MISelecionar = miListaVehiculo.Buscar(MISelecionar);

            return MISelecionar;

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
                    miListaVehiculo .Vaciar();
                    MessageBox.Show("La Lista se ha Vaciado ");

                    dataGridView1.Rows.Clear();
                    

                    txtmodelo.Clear();
                    txtCapacidad.Clear();
                    txtPlacas.Clear();





                    dataGridView1.Rows.Clear();
                    foreach (Vehiculo q in miListaVehiculo)
                    {
                        dataGridView1.Rows.Add(q.Placas, q.Modelo, q.Tipo, q.Capacidad , q.ingresoEstacionamiento.ToShortDateString());

                    }


                }
            }


            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDesencolarPa_Click(object sender, EventArgs e)
        {
            try
            {

                Vehiculo mivehiculo = new Vehiculo();

                mivehiculo = selecionarRenglon();



                if (MessageBox.Show("Quiere eleminar el objeto" + "?", "eliminar areglo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    mivehiculo = miListaVehiculo.Desencolar(mivehiculo);

                   // picFoto.Image = null;
                    MessageBox.Show("Se eleminado el arreglo florar");


                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                    MessageBox.Show("Numero de placas : " + mivehiculo.Placas + "\n" + "\n"
                            + "modelo " + mivehiculo.Modelo + "\n"
                            + "Tipo" + mivehiculo.Tipo + "\n"
                            + "fecha de Ingreso a estacionamiento " + mivehiculo.ingresoEstacionamiento.ToShortDateString() + "\n"
                            + "Capacidad " + mivehiculo.Capacidad);      
                            
                    txtmodelo.Clear();
                    txtCapacidad.Clear();
                    txtPlacas.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }



        private void CalcularVehiculos()
        {
            int ContadorAuto = 0; int ContadorVago = 0;
            int contadorCami = 0;

            foreach (Vehiculo t in miListaVehiculo)
            {

                if (t.Tipo == "Auto")
                {
                    ContadorAuto++;
                  
                }
                if (t.Tipo == "Vagoneta")
                {
                    ContadorVago++;
                    
                }
                if (t.Tipo == "Camioneta")
                {
                    contadorCami++;
                    
                }

            }
            MessageBox.Show("La cantidAD DE AUTOS SEDAN SON " + ContadorAuto + "\n" +
                "La Cantidad de vagonetas " + ContadorVago + "\n" +
                "La cantidad de camionetas" + contadorCami);








        }
        

        private void  button1_Click(object sender, EventArgs e)
        {
            CalcularVehiculos(); 
           
            

        }


        private int Capacidadmayor2pasajeros()
        {
            Vehiculo mivehiculo = new Vehiculo();

            int Contador = 0;
            foreach (Vehiculo q in miListaVehiculo)
            {
                if (q.Capacidad > 2)
                {
                    Contador++;

                    MessageBox.Show(q.ToString()); 
                    
                }

            }
            return Contador; 


        }




        private void button2_Click(object sender, EventArgs e)
        {
            int Contador = Capacidadmayor2pasajeros(); 

            MessageBox.Show("La Cantidad de vehiculos con capacidad de 2 pasajeros son  " + Contador); 



        }
    }
}
