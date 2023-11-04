

namespace Entrega3.Handler
{
    public class LibroHandler
    {
        private List<LibroDTO> _libros;

        public LibroHandler(List<LibroDTO> libros)
        {
            this._libros = libros;
            
        }

        public List<LibroDTO> All()
        {
            return this._libros;
        }

        public void create(LibroDTO libro)
        {
            this._libros.Add(libro);
        }

        public void update(LibroDTO libro, Guid id)
        {
            foreach (LibroDTO dto in this._libros){
                if (dto.id == id)
                {
                    dto.nombre = libro.nombre;
                    dto.resumen = libro.resumen;
                    dto.autord = libro.autord;
                  
                }
            }
        }

        public void eliminar(Guid id)
        {
            _libros.RemoveAll(libro => libro.id == id);
        }
    }

    public class LibroDTO
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string resumen { get; set; }
        public Guid autord { get; set; }
    }
}
