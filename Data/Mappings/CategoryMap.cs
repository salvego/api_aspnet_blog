using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Tabela
            builder.ToTable("Category");
            //Chave-Primary
            builder.HasKey(x=> x.Id);

            //Identity
            builder.Property(x=> x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x=> x.Name)
                .IsRequired() // NOT NULL
                .HasColumnName("Name") //NOME DA COLUNA
                .HasColumnType("VARCHAR") //TIPO DE DADO DA COLUNA
                .HasMaxLength(80); //TAMANHO DO CAMPO

            builder.Property(x=> x.Slug)
                .IsRequired() // NOT NULL
                .HasColumnName("Slug") //NOME DA COLUNA
                .HasColumnType("VARCHAR") //TIPO DE DADO DA COLUNA
                .HasMaxLength(80); //TAMANHO DO CAMPO

            //Indíces
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
                .IsUnique(); //Indice é único


        }
    }
}