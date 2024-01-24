using Singleton.Modelo;

namespace Singleton.Data
{
    public class Service
    {
        public string valorGlobal { get; set; } = "Defecto";
        private readonly SingletonDbContext _context;
        public Service(SingletonDbContext db)
        {
            _context = db;
        }

        public Dato Add(Dato dato)
        {
            try
            {
               _context.Datos.Add(dato);
                _context.SaveChanges();
                return dato;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public Dato Get(int id)
        {
            try
            {
                Dato dato = _context.Datos.FirstOrDefault(x => x.Id == id);
                if (dato == null)
                {
                    return new Dato
                    {
                        Id = -1
                    };
                }
                return dato;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Dato Remove(int id)
        {
            try
            {
                Dato dato = _context.Datos.FirstOrDefault(x => x.Id == id);
                if (dato == null)
                {
                    return new Dato
                    {
                        Id = -1
                    };
                }
                _context.Datos.Remove(dato);
                return dato;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
