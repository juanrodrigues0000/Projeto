﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using siscob;

namespace WebApplication1.Context
{
         public class SiscobContext : DbContext
        {
            public DbSet<Empresa> Empresas { get; set; }
            public DbSet<Funcionario> Funcionarios { get; set; }

            protected void Onconfiguring (DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("");
            }
       }
}
