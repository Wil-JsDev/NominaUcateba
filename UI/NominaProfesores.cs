using BLL;
using MaterialSkin;
using MaterialSkin.Controls;
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
            
        }

        private void BtnCalcularSueldo_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();

            profesores.Id = Convert.ToInt16(txtId.Text);
            profesores.Nombre = Convert.ToString(txtNombre.Text);
            profesores.Apellido = Convert.ToString(txtApellido.Text);
            profesores.HorasTrabajadas = Convert.ToDouble(txtHorasTrabjadas.Text);
            profesores.PrecioHoras = Convert.ToDouble(txtPrecioHoras.Text);
            nomina.AgregarProfesoresNomina(profesores);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = nomina.GetProfesores();
            profesores.CalcularSueldo();
            profesores.CalcularDescuento();
        }

        private void BtnAgregarProfesor_Click_1(object sender, EventArgs e)
        {

        }
    }
}
