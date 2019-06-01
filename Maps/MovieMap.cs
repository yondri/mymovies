using mymovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace mymovies.Maps{
    #pragma warning disable CS1591
       public class MovieMap
    {
        public MovieMap(EntityTypeBuilder<Movie> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("movie");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Title).HasColumnName("title");
            entityBuilder.Property(x => x.Description).HasColumnName("description");
            entityBuilder.Property(x => x.Rating).HasColumnName("rating");
        }
    }
    #pragma warning restore CS1591
}