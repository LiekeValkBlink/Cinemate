using Cinemate.API.Controllers;
using Cinemate.API.Services.UserService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class UserControllerTest
{
    private Mock<IUserService> _mockUserService;
    private UserController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockUserService = new Mock<IUserService>();
        _controller = new UserController(_mockUserService.Object);
    }

    [Test]
    public async Task GetAllUsers_ReturnsAllUsers()
    {
        var fakeUsers = new List<UserDto>
        {
            new UserDto { /* properties ter test*/ },
            new UserDto { /* properties ter test*/ }
        };
        _mockUserService.Setup(service => service.GetAllUsers()).ReturnsAsync(fakeUsers);

        var result = await _controller.GetAllUsers();

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult.Value, Is.EqualTo(fakeUsers));
    }
    
    [Test]
    public async Task GetUserById_ReturnsUser_WhenFound()
    {
        var fakeUser = new UserDto { /* properties ter test */ };
        _mockUserService.Setup(service => service.GetUserById(It.IsAny<int>())).ReturnsAsync(fakeUser);

        var result = await _controller.GetUserById(1);

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task GetUserById_ReturnsNotFound_WhenNotExists()
    {
        _mockUserService.Setup(service => service.GetUserById(It.IsAny<int>())).ReturnsAsync((UserDto)null);

        var result = await _controller.GetUserById(1);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }
    
    [Test]
    public async Task CreateUser_ReturnsCreatedAtAction_WhenCreated()
    {
        var fakeUser = new UserDto { Id = 1 /* properties ter test */ };
        _mockUserService.Setup(service => service.CreateUser(It.IsAny<AddUserDto>())).ReturnsAsync(fakeUser);

        var result = await _controller.CreateUser(new AddUserDto());

        Assert.That(result.Result, Is.InstanceOf<CreatedAtActionResult>());
    }
    
    [Test]
    public async Task UpdateUser_ReturnsNoContent_WhenUpdated()
    {
        var fakeUser = new UserDto { /* properties ter test*/ };
        _mockUserService.Setup(service => service.UpdateUser(It.IsAny<int>(), It.IsAny<UserDto>())).ReturnsAsync(fakeUser);

        var result = await _controller.UpdateUser(1, new UserDto());

        Assert.That(result, Is.InstanceOf<NoContentResult>());
    }

    [Test]
    public async Task UpdateUser_ReturnsNotFound_WhenNotExists()
    {
        _mockUserService.Setup(service => service.UpdateUser(It.IsAny<int>(), It.IsAny<UserDto>())).ReturnsAsync((UserDto)null);

        var result = await _controller.UpdateUser(1, new UserDto());

        Assert.That(result, Is.InstanceOf<NotFoundResult>());
    }
    
    [Test]
    public async Task DeleteUser_ReturnsOk_WhenDeleted()
    {
        _mockUserService.Setup(service => service.DeleteUser(It.IsAny<int>())).Returns(Task.CompletedTask);

        var result = await _controller.DeleteUser(1);

        Assert.That(result, Is.InstanceOf<OkResult>());
    }





}