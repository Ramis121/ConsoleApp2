using ConsoleApp2.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Aplication : DbContext
    {
        public Aplication() { }

        public Aplication(DbContextOptions<Aplication> options)
            : base(options)
        {
        }
        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<albums_songs> Albums_Songs { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=N206-12;Initial Catalog=ships;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>(entity => {
                entity.HasKey(e => e.albums_id);

                entity.Property(e => e.albums_id)
                .HasColumnName("album_id");

                entity.Property(e => e.artist_id)
                .HasColumnName("artist_id");


                entity.Property(e => e.album_title)
                .HasColumnName("album_title");

                entity.Property(e => e.album_title)
               .HasColumnName("album_title");

                entity.Property(e => e.album_year)
               .HasColumnName("album_year");

                entity.Property(e => e.albums_tracks)
                .HasColumnName("albums_tracks");
            });

            modelBuilder.Entity<albums_songs>(entity =>
            {
                entity.HasKey(e => e.song_id);

                entity.Property(e => e.album_id)
                .HasColumnName("album_id");

                entity.Property(e => e.track_number)
               .HasColumnName("album_id");

                entity.Property(e => e.song_id)
               .HasColumnName("song_id");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.country_id)
               .HasColumnName("country_id");

                entity.Property(e => e.country_name)
                .HasColumnName("country_name");
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.HasKey(e => e.genre_id);
                entity.Property(e => e.genre_id)
               .HasColumnName("genre_id");

                entity.Property(e => e.genre_name)
                .HasColumnName("genre_name");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.artist_id);
                entity.Property(e => e.artist_id)
                 .HasColumnName("artist_id");

                entity.Property(e => e.last_name)
                  .HasColumnName("last_name");

                entity.Property(e => e.first_name)
                  .HasColumnName("first_name");

                entity.Property(e => e.birchday)
                  .HasColumnType("datetime")
                  .HasColumnName("birchday");

                entity.Property(e => e.MyProperty)
                  .HasColumnName("MyProperty");
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasKey(e => e.song_id);
                entity.Property(e => e.song_id)
                 .HasColumnName("song_id");

                entity.Property(e => e.song_id)
                  .HasColumnName("song_id");

                entity.Property(e => e.song_title)
                  .HasColumnName("first_name");

                entity.Property(e => e.song_duration)
                  .HasColumnName("song_duration");
            });
        }
    }
}
