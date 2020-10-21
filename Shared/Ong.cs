using System;
using System.Collections.Generic;
using System.Text;

namespace web_adopet.Shared
{
    public class Ong
    {
        public int OngId { get; set; }

        public string Nome { get; set; }

        public ICollection<Animal> Animais { get; set; }
    }
}
