using Service.Interfaces;
using Service.Models;
using Service.Services;

namespace TestAgora
{
    public class UnitTestGenericService
    {
        [Fact]
        public async void TestGetAllInscripciones()
        {
            // Arrange
            var service = new GenericService<Inscripcion>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Inscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }


        }
        [Fact]
        public async void TestGetAlCapacitacion()
        {
            // Arrange
            var service = new GenericService<Capacitacion>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }


        }
        [Fact]
        public async void TestGetAllUsuario()
        {
            // Arrange
            var service = new GenericService<Usuario>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Usuario>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }


        }
        [Fact]
        public async void TestGetAllTipoInscripciones()
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }


        }
        [Fact]
        public async void TestGetAllTiposInscripcionesCapacitaciones()
        {
            // Arrange
            var service = new GenericService<TipoInscripcionCapacitacion>();
            // Act
            var result = await service.GetAllAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcionCapacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, CapacitacionId: {item.CapacitacionId}");
            }


        }

        [Fact]
        public async void TestGetByIdTipoInscripcion()
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            int idToTest = 1; // Cambia este valor según el ID que quieras probar
            // Act
            var result = await service.GetByIdAsync(idToTest);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<TipoInscripcion>(result);
            Assert.Equal(idToTest, result.Id);
            Assert.Equal("Público en general", result.Nombre); // Cambia este valor según el nombre esperado
            Console.WriteLine($"Id: {result.Id}, Nombre: {result.Nombre}");
        }

        [Fact] // Forma en que xUnite identifique que lo que vas a poner es un test

        public async void TestDeleteInscripcion()
        {
            // Arrange
            var service = new GenericService<Inscripcion>();
            int idToDelete = 3; // Asumiendo que este ID existe en la base de datos
                                // Act
            var result = await service.DeleteAsync(idToDelete);
            // Assert
            Assert.True(result);
            Console.WriteLine($"TipoInscripcion con Id {idToDelete} eliminada exitosamente.");
        }

        [Fact]
        public async void TestAddTipoInscripcion()
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            var newTipoInscripcion = new TipoInscripcion
            {
                Nombre = "Estudiante instituto"
            };
            // Act
            var result = await service.AddAsync(newTipoInscripcion);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<TipoInscripcion>(result);
            Assert.Equal(newTipoInscripcion.Nombre, result.Nombre);
            Console.WriteLine($"TipoInscripcion agregado con Id: {result.Id}, Nombre: {result.Nombre}");


        }
        [Fact]

       
        public async void TestDeleteCapacitacion()
        {
            // Arrange
            var service = new GenericService<Capacitacion>();
            // Act
            var result = await service.GetAllDeletedAsync(null);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count == 1); // Asumiendo que siempre hay datos en la base de datos
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }


        [Fact]
        public async void TestUpdateTipoInscripcion()
        {
            //Arrange
            var service = new GenericService<TipoInscripcion>();
            var tipoInscripcionAModificar = new TipoInscripcion()
            {
                Id = 2,
                Nombre = "docente instituto"
            };
            //action
            var result = await service.UpdateAsync(tipoInscripcionAModificar);
            // Assert
            Assert.NotNull(result);
            Assert.True(result);



            
        }

        [Fact]
       
        public async void TestRestoreCapacitacion()
        {
            // Arrange
            var service = new GenericService<Capacitacion>();
            int idToRestore = 3; // Asumiendo que este ID existe en la base de datos
                                 // Act
            var result = await service.RestoreAsync(idToRestore);
            // Assert
            Assert.True(result);
            Console.WriteLine($"Capacitacion con Id {idToRestore} restaurada exitosamente.");
        }
    }
}