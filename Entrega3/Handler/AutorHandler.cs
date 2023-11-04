using System;
using System.Collections.Generic;

namespace Entrega3.Handler
{
    public class AutorHandler
    {
        private List<AutorDTO> _autores;

        public AutorHandler(List<AutorDTO> autores)
        {
            this._autores = autores;
            
        }

        public List<AutorDTO> All()
        {
            return this._autores;
        }

        public void create(AutorDTO autor)
        {
            this._autores.Add(autor);
        }

        public void update(AutorDTO autor, Guid id)
        {
            foreach (AutorDTO dto in this._autores)
            {
                if (dto.id == id)
                {
                    dto.nombre = autor.nombre;
                    dto.nacionalidad = autor.nacionalidad;
                }
            }
        }

        public void eliminar(Guid id)
        {
            _autores.RemoveAll(autor => autor.id == id);
        }
    }

    public class AutorDTO
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string nacionalidad { get; set; }
    }
}
