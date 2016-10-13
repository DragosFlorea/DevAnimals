using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DevAnimals.Desktop.Database_Control;

namespace DevAnimals.Migrations
{
    [DbContext(typeof(DevAnimalsContext))]
    partial class DevAnimalsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("DevAnimals.Desktop.Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PictureCategory");

                    b.Property<string>("TypeCategory");

                    b.Property<string>("ZoneCategory");

                    b.HasKey("IdCategory")
                        .HasAnnotation("Relational:Name", "PrimaryKey_IdCategory");
                });

            modelBuilder.Entity("DevAnimals.Desktop.Models.RegisterClass", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("location");

                    b.Property<string>("password");

                    b.Property<int>("telephoneNumber");

                    b.Property<string>("user");

                    b.HasKey("IdUser")
                        .HasAnnotation("Relational:Name", "PrimaryKey_IdUser");
                });
        }
    }
}
