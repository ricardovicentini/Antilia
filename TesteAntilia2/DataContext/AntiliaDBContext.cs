using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TesteAntilia2.Models;

namespace TesteAntilia2.DBContext
{
    public class AntiliaDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> ProdutosCosif { get; set; }
        public DbSet<MovimentoManual> MovimentosManuais { get; set; }

        public AntiliaDBContext() : base("Antilia")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ///produto
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.Codigo)
                .ToTable("PRODUTO")
                .Property(p=> p.Codigo)
                .HasMaxLength(4)
                .HasColumnName("COD_PRODUTO");

            modelBuilder.Entity<Produto>()
                .Property(p => p.Descricao)
                .HasMaxLength(30)
                .HasColumnName("DES_PRODUTO");

            modelBuilder.Entity<Produto>()
                .Property(p => p.Status)
                .HasMaxLength(1)
                .HasColumnType("CHAR")
                .HasColumnName("STA_STATUS");

            // produto cosif
            modelBuilder.Entity<ProdutoCosif>()
                .Property(p => p.CodigoProduto)
                .HasMaxLength(4)
                .HasColumnName("COD_PRODUTO");
                
            modelBuilder.Entity<ProdutoCosif>()
                .HasKey(p => new { p.Codigo, p.CodigoProduto})
                .ToTable("PRODUTO_COSIF")
                .Property(p => p.Codigo)
                .HasMaxLength(11)
                .HasColumnName("COD_COSIF");

            modelBuilder.Entity<ProdutoCosif>()
                .Property(p => p.CodigoClassificacao)
                .HasMaxLength(6)
                .HasColumnName("COD_CLASSIFICACAO");

            modelBuilder.Entity<ProdutoCosif>()
                .Property(p => p.Status)
                .HasMaxLength(1)
                .HasColumnName("STA_STATUS");

            modelBuilder.Entity<ProdutoCosif>()
                .HasRequired<Produto>(p => p.ProdutoRelacionado)
                .WithMany(p => p.CosifsRelacionados)
                .HasForeignKey(fk => fk.CodigoProduto);



            //Movimento Manual

            modelBuilder.Entity<MovimentoManual>()
                .HasKey(k => new { k.Mes, k.Ano, k.NumeroLancamento, k.CodigoProduto, k.CodigoProdutoCosif })
                .ToTable("MOVIMENTO_MANUAL")
                .Property(p => p.Mes)
                .HasColumnName("DAT_MES");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p=> p.Ano)
                .HasColumnName("DAT_ANO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.NumeroLancamento)
                .HasColumnName("NUM_LANCAMENTO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.CodigoProduto)
                .HasColumnName("COD_PRODUTO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.CodigoProdutoCosif)
                .HasColumnName("COD_COSIF");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.Descricao)
                .HasMaxLength(30)
                .HasColumnName("DES_DESCRICAO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.Data)
                .HasColumnName("DAT_MOVIMENTO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.CodigoUsuario)
                .HasMaxLength(15)
                .HasColumnName("COD_USUARIO");

            modelBuilder.Entity<MovimentoManual>()
                .Property(p => p.Valor)
                .HasColumnName("VAL_VALOR");

            modelBuilder.Entity<MovimentoManual>()
                .HasRequired<ProdutoCosif>(cosf => cosf.ProdutoCosif)
                .WithMany(mvts => mvts.MovimentosManuais)
                .HasForeignKey(fk => new {fk.CodigoProduto, fk.CodigoProdutoCosif });

        }
    }
}