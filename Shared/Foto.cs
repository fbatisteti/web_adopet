using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Foto
    {
        public int FotoId { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public string Url { get; set; }
    }
}
