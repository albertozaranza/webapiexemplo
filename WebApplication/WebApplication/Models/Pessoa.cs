using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
