using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using RegistroPersona.Entidades;
//using Microsoft.EntityFrameworkCore;


namespace RegistroPersona.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public Contexto() : base("ConStr")
         {

         }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\SqlExpress; Database= PersonasDb; Trusted_Connection = True; ");
        }*/

    }

}
