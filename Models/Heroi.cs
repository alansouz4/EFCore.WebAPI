﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta identidade { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
        public List<Arma> Armas { get; set; }
    }
}
