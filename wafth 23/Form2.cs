using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wafth_23
{
    public partial class Form2 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=smis031021; Uid=root;  Pwd = usbw;");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string registro = "INSERT INTO actores (ID,Nombre,Nacionalidad,Edad,Residencia, premios) values('" + txtid.Text + "', '" + txtnombre.Text + "', '" + txtnacionalidad.Text + "', '" + txtnacimiento.Text + "', '" + txtpelicula.Text + "', '" + txtpremio.Text + "'); ";
            MySqlCommand comando = new MySqlCommand(registro, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MetroFramework.MetroMessageBox.Show(this, "Los datos de "+ txtnombre.Text + " han guardado exitosamente",
                           "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mv = new Form1();
            mv.ShowDialog();
            this.Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mv = new Form2();
            mv.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string actualizar = "UPDATE actores SET ID='" + txtid.Text +
                "',Nombre='" + txtnombre.Text +
                "',Nacionalidad='" + txtnacionalidad.Text +
                "',Edad='" + txtnacimiento.Text +
                "',Residencia='" + txtpelicula.Text +
                 "',premios='" + txtpremio.Text +
                 "'WHERE ID='" + txtid.Text +
                 "';";
            MySqlCommand comando = new MySqlCommand(actualizar, conexion);
            comando.ExecuteNonQuery();
            string mensaje = "Usted a actualizado con exito los datos";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Datos de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                conexion.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para actualizar escriba la ID de el archivo que desea actualizar y los nuevos datos ");
        }
    }
}
