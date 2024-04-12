using BLL;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte
{
    public partial class FrmProfesores : MaterialForm
    {
        public FrmProfesores()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void Imprimir(string nombreReporte, string titulo, List<Profesores> ListaProfesor)
        {
            //Le pasamos al visor de reporte el nombre del reporte a cargar
            this.reportViewer1.LocalReport.ReportEmbeddedResource = nombreReporte;

            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsProfesores", ListaProfesor));

            ReportParameter parametro1 = new ReportParameter("Titulo", titulo.ToString());

            this.reportViewer1.LocalReport.SetParameters(parametro1);

            this.reportViewer1.RefreshReport();

            this.Show();


        }
    }
}
