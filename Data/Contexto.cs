using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BLOODERINO-CALA; Initial Catalog=CRUD_MVC; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Nascimento).HasColumnType("date").IsRequired();
                table.Property(prop => prop.Email).HasColumnType("char(40)").IsRequired();
                table.Property(prop => prop.Sexo).HasColumnType("text").IsRequired();
                table.Property(prop => prop.Telefone1).HasColumnType("char(15)").IsRequired();
                table.Property(prop => prop.Telefone2).HasColumnType("char(15)");
                table.Property(prop => prop.Origem).HasColumnType("text").IsRequired();
                table.Property(prop => prop.Destino).HasColumnType("text").IsRequired();
                table.Property(prop => prop.DataIda).HasColumnType("date").IsRequired();
                table.Property(prop => prop.DataVolta).HasColumnType("date").IsRequired();
                table.Property(prop => prop.Situacao).HasConversion<string>().HasMaxLength(9);
            });
        }
    }
}
