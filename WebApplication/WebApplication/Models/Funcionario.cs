using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Registros = new List<Registro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int PessoaId { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }
    }
}
