using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    // Cachorro, gato...
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public IList<Animal> Animais { get; set; }

        public IList<Raca> Racas { get; set; }
    }
}
