using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PracticaRelaciones.Models;

public partial class PracticarContext :DbContext 
{
    public PracticarContext()
    {

    }

    public PracticarContext(DbContextOptions<PracticarContext> options) : base(options){}

    public virtual DbSet<Estudiante> Estudiantes { get; set; }
    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }



    public virtual DbSet<Autor> Autores { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }








     public virtual DbSet<DetallesEmpleado> DetallesEmpleados { get; set; }
     public virtual DbSet<Empleado> Empleados { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Estudiante Curso Un estudiante puede estar en varios cursos
        //Lado uno
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.ToTable("Estudiantes");
            entity.HasKey(e => e.Id);
            entity.HasMany(e => e.Cursos).WithOne(c => c.Estudiante).HasForeignKey(c=>c.IdEstudiante);
        });

        //Lado Muchos
        modelBuilder.Entity<Curso>(entity =>
        {
            entity.ToTable("Cursos");
            entity.HasKey(c=>c.Id);
            entity.HasOne(c => c.Estudiante).WithMany(e => e.Cursos).HasForeignKey(c => c.IdEstudiante);
        });


        //1.- UNO A MUCHOS
        //Producto Categoria Una categoria puede tener varios productos

        //Lado uno
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.ToTable("Categorias");
            entity.HasKey(c=>c.Id);
            entity.HasMany(c => c.Productos).WithOne(p => p.Categoria).HasForeignKey(p=>p.IdCategoria);
        });

        //Lado muchos
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");
            entity.HasKey(p=>p.Id);
            entity.HasOne(p => p.Categoria).WithMany(c => c.Productos).HasForeignKey(p => p.IdCategoria);
        });

        //2.- MUCHOS A MUCHOS
        //Autor Libros Muchos libros pueden tener muchos autores

        modelBuilder.Entity<AutorLibro>(entity =>
        {
            entity.ToTable("AutorLibro");
            entity.HasKey(al => new { al.IdAutor, al.IdLibro });
            entity.HasOne(al => al.Autor).WithMany(a => a.AutorLibro).HasForeignKey(al => al.IdLibro);
            entity.HasOne(al => al.Libro).WithMany(l => l.AutorLibro).HasForeignKey(al => al.IdAutor);
        });

        //3.- UNO A UNO
        //Uno a muchos 

        //Lado empleado
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.DetallesEmpelado).WithOne().HasForeignKey<Empleado>(e => e.IdDetallesEmpleado);
        });

        //Lado detalle
        modelBuilder.Entity<DetallesEmpleado>(entity =>
        {
            entity.HasKey(de => de.Id);
            entity.HasOne(de => de.Empleado).WithOne().HasForeignKey<DetallesEmpleado>(de => de.IdEmpleado);
        });






    }




}
