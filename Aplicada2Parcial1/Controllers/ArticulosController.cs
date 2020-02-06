using Aplicada2Parcial1.Data;
using Aplicada2Parcial1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Aplicada2Parcial1.Controllers
{
    public class ArticulosController
    {

        public bool Guardar(Articulos entity )
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                db.Articulos.Add(entity);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public bool Modificar(Articulos entity)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            

            try
            {

                Articulos articulo = db.Articulos.Find(Id);
                if(articulo != null)
                {
                    db.Entry(articulo).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
              
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public Articulos Buscar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Articulos articulo = new Articulos();

            try
            {

                articulo = db.Articulos.Find(Id);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return articulo;
        }

        public List<Articulos>GetList(Expression<Func<Articulos,bool>> expression)
        {
            List<Articulos> lista = new List<Articulos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Articulos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return lista;
        }

    }
}
