using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Vacina
    {
        public int VacinaId { get; set; }

        public int HistoricoId { get; set; }
        public Historico Historico { get; set; }

        // Cães
        public bool V8 { get; set; }
        public bool V10 { get; set; }
        public bool V12 { get; set; }
        public bool Traqueobronquite { get; set; }
        public bool Giardia { get; set; }
        public bool Leishmaniose { get; set; }

        // Gatos
        public bool V3 { get; set; }
        public bool V4 { get; set; }
        public bool V5 { get; set; }

        // Ambos
        public bool Raiva { get; set; }
    }
}
