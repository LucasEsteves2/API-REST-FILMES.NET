﻿using ApiLucasFlix.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLucasFlix.Data
{
    public class FilmeContext : DbContext
    {

        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }//

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> cinema { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
    }
}
