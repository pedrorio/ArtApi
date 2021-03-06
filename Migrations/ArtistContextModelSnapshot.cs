// <auto-generated />
using ArtApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtApi.Migrations
{
    [DbContext(typeof(ArtistContext))]
    partial class ArtistContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("ArtApi.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Art");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Artist");
                });
#pragma warning restore 612, 618
        }
    }
}
