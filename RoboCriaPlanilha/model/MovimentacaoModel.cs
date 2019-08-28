namespace RoboCriaPlanilha
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovimentacaoModel : DbContext
    {
        public MovimentacaoModel()
            : base("name=MovimentacaoDbContext")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transf> Transf { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Conta)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.idCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.Transf)
                .WithRequired(e => e.Conta)
                .HasForeignKey(e => e.idContaDestinatario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.Transf1)
                .WithRequired(e => e.Conta1)
                .HasForeignKey(e => e.idContaDestinatario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.Transf2)
                .WithRequired(e => e.Conta2)
                .HasForeignKey(e => e.idContaRemetente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transf>()
                .Property(e => e.Valor)
                .HasPrecision(10, 2);
        }
    }
}
