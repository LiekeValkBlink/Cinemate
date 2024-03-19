using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;


namespace Cinemate.API.Tests.Controllers;

[TestFixture]
public class MovieControllerTest
{
    private Mock<IFileStorageService> _mockFileStorageService;
    private MovieController _controller;

    [SetUp]
    public void SetUp()
    {
        _mockFileStorageService = new Mock<IFileStorageService>();
        _mockFileStorageService.Setup(s => s.SaveFileAsync(It.IsAny<IFormFile>()))
            .ReturnsAsync("http://localhost/Images/posters/testImage.jpg");

        
        _controller = new MovieController(_mockFileStorageService.Object);
        
    }

    [Test]
    public async Task UploadFile_WithValidFile_ReturnsOkWithImageUrl()
    {
        var fileMock = new Mock<IFormFile>();
        fileMock.Setup(_ => _.FileName).Returns("testImage.jpg");

        var result = await _controller.UploadFile(fileMock.Object);

        Assert.That(result, Is.InstanceOf<OkObjectResult>());
        var okResult = result as OkObjectResult;
        Assert.That(okResult?.Value.ToString(), Is.EqualTo("http://localhost/Images/posters/testImage.jpg"));
    }
    
    public class MovieController : ControllerBase
    {
        private readonly IFileStorageService _fileStorageService;

        public MovieController(IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
        }

        [HttpPost("image")]
        public async Task<ActionResult> UploadFile(IFormFile file)
        {
            if (file == null)
                return BadRequest("File is required");
        
            var imageUrl = await _fileStorageService.SaveFileAsync(file);

            return Ok(imageUrl);
        }
    }
    
    public class FileStorageService : IFileStorageService
    {
        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var fileName = file.FileName;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images\posters", fileName);
        
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            
            string imageUrl = $"http://localhost/Images/posters/{fileName}";
            return imageUrl;
        }
    }
    
    public interface IFileStorageService
    {
        Task<string> SaveFileAsync(IFormFile file);
    }

}



