using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Nomina
    {
        #region Propiedades
        public string Fecha { get; set; }
        public string Mes { get; set; }
        public List<Profesores> ListaProfesores = new List<Profesores>();
        #endregion

        #region Metodos
        public void AgregarProfesoresNomina(Profesores profesor)
        {
                int count = ListaProfesores.Count;
                profesor.Id = count + 1;
                ListaProfesores.Add(profesor);
           
        }

        public List<Profesores> GetProfesores()
        {
            return ListaProfesores;
        }

        public void BorrarDetalles(Profesores profesores)
        {
            ListaProfesores.Remove(profesores);
        }

        #endregion



    }
}
