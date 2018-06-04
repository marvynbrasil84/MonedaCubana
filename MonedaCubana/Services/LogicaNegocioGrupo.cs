using MonedaCubana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonedaCubana.Services
{
    public class LogicaNegocioGrupo
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        public LogicaNegocioGrupo()
        { }

        public List<string> ObtenerNombreGrupos()
        {
            try
            {
                //using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    int annoAtual = DateTime.Now.Year;
                    int annoSiguiente = DateTime.Now.Year + 1;
                    string periodo = annoAtual.ToString() + "-" + annoSiguiente.ToString();
                    List<string> nombresGrupo = db.Grupo.Where(y => y.Periodo == periodo).Select(x => x.NombreGrupo).ToList();
                    return nombresGrupo;
                }
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }

    }
}