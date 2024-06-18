using behsoftbolao.api.Data;
using behsoftbolao.api.Models.Domain;
using behsoftbolao.api.Repository.IRepository;

namespace behsoftbolao.api.Repository;

public class LocalImageRepository : IImageRepository
{
    private readonly IWebHostEnvironment _environment;
    private readonly IHttpContextAccessor _accessor;
    private readonly BolaoDbContext _db;

    public LocalImageRepository(
        IWebHostEnvironment environment, 
        IHttpContextAccessor accessor,
        BolaoDbContext db)
    {
        this._environment = environment;
        this._accessor = accessor;
        this._db = db;
    }

    public async Task<Image> Upload(Image image)
    {
        var localFilePath = Path.Combine(_environment.ContentRootPath, "Images", $"{image.FileName}{image.FileExtension}");

        // Upload image to local path
        using var stream = new FileStream(localFilePath, FileMode.Create);
        await image.File.CopyToAsync(stream);

        string scheme = _accessor.HttpContext.Request.Scheme;
        string host = _accessor.HttpContext.Request.Host.ToString();
        string pathBase = _accessor.HttpContext.Request.PathBase;

        var urlFilePath = $"{scheme}://{host}{pathBase}/Images/{image.FileName}{image.FileExtension}";

        image.FilePath = urlFilePath;

        // add image to image table
        await _db.Images.AddAsync(image);
        await _db.SaveChangesAsync();

        return image;
    }
}
