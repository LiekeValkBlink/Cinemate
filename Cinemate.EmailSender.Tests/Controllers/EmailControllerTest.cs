using Cinemate.EmailSender.Controllers;
using Cinemate.EmailSender.Models;
using Cinemate.EmailSender.Services.EmailServices; 
using Moq;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.EmailSender.Tests.Controllers;

[TestFixture]
public class EmailControllerTest
{
    private Mock<IEmailService> _mockEmailService;
    private EmailController _emailController;

    [SetUp]
    public void SetUp()
    {
        
        _mockEmailService = new Mock<IEmailService>();
        
        _emailController = new EmailController(_mockEmailService.Object);
    }

    [Test]
    public void Sendmail_ReturnsOkResult_WhenCalled()
    {
        
        var emailRequest = new EmailDto
        {
            To = "test@example.com",
            Subject = "Test Subject",
            Body = "This is a test email body."
        };
       
        var result = _emailController.Sendmail(emailRequest);
        
        Assert.That(result, Is.InstanceOf<OkResult>());
        
        _mockEmailService.Verify(service => service.SendEmail(It.Is<EmailDto>(dto => dto == emailRequest)), Times.Once);
    }
}