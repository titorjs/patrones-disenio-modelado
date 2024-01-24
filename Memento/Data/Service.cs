
using Memento.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Memento.Data
{
    public class Service
    {
        private readonly MementoDbContext _context;
        public Service(MementoDbContext db)
        {
            _context = db;
        }

        public Dato buscar(int id)
        {
            return _context.Datoss.Find(id);
        }

        public Dato agregar(Dato dato)
        {
            if (dato != null && dato.Titulo != null && dato.Cuerpo != null)
            {
                _context.Datoss.Add(dato);
                _context.SaveChanges();
                return dato;
            }
            dato.Id = -1;
            return dato;
        }

        public bool eliminar(int id)
        {
            Dato dato = _context.Datoss.Find(id);
            if (dato != null)
            {
                _context.Datoss.Remove(dato);
                List<BackUp> rm = _context.Mementos.Where(x => x.Id == id).ToList();
                _context.Mementos.RemoveRange(rm);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool backUp(Dato dato)
        {
            Dato backup = _context.Datoss.Find(dato.Id);
            if (backup != null)
            {
                int est = 0;
                BackUp ultimo = _context.Mementos.OrderByDescending(x => x.Estado).FirstOrDefault();
                if (ultimo == null)
                {
                    est = 1;
                } else
                {
                    est = ultimo.Estado + 1;
                }

                backup.Titulo = dato.Titulo;
                backup.Cuerpo = dato.Cuerpo;

                _context.Mementos.Add(
                        new BackUp
                        {
                            Estado = est,
                            Id = backup.Id,
                            Titulo = backup.Titulo,
                            Cuerpo = backup.Cuerpo
                        }
                    );

                _context.Datoss.Update(backup);

                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public Dato rollBack(int id)
        {
            Dato vigente = _context.Datoss.Find(id);
            if (vigente != null)
            {
                BackUp ultimo = _context.Mementos.OrderByDescending(x => x.Estado).FirstOrDefault();
                if(ultimo != null)
                {
                    vigente.Titulo = ultimo.Titulo;
                    vigente.Cuerpo = ultimo.Cuerpo;
                    _context.Datoss.Update(vigente);
                    _context.Mementos.Remove(ultimo);
                    _context.SaveChanges();
                    return vigente;
                }
                return new Dato
                {
                    Id = -1
                };
            }

            return null;
        }
    }
}
