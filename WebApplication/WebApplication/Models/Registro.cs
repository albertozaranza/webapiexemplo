﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        public int CarroId { get; set; }
        public int FuncionarioId { get; set; }

        public virtual Carro Carro { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
