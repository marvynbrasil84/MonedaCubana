using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonedaCubana.Models;
namespace MonedaCubana.Services
{
    
    public class LogicaNegocioTaller
    {
        private ApplicationDBContext db = new ApplicationDBContext();
        public LogicaNegocioTaller()
        { }

        public List<Taller> ListaTaller()
        {
            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    return db.Taller.ToList();
                }
                    
            }
            catch (Exception ex)
            {
                return new List<Taller>();
            }
        }

        public Taller ObtenerTaller_Nombre(String nombre)
        {
            try
            {
                return db.Taller.Find(nombre);
            }
            catch (Exception ex)
            {
                return new Taller();
            }
        }

        public bool Adicionar(Taller t)
        {
            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Taller.Add(t);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public bool Eliminar(String nombre)
        {
            try
            {
               // using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    //db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                    Taller t = db.Taller.Find(nombre);
                    db.Taller.Remove(t);
                    db.SaveChanges();
                    return true;
                }
                    
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Modificar(Taller t)
        {
            try
            {
               // using (ApplicationDBContext db = new ApplicationDBContext())
                {
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


    }
}