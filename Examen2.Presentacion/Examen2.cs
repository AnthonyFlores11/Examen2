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
using Microsoft.VisualBasic;

namespace Examen2.Presentacion
{
    public partial class Examen2 : Form
    {
        Operaciones op = new Operaciones();
        public Examen2()
        {
            InitializeComponent();
            cargarTabla();
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_ingrediente_Click(object sender, EventArgs e)
        {
            Boolean respuesta;
            respuesta = op.InsertarIngre(new Ingredientes(textNomIngre.Text, textDescripIngre.Text));
            cargarTabla();
            LimpiarCampos();
            if (respuesta != false)
            {

                Interaction.MsgBox("Direccion agregada correctamente", 0, "Informacion");
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

                Interaction.MsgBox("Direccion agregada correctamente", 0, "Informacion");
            }
            else
            {

                Interaction.MsgBox("Fallo al agregar direccion", 0, "Advertencia");

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }

        private void cargarTabla()
        {

            try
            {
                SqlDataAdapter res = op.Cargardatos();

                if (res != null)
                {
                    DataTable dt = new DataTable();

                    res.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                else
                {

                    Interaction.MsgBox("Fallo al traer datos de Base Datos o no hay datos en Base Datos", 0, "Aviso");

                }

            }
            catch (Exception ex)
            {

                Interaction.MsgBox("Presentacion/FormPrincipal/CargarDataGrid Error: " + ex.Message);

            }

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
        }
    }
}
