using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio<T> : IRepository<T> where T : class
    {

        public bool Guardar(T entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Set<T>().Add(entity) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;

        }

        public bool Modificar(T entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(entity).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                T entity = contexto.Set<T>().Find(id);
                contexto.Set<T>().Remove(entity);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;

        }

        public T Buscar(int id)
        {          
            Contexto contexto = new Contexto();
            T entity = null;
            try
            {
                entity = contexto.Set<T>().Find(id);               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return entity;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<T> list = null;
            try
            {
                list = contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return list;
        }




    }
}
