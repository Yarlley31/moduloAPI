using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moduloAPI.Entities;

namespace moduloAPI.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Contact> Contatos {get; set;}
    }
}