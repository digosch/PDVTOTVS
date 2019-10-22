using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TPDV.Models
{
    public class TPDVContext : DbContext
    {
        public TPDVContext (DbContextOptions<TPDVContext> options)
            : base(options)
        {
        }

        public DbSet<TPDV.Models.Transacao> Resultado { get; set; }
    }
}
