using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen2.Entidades;
using Examen2.Logica;
using Examen2.Presentacion.SocketCliente;
using Microsoft.VisualBasic;

namespace Examen2.Presentacion
{
    public partial class Examen2 : Form
    {
        ProgramCliente sc = new ProgramCliente();
        int id;
        Operaciones op = new Operaciones();
        public Examen2()
        {
            InitializeComponent();
            cargarTabla();
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Entidades.Menu m = new Entidades.Menu();

            m.Id = int.Parse(dg_menu.Rows[dg_menu.CurrentRow.Index].Cells[4].Value.ToString());
            op.EliminarMenu(m);

            if (op.EliminarMenu(m))
            {
                MessageBox.Show("Agregado correctamente");
                cargarTabla();
            } else
            {
                MessageBox.Show("Fall0");
            }
        }

        private void btn_agregar_ingrediente_Click(object sender, EventArgs e)
        {
            Boolean respuesta;
            respuesta = op.InsertarIngre(new Ingredientes(textNomIngre.Text, textDescripIngre.Text));
            cargarTabla();
            LimpiarCampos();
            if (respuesta != false)
            {

                Interaction.MsgBox("Ingrediente agregado correctamente", 0, "Informacion");
            }
            else
            {

                Interaction.MsgBox("Fallo al agregar direccion", 0, "Advertencia");

            }
        }

        private void btn_eliminar_ingrediente_Click(object sender, EventArgs e)
        {
            Boolean respuesta;
            respuesta = op.Eliminar(new Ingredientes(textNomIngre.Text, textDescripIngre.Text));
            cargarTabla();
            LimpiarCampos();
            if (respuesta != false)
            {

                Interaction.MsgBox("Ingrediente Eliminado correctamente", 0, "Informacion");
            }
            else
            {

                Interaction.MsgBox("Fallo al agregar direccion", 0, "Advertencia");

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Entidades.Menu menu = new Entidades.Menu();
            menu.Nombre = txb_nombre.Text;
            menu.Descripcion = txb_descripcion.Text;




            if (radioDesa.Checked == true)
            {
                menu.Horario = "Desayuno";
            }
            else if (radioAlmu.Checked == true)
            {
                menu.Horario = "Almuerzo";
            }
            else if (radioCena.Checked == true)
            {
                menu.Horario = "Cena";
            }

          menu=  sc.ExecuteClientObject(menu);
            cargarTabla();
            LimpiarCampos();
            MessageBox.Show("Agregado correctamente");

        }

        private void cargarTabla()
        {

                DataTable table = new DataTable();
            DataTable ta = new DataTable();

                table = op.Cargardatos();
                ta = op.CargardatosM();
                dataGridView1.DataSource = table;
               dg_menu.DataSource = ta;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textNomIngre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
            textDescripIngre.Text = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
        }
        public void LimpiarCampos()
        {
            textNomIngre.Text = "";
            textDescripIngre.Text = "";
            txb_nombre.Text = "";
            txb_descripcion.Text = "";
           
        }

        private void grbx_Plato_Enter(object sender, EventArgs e)
        {

        }
    }
}
