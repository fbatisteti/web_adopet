using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Historico
    {
        public int HistoricoId { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int VacinasId { get; set; }
        public Vacina Vacina { get; set; }

        public string Anotacoes { get; set; }
    }
}
