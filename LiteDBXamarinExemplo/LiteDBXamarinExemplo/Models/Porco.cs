using System;
using System.Collections.Generic;
using System.Text;

namespace LiteDBXamarinExemplo.Models
{
    public class Porco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string[] Apelidos { get; set; }
        public bool VirouBacon { get; set; }
    }
}
