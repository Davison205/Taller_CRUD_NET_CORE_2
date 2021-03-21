using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller_CRUD_NET_CORE_2.git.Models.Entities;

namespace Taller_CRUD_NET_CORE_2.git.Models.DAL
{
    public class DbContextEstilistapp: DbContext
    {
        public DbContextEstilistapp(DbContextOptions<DbContextEstilistapp> options):base(options)
        {

        }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
