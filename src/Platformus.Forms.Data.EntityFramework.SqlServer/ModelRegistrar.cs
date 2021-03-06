﻿
using Microsoft.Data.Entity;
using ExtCore.Data.EntityFramework.SqlServer;
using Platformus.Forms.Data.Models;

namespace Platformus.Forms.Data.EntityFramework.SqlServer
{
  public class ModelRegistrar : IModelRegistrar
  {
    public void RegisterModels(ModelBuilder modelbuilder)
    {
      modelbuilder.Entity<CachedForm>(etb =>
        {
          etb.HasKey(e => new { e.CultureId, e.FormId });
          etb.ForSqlServerToTable("CachedForms");
        }
      );

      modelbuilder.Entity<Form>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id).UseSqlServerIdentityColumn();
          etb.ForSqlServerToTable("Forms");
        }
      );

      modelbuilder.Entity<FieldType>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id).UseSqlServerIdentityColumn();
          etb.ForSqlServerToTable("FieldTypes");
        }
      );

      modelbuilder.Entity<Field>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id).UseSqlServerIdentityColumn();
          etb.ForSqlServerToTable("Fields");
        }
      );

      modelbuilder.Entity<FieldOption>(etb =>
        {
          etb.HasKey(e => e.Id);
          etb.Property(e => e.Id).UseSqlServerIdentityColumn();
          etb.ForSqlServerToTable("FieldOptions");
        }
      );
    }
  }
}