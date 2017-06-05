﻿using System.Data.Entity;
using SocialNetwork.negocio;
namespace SocialNetwork.data
{
    public class SocialNetworkContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SocialNetworkContext() : base("name=SocialNetworkContext")
        {
        }

        public DbSet<negocio.Dominio.Perfil> Perfils { get; set; }

        public DbSet<core.Dominio.Horta> Hortas { get; set; }
    }
}
