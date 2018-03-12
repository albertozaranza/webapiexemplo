using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Carro
    {
        public Carro()
        {
            Registros = new List<Registro>();
        }

        public int Id { get; set; }
        public string Placa { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
