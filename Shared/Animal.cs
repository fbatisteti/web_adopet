using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Chipado { get; set; }

        public string Personalidade { get; set; }

        public Historico Historico { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public int RacaId { get; set; }
        public Raca Raca { get; set; }

        public int OngId { get; set; }
        public Ong Ong { get; set; }

        public IList<Foto> Fotos { get; set; }
    }
}
