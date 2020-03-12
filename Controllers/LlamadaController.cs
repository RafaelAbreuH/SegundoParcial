using Microsoft.EntityFrameworkCore;
using SegundoParcial.Data;
using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoParcial.Controllers
{
    public class LlamadaController
    {

        public bool Guardar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.llamadas.Add(llamadas);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }

        public bool Modificar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Database.ExecuteSqlRaw($"Delete From LlamadasDetalles where LlamadaId={llamadas.LlamadaId}");

                foreach (var item in llamadas.Detalles)
                {
                    db.Entry(item).State = EntityState.Added;
                }

                db.llamadas.Add(llamadas);
                db.Entry(llamadas).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;



            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }

        public Llamadas Buscar(int id)
        {
            Contexto db = new Contexto();
            Llamadas llamadas = new Llamadas();

            try
            {
                llamadas = db.llamadas
                    .Where(i => i.LlamadaId == id)
                    .Include(i => i.Detalles)
                    .FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

            return llamadas;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            Llamadas llamadas = new Llamadas();
            bool paso = false;

            try
            {
                var eliminar = db.llamadas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }


        public List<Llamadas> GetList(Expression<Func<Llamadas, bool>> expression)
        {
            List<Llamadas> lista = new List<Llamadas>();
            Contexto db = new Contexto();

            try
            {
                lista = db.llamadas.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
