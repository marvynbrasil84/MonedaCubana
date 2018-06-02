using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonedaCubana.Models;

namespace MonedaCubana.Services
{
    public class LogicaNegocioPersonal
    {
        private ApplicationDBContext db = new ApplicationDBContext();
        public LogicaNegocioPersonal()
        { }

        public Trabajador ObtenerTrabajador_CI(long? CI)
        {
            try
            {
                return db.Trabajador.Find(CI);
            }
            catch (Exception ex)
            {
                return new Trabajador();
            }
        }

        public List<Trabajador> ObtenerTrabajadores()
        {
            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    /*var trabajadores = db.Trabajador.Select(x => new { CI = x.CI, Ocupacion = x.Ocupacion, Salario = x.Salario });
                    return trabajadores;*/
                    var trabajadores = db.Trabajador.ToList();
                    return trabajadores;
                }
            }
            catch (Exception ex)
            {
                return new List<Trabajador>();
            }
        }

        public List<Profesor> ObtenerProfesores()
        {
            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    /*var trabajadores = db.Trabajador.Select(x => new { CI = x.CI, Ocupacion = x.Ocupacion, Salario = x.Salario });
                    return trabajadores;*/
                    var profesores = db.Profesor.ToList();
                    return profesores;
                }
            }
            catch (Exception ex)
            {
                return new List<Profesor>();
            }
        }

        public Profesor ObtenerProfesor_CI(long? CI)
        {
            try
            {
                return db.Profesor.Find(CI);
            }
            catch (Exception ex)
            {
                return new Profesor();
            }
        }

        public bool AdicionarTrabajador(Persona p, Trabajador t)
        {
            
            try
            {
               // using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Persona.Add(p);
                    db.Trabajador.Add(t);
                    db.SaveChanges();
                    return true;
                }                
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AdicionarProfesor(Persona p, Profesor pf)
        {

            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Persona.Add(p);
                    db.Profesor.Add(pf);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarTrabajador(Persona p, Trabajador t)
        {

            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarProfesor(Persona p, Profesor t)
        {

            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarTrabajador(long ID)
        {

            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    Trabajador t = db.Trabajador.Find(ID);
                    Persona p = db.Persona.Find(ID);
                    db.Trabajador.Remove(t);
                    db.Persona.Remove(p);
                    //db.Trabajador.Remove(db.Trabajador.FirstOrDefault(x => x.CI == ID));
                    //db.Profesor.Remove(db.Profesor.FirstOrDefault(z => z.CI == ID));
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                String msg = ex.ToString();
                return false;
            }
        }

        public bool EliminarProfesor(long ID)
        {

            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    Profesor t = db.Profesor.Find(ID);
                    Persona p = db.Persona.Find(ID);
                    //Buscar dependencia
                    db.Profesor.Remove(t);
                    db.Persona.Remove(p);
                    
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                String msg = ex.ToString();
                return false;
            }
        }
    }
}