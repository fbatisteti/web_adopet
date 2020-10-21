using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Raca
    {
        public int RacaId { get; set; }
        
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public string Nome { get; set; }

        public IList<Animal> Animais { get; set; }
    }
}
