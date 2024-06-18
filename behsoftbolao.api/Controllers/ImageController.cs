using behsoftbolao.api.Data.Dto.Image;
using behsoftbolao.api.Models.Domain;
using behsoftbolao.api.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace behsoftbolao.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    private readonly IImageRepository _imageRepository;

    public ImageController(IImageRepository image)
    {
        this._imageRepository = image;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto request)
    {
        ValidateFileUpload(request);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var imageDomainModel = new Image
        {
            File = request.File,
            FileExtension = Path.GetExtension(request.File.FileName),
            FileSizeInBytes = request.File.Length,
            FileName = request.FileName,
            FileDescription = request.FileDescription
        };

        await _imageRepository.Upload(imageDomainModel);

        return Ok(imageDomainModel);

    }

    private void ValidateFileUpload(ImageUploadRequestDto request)
    {
        var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png"};

        if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
        {
            ModelState.AddModelError("file", "Unsupported File Extension");
        }

        if(request.File.Length > 10485760) // 10MB
        {
            ModelState.AddModelError("file", "File size more then 10MD, please upload a smaller size file.");
        }
    }
}
