using System;
using Xunit;
using Atividade07;
using System.Linq;

namespace Atividade07.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void SaveUser_ShouldSaveUserToDatabase()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user = new User("John Doe", "john.doe@example.com");

            // Act
            userService.SaveUser(user);
            var users = db.GetAllUsers();

            // Assert
            Assert.Contains(user, users);
        }

        [Fact]
        public void SaveUser_EmptyName_ShouldThrowArgumentException()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user = new User("", "john.doe@example.com");

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal("User must have a name and email", exception.Message);
        }

        [Fact]
        public void SaveUser_EmptyEmail_ShouldThrowArgumentException()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user = new User("John Doe", "");

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal("User must have a name and email", exception.Message);
        }

        [Fact]
        public void SaveUser_NullName_ShouldThrowArgumentException()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user = new User(null, "john.doe@example.com");

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal("User must have a name and email", exception.Message);
        }

        [Fact]
        public void SaveUser_NullEmail_ShouldThrowArgumentException()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user = new User("John Doe", null);

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => userService.SaveUser(user));
            Assert.Equal("User must have a name and email", exception.Message);
        }

        [Fact]
        public void GetAllUsers_ShouldReturnAllSavedUsers()
        {
            // Arrange
            var db = new Database();
            var userService = new UserService(db);
            var user1 = new User("John Doe", "john.doe@example.com");
            var user2 = new User("Jane Doe", "jane.doe@example.com");

            // Act
            userService.SaveUser(user1);
            userService.SaveUser(user2);
            var users = db.GetAllUsers();

            // Assert
            Assert.Equal(2, users.Count);
            Assert.Contains(user1, users);
            Assert.Contains(user2, users);
        }
    }
}
