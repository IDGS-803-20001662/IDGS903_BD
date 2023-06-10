using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS903_BD.Models
{
    public class AlumnosDbContext:DbContext
    {
        private static string connection = "DefaultConnection";
        public AlumnosDbContext():base(connection)
        {

        }

        //POR CADA MODELO EXISTE UN DBSET, PORQUE <MODELO>
        public DbSet<Alumnos> Alumnos { get; set; }

        // EN CONSOLA DE NUGET
        //en consola: enable-migrations
        //AutomaticMigrationsEnabled = true;

    }
}