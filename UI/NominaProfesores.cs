using BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmNominaProfesores : MaterialForm
    {
        Nomina nomina = new Nomina();

        public FrmNominaProfesores()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Varon va a dejar los campos en blanco");
            }
            else if (string.IsNullOrEmpty(txtHorasTrabjadas.Text) || string.IsNullOrEmpty(txtPrecioHoras.Text))
            {
                MessageBox.Show("Aun tiene campos vacios varon");
            }
            else
            {

                Profesores profesores = new Profesores();

                profesores.Nombre = Convert.ToString(txtNombre.Text);
                profesores.Apellido = Convert.ToString(txtApellido.Text);
                profesores.HorasTrabajadas = Convert.ToDouble(txtHorasTrabjadas.Text);
                profesores.PrecioHoras = Convert.ToDouble(txtPrecioHoras.Text);
                nomina.AgregarProfesoresNomina(profesores);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = nomina.GetProfesores();
                Limpiar();
                profesores.CalcularSueldo();
                profesores.CalcularDescuento();

            }
        }

        public void Limpiar()
        {

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtHorasTrabjadas.Text = "";
            txtPrecioHoras.Text = "";
        }


        private void BtnCalcularSueldo_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProfesor_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProfesor_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            FrmProfesores Visor = new FrmProfesores();

            //Crear la lista para enviar al visor
            List<Profesores> listaProfesores = nomina.GetProfesores();

            string nombreReporte = "Reporte.Reportes.Profesores.rdlc";

            string titulo = "Nomina de profesores";

            Visor.Imprimir(nombreReporte, titulo, listaProfesores);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {


                int id = 0;
                if (Convert.ToBoolean(MessageBox.Show("Estas seguro?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    Profesores profesor = new Profesores();
                    profesor = nomina.ListaProfesores.Find(x => x.Id == id);

                    nomina.BorrarDetalles(profesor);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = nomina.GetProfesores();
                }

        }
    }
}
