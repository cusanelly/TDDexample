using CloudCustomers_API.Controllers;
using CloudCustomers_API.Models;
using CloudCustomers_API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers_UnitTest.Systems.Controllers
{
    public class TestUsersController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            // Arrange            
            var mockuserservice = new Mock<IUsersService>();
            mockuserservice.Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());
            var sut = new UsersController(mockuserservice.Object);

            // Act
            var result = (OkObjectResult)await sut.Get();

            //Asserts
            result.StatusCode.Should().Be(200);
        }
        [Fact]
        public async Task Get_OnSuccess_InvokeUsersServiceExactlyOnce()
        {
            // Arrange

            var mockuserservice = new Mock<IUsersService>();
            mockuserservice.Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());
            var sut = new UsersController(mockuserservice.Object);

            // Act
            var result = await sut.Get();

            //Asserts
            mockuserservice.Verify(
                service => service.GetAllUsers(),
                Times.Once);
        }
    }
}