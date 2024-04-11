using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Profesores
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double HorasTrabajadas { get; set; }
        public double PrecioHoras {  get; set; }
        public double AFP {  get; set; }
        public double SS { get; set; }  
        public double TotalDescuento { get; set; }
        public double SueldoBase { get; set; }
        public double SueldoNeto { get; set; }
        #endregion

        #region Metodos
        public void CalcularSueldo()
        {
            SueldoBase = HorasTrabajadas * PrecioHoras;
            
        }

        public void CalcularDescuento()
        {
             double afp = 0.03;
             double ss = 0.04;
             
             AFP = SueldoBase * afp;
             SS = SueldoBase * ss;   

             TotalDescuento = AFP + SS;

            double SueldoBaseAnual = SueldoBase * 12;


            double Excedente;
            double ImpuestoIsr = 0;
            if (SueldoBaseAnual > 416220.01 && SueldoBaseAnual <= 624329.000)
            {
                Excedente = SueldoBaseAnual - 416220.01;
                Excedente *= 0.15;
                ImpuestoIsr = Excedente / 12;

            }
            else if (SueldoBaseAnual > 624329.01 && SueldoBaseAnual < 867123.00)
            {
                Excedente = SueldoBaseAnual - 624329.01;
                Excedente += 31216.00;
                Excedente *= 0.20;
                ImpuestoIsr = Excedente / 12;
            }
            else if (SueldoBaseAnual > 867123.01)
            {
                Excedente = SueldoBaseAnual - 867123.01;
                Excedente += 79776.00;
                Excedente *= 0.25;
                ImpuestoIsr = Excedente / 12;
            }
            else
            {
                MessageBox.Show("Exento de impuesto de ISR");
            }

            TotalDescuento += ImpuestoIsr;

            SueldoNeto = SueldoBase - TotalDescuento;
            
        }

        #endregion


    }
}
