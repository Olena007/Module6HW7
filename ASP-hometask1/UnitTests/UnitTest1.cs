using Xunit;
using ASP_hometask1.Interfaces;
using ASP_hometask1.Services;
using ASP_hometask1.Entity;
using Moq;

namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Create_ValidProduct_AddedToDatabase()
        {
            // Arrange
            Mock<IProvider> provider = new Mock<IProvider>();
            provider
                .Setup(x => x.Create(It.IsAny<Flora>()))
                .Returns(0);

            var service = new InitialProvider(provider.Object);
            var item = new Flora(1,"tree", 100);

            //Act
            var id = service.Create(item);

            //Assert
            Assert.Equal(0, id);
        }

        [Fact]
        public void Delete_ValidProduct_DeletedToDatabase()
        {
            //Arrange
            Mock<IProvider> provider = new Mock<IProvider>();
            provider
                .Setup(x => x.Delete(It.IsAny<int>()))
                .Returns(true);

            var service = new InitialProvider(provider.Object);
            var item = new Flora(1,"tree", 100);

            //Act
            var id = service.Create(item);
            var deleted = service.Delete(id);

            //Assert
            Assert.True(deleted);
        }

        [Fact]
        public void Read_ValidProduct_GetDatabase()
        {
            var item = new Flora(1,"tree", 100);
            //Arrange
            Mock<IProvider> provider = new Mock<IProvider>();
            provider
                .Setup(x => x.Read(It.IsAny<int>()))
                .Returns(item);

            var service = new InitialProvider(provider.Object);

            //Act
            var id = service.Create(item);
            var get = service.Read(id);

            //Assert
            Assert.NotNull(get);
        }

        [Fact]
        public void Update_ValidProduct_UpdateDatabase()
        {
            var item = new Flora(1,"tree", 100);
            //Arrange
            Mock<IProvider> provider = new Mock<IProvider>();
            provider
                .Setup(x => x.Update(It.IsAny<Flora>()))
                .Returns(item.name);

            var service = new InitialProvider(provider.Object);
            var update = new Flora(1,"bush", 100);

            //Act
            var id = service.Create(item);
            var updated = service.Update(update);

            //Assert
            Assert.Equal("bush", updated);
        }
    }
}