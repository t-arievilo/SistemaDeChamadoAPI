using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Contexto
{
    public class AplicacaoDbContexto : DbContext
    {
        public AplicacaoDbContexto(DbContextOptions<AplicacaoDbContexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
    }
   
}
