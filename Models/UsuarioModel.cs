using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace slimeTAP.Models
{
    public class UsuarioModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "O campo Nome de Usuário é obrigatório.")]
        public string? UsuarioNome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string? Senha { get; set; }

        public string? Email { get; set; }
        public float? Moeda { get; set; }
        public int? Level { get; set; }
        public int? Diamante { get; set; }
        public int? Gema { get; set; }
        public float? Multiplicador { get; set; }
        public int? Upgrade1 { get; set; }
        public int? Upgrade2 { get; set; }

    }
}