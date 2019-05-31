﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }


       public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
        
}
