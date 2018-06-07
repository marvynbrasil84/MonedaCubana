using MonedaCubana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonedaCubana.Services
{
    public class LogicaNegocioAlumnoAsignatura
    {
        public List<Asignatura_Alumno> listado_Alumno_Asignatura()
        {
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    List<Asignatura_Alumno> lista = db.Asignatura_Alumno.ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return new List<Asignatura_Alumno>();
            }
        }

        public bool Asignar_Alumno_Asignatura(Asignatura_Alumno asignacion, string accion)
        {
            try
            {
                if (accion == "I")
                {
                    using (ApplicationDBContext db = new ApplicationDBContext())
                    {
                        db.Asignatura_Alumno.Add(asignacion);
                        db.SaveChanges();
                    }
                }
                else
                    if (accion == "B")
                {

                    using (ApplicationDBContext db = new ApplicationDBContext())
                    {
                        Asignatura_Alumno asignacionSel = db.Asignatura_Alumno.SingleOrDefault(x => x.TallerID == asignacion.TallerID);
                        db.Asignatura_Alumno.Remove(asignacionSel);
                        db.SaveChanges();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<AlumnoAsociacionTaller> TalleresporAlumno(long CI)
        {
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {

                    var result = db.Taller.GroupJoin(db.Asignatura_Alumno,
                        o => o.TallerID,
                        y => y.TallerID,
                        (o, y) => new AlumnoAsociacionTaller
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
                return new List<AlumnoAsociacionTaller>();
            }
        }
    }
}