using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonedaCubana.Models;
using System.Web.Helpers;

namespace MonedaCubana.Services
{
    public class LogicaNegocioPlanEntrenamiento
    {
        
        public LogicaNegocioPlanEntrenamiento()
        { }
        
        public List<Programa_Entrenamiento> Lista_Programa_Entranamiento()
        {
            
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    List<Programa_Entrenamiento> lista = db.Programa_Entrenamiento.ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
               return new List<Programa_Entrenamiento>();
            }
        }

        internal Programa_Entrenamiento ObtenerPlan_Curricular(string id)
        {
            throw new NotImplementedException();
        }

        //Devuelve solamente el periodo del curso de entrenamiento
        public List<String> Nombre_Curso_Entrenamiento()
        {

            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    List<String> lista = db.Programa_Entrenamiento.Select(x => x.Periodo).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return new List<String>();
            }
        }

        public bool Adicionar(Programa_Entrenamiento pg)
        {
            bool resultado = false;
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Programa_Entrenamiento.Add(pg);
                    db.SaveChanges();
                    resultado = true;
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }

        public bool Eliminar(String periodo)
        {
            
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    Programa_Entrenamiento pg = db.Programa_Entrenamiento.Find(periodo);
                    //Falta buscar las dependencias
                    db.Programa_Entrenamiento.Remove(pg);
                    db.SaveChanges();
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Modificar(Programa_Entrenamiento pg)
        {
            
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    db.Entry(pg).State = System.Data.Entity.EntityState.Modified;
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