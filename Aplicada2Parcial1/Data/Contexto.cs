﻿using Aplicada2Parcial1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2Parcial1.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-SL0OFH9\SQLEXPRESS; Database= Parcial1Db; Trusted_Connection = True; ");
        }
    }
}
