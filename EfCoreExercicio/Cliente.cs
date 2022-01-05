using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreExercicio
{
    public partial class Cliente
    {
        public string ClienteId { get; set; }
        public string Nome { get; set; }
        public decimal Idade { get; set; }
        public string Email { get; set; }
    }
}
