using System.Data.Entity;
using BLL.Abstraction;
using BLL.DTO;
using BLL.Implementation;
using DAL.DataAccessLayer;
using DAL.Models;
using Moq;
using NUnit.Framework;

namespace BLL.Tests
{
    [TestFixture]
    public class PostManagerTests
    {
        IPostManager _manager;
        Mock<DatabaseContext> _contextMoq;

        public PostManagerTests()
        {
            _contextMoq = new Mock<DatabaseContext>();
            _manager = new PostManager(_contextMoq.Object);
            AutoMapperConfig.Initialize();
        }

        [Test]
        public void Test_PutPost()
        {
            //Arrange
            Mock<DbSet<Post>> dbSetMock = new Mock<DbSet<Post>>();
            _contextMoq.Setup(x => x.Posts).Returns(dbSetMock.Object);
            var dto = new PostDto { Title = "test" };

            //Act
            _manager.AddPost(dto);

            //Assert
            _contextMoq.Verify(x => x.SaveChanges(), Times.Once);
            dbSetMock.Verify(x => x.Add(It.IsAny<Post>()), Times.Once);
        }
    }
}
