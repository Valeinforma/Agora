using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Service.Enums;
using Service.Models;

namespace Backend.DataContext
{
    public class AgoraContext: DbContext
    {
        public DbSet<TipoInscripcion> TipoInscripciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Capacitacion> Capacitaciones { get; set; }
        public DbSet<TipoInscripcionCapacitacion> TiposInscripcionesCapacitaciones { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

        public AgoraContext() { }

        public AgoraContext(DbContextOptions<AgoraContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cargamos los datos iniciales de tipo inscripción (publico en general, docente, estudiante jubilados)
            modelBuilder.Entity<TipoInscripcion>().HasData(
                new TipoInscripcion { Id = 1, Nombre = "Público en general" },
                new TipoInscripcion { Id = 2, Nombre = "Docente" },
                new TipoInscripcion { Id = 3, Nombre = "Estudiante" },
                new TipoInscripcion { Id = 4, Nombre = "Jubilado" }
            );
                    modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Juan", Apellido = "Pérez", Dni = "12345678", Email = "juan.perez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Estudiante, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 2, Nombre = "María", Apellido = "García", Dni = "23456789", Email = "maria.garcia@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Docente, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 3, Nombre = "Carlos", Apellido = "López", Dni = "34567890", Email = "carlos.lopez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Estudiante, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 4, Nombre = "Ana", Apellido = "Martínez", Dni = "45678901", Email = "ana.martinez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Administrador, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 5, Nombre = "Luis", Apellido = "Fernández", Dni = "56789012", Email = "luis.fernandez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Docente, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 6, Nombre = "Sofía", Apellido = "Gómez", Dni = "67890123", Email = "sofia.gomez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Estudiante, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 7, Nombre = "Miguel", Apellido = "Díaz", Dni = "78901234", Email = "miguel.diaz@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Docente, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 8, Nombre = "Lucía", Apellido = "Sánchez", Dni = "89012345", Email = "lucia.sanchez@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Estudiante, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 9, Nombre = "Diego", Apellido = "Romero", Dni = "90123456", Email = "diego.romero@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Administrador, DeleteTime = DateTime.MinValue, IsDeleted = false },
                new Usuario { Id = 10, Nombre = "Valentina", Apellido = "Ruiz", Dni = "11223344", Email = "valentina.ruiz@gmail.com", TipoUsuarioEnum = TipoUsuarioEnum.Estudiante, DeleteTime = DateTime.MinValue, IsDeleted = false }
            );


            modelBuilder.Entity<Capacitacion>().HasData(
               new Capacitacion { Id = 1, Nombre = "Introducción a la Programación", Detalle = "Aprende los conceptos básicos de programación.", Ponente = "Carlos Gómez", FechaHora = DateTime.Now.AddDays(10), Cupo = 30, InscripcionAbierta = true },
               new Capacitacion { Id = 2, Nombre = "Desarrollo Web con ASP.NET Core", Detalle = "Crea aplicaciones web modernas con ASP.NET Core.", Ponente = "Ana Martínez", FechaHora = DateTime.Now.AddDays(20), Cupo = 25, InscripcionAbierta = true }
           );
            //cargamos los tipos de inscripción para las capacitaciones, definiendo el costo para cada tipo
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasData(
                new TipoInscripcionCapacitacion { Id = 1, TipoInscripcionId = 1, CapacitacionId = 1, Costo = 10000 },
                new TipoInscripcionCapacitacion { Id = 2, TipoInscripcionId = 2, CapacitacionId = 1, Costo = 5000 },
                new TipoInscripcionCapacitacion { Id = 3, TipoInscripcionId = 3, CapacitacionId = 1, Costo = 3000 },
                new TipoInscripcionCapacitacion { Id = 4, TipoInscripcionId = 4, CapacitacionId = 1, Costo = 2000 },
                new TipoInscripcionCapacitacion { Id = 5, TipoInscripcionId = 1, CapacitacionId = 2, Costo = 12000 },
                new TipoInscripcionCapacitacion { Id = 6, TipoInscripcionId = 2, CapacitacionId = 2, Costo = 6000 },
                new TipoInscripcionCapacitacion { Id = 7, TipoInscripcionId = 3, CapacitacionId = 2, Costo = 4000 },
                new TipoInscripcionCapacitacion { Id = 8, TipoInscripcionId = 4, CapacitacionId = 2, Costo = 30000 }
            );

            // cargamos los datos iniciales de inscripciones
                        modelBuilder.Entity<Inscripcion>().HasData(
                new Inscripcion { Id = 1, usuarioId = 1, TipoInscripcionId = 1, CapacitacionId = 1, Acreditado = false, Importe = 10000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 2, usuarioId = 2, TipoInscripcionId = 2, CapacitacionId = 2, Acreditado = false, Importe = 5000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 3, usuarioId = 3, TipoInscripcionId = 3, CapacitacionId = 3, Acreditado = false, Importe = 3000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 4, usuarioId = 4, TipoInscripcionId = 2, CapacitacionId = 4, Acreditado = false, Importe = 6000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 5, usuarioId = 5, TipoInscripcionId = 2, CapacitacionId = 5, Acreditado = false, Importe = 5000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 6, usuarioId = 6, TipoInscripcionId = 3, CapacitacionId = 6, Acreditado = false, Importe = 4000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 7, usuarioId = 7, TipoInscripcionId = 2, CapacitacionId = 7, Acreditado = false, Importe = 6000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 8, usuarioId = 8, TipoInscripcionId = 3, CapacitacionId = 8, Acreditado = false, Importe = 3000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 9, usuarioId = 9, TipoInscripcionId = 1, CapacitacionId = 9, Acreditado = false, Importe = 12000, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                new Inscripcion { Id = 10, usuarioId = 10, TipoInscripcionId = 3, CapacitacionId = 10, Acreditado = false, Importe = 4000, Pagado = false, UsuarioCobroId = null, IsDeleted = false }
            );
             
            

            

            // Configuramos las querys para que no devuelvan los elementos eliminados
            modelBuilder.Entity<TipoInscripcion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Capacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Inscripcion>().HasQueryFilter(p => !p.IsDeleted);

        }

    }
}
