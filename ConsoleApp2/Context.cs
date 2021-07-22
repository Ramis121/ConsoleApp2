using System;
using ConsoleApp2;
using ConsoleApp2.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExamWork.DataAccess
{
    public class Context : DbContext
    {
        public Context()
        {
            //Database.EnsureDeleted();
            //   Database.EnsureCreated();
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Album_song> Album_Songs { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server_connection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.Album_ID);

                entity.Property(e => e.Album_ID)
                    .HasColumnName("Album_ID");

                entity.Property(e => e.Album_ID)
                    .HasColumnName("Album_ID");

                entity.Property(e => e.Album_Year)
                    .HasColumnName("Album_Year");

                entity.Property(e => e.Tracks)
                    .HasColumnName("Tracks");

                entity.HasOne(d => d.IdArtistNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Artist_ID);
            });
            modelBuilder.Entity<Album_song>(entity =>
            {
                entity.HasKey(e => new { e.Album_ID, e.Song_ID });

                entity.Property(e => e.Album_ID)
                    .HasColumnName("Album_ID");

                entity.Property(e => e.Song_ID)
                    .HasColumnName("Song_ID");

                entity.Property(e => e.Track_Number)
                    .HasColumnName("Track_Number");

                entity.HasOne(d => d.IdAlbumNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Album_ID);

                entity.HasOne(d => d.IdSongNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Song_ID);
            });
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.Artit_ID);

                entity.Property(e => e.Artit_ID)
                    .HasColumnName("Artit_ID");

                entity.Property(e => e.Genre_ID)
                    .HasColumnName("Genre_ID");

                entity.Property(e => e.Country_ID)
                    .HasColumnName("Country_ID");

                entity.Property(e => e.Artist_Site_URL)
                    .IsUnicode(false)
                    .HasColumnName("Artist_Site_URL");

                entity.HasOne(d => d.IdCountryNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Genre_ID);

                entity.HasOne(d => d.IdGenreNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Country_ID);
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Country_ID);

                entity.Property(e => e.Country_ID)
                    .HasColumnName("Country_ID");

                entity.Property(e => e.Country_Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Country_Name");

            });
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.Genre_ID);

                entity.Property(e => e.Genre_ID)
                    .HasColumnName("Genre_ID");

                entity.Property(e => e.Genre_Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Genre_Name");
            });
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Artist_ID);

                entity.Property(e => e.Artist_ID)
                    .HasColumnName("Artist_ID");

                entity.Property(e => e.Group_Name)
                    .HasColumnName("Group_Name");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Artist_ID);
            });
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Artist_ID);

                entity.Property(e => e.Artist_ID)
                    .HasColumnName("Artist_ID");

                entity.Property(e => e.First_Name)
                    .HasColumnName("First_Name");

                entity.Property(e => e.Last_Name)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Birthday");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sex");

                entity.HasOne(d => d.IdArtistNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Artist_ID);
            });
            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasKey(e => e.Song_ID);

                entity.Property(e => e.Song_ID)
                    .HasColumnName("Song_ID");

                entity.Property(e => e.Song_Title)
                    .HasColumnName("Song_Title");

                entity.Property(e => e.Duration)
                    .HasColumnName("Duration");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
