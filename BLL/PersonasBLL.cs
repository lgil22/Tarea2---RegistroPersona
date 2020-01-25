using RegistroPersona.DAL;
using RegistroPersona.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RegistroPersona.BLL
{
    public class PersonasBLL
    {

        public static bool Guardar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Personas.Add(personas) != null)
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

        //Este es el metodo para modificar en la base de datos
        public static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                //buscar las entidades que no estan para removerlas
                /*var Anterior = db.Estudiantes.Find(estudiante.EstudianteId);
                foreach (var item in Anterior.Telefono)
                {
                    if (!estudiante.Telefono.ToList().Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }*/

                db.Entry(personas).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
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

        //Este es el metodo para eliminar en la base de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Personas.Find(id);
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
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

        //Este es el metodo para buscar en la base de datos
        public static Personas Buscar(int id)
        {
            Contexto db = new Contexto();
            Personas personas = new Personas();
            try
            {
                personas = db.Personas.Find(id);
                // El Count() lo que hace es engañar al lazyloading y obligarlo a cargar los detalles 
                //  estudiante.Telefono.Count();

                //persona = db.Personas
                //     .Include(x => x.Telefonos.Select(c => c.PersonaId))
                //             .Where(p => p.PersonaId == id)
                //             .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return personas;
        }

        //Este es el metodo para listar o consultar lo que tenemos en la base de datos
        public static List<Personas> GetList(Expression<Func<Personas, bool>> personas)
        {
            List<Personas> Lista = new List<Personas>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Personas.Where(personas).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}

