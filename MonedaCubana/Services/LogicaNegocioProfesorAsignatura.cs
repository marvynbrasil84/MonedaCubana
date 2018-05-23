using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonedaCubana.Models;

namespace MonedaCubana.Services
{
    public class LogicaNegocioProfesorAsignatura
    {
        //private ApplicationDBContext db = new ApplicationDBContext();

        public List<Asignatura_Profesor> listado_Profesor_Asignatura()
        {
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    List<Asignatura_Profesor> lista = db.Asignatura_Profesor.ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return new List<Asignatura_Profesor>();
            }
        }

        public bool Asignar_Profesor_Asignatura(string asignatura)
        {
            try
            {

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public List<ProfesorAsociacionTaller> TalleresporProfesor(long CI)
        {
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {

                    var result = db.Taller.GroupJoin(db.Asignatura_Profesor,
                        o => o.TallerID,
                        y => y.TallerID,
                        (o, y) => new ProfesorAsociacionTaller
                        {
                            Nombre = o.Nombre,
                            TallerID = o.TallerID,
                            Posee = y.FirstOrDefault(e => e.CI == CI) == null ? "N" : "S"
                        }
                        ).ToList();


                    return result;
                }
            }
            catch (Exception ex)
            {
                return new List<ProfesorAsociacionTaller>();
            }
        }
    }

}