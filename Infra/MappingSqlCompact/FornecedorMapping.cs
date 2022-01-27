using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infra.MappingSqlCompact
{
    public class FornecedorMapping :  EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMapping()
        {
            ToTable("Fornecedor");
            HasKey(c => c.Id).Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).IsOptional();
            Property(c => c.Sigla).IsOptional();
            Property(c => c.Ativo).IsRequired();

        }
    }
}
