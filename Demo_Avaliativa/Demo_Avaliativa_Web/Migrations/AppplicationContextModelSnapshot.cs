using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Demo_Avaliativa_Web.DAO;

namespace Demo_Avaliativa_Web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class AppplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo_Avaliativa_Web.DAO.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.Property<int?>("TipoTelefoneId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Demo_Avaliativa_Web.DAO.Entidades.TipoTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Demo_Avaliativa_Web.DAO.Entidades.Cliente", b =>
                {
                    b.HasOne("Demo_Avaliativa_Web.DAO.Entidades.TipoTelefone")
                        .WithMany()
                        .HasForeignKey("TipoTelefoneId");
                });
        }
    }
}
