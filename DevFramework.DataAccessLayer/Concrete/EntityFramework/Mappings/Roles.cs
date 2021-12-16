using DevFramework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.DataAccessLayer.Concrete.EntityFramework.Mappings
{
    public class RolesMap : EntityTypeConfiguration<Role>
    {
        public RolesMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
        }
    }
}
