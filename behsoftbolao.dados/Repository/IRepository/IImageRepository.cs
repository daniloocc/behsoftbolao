using behsoftbolao.api.Models.Domain;

namespace behsoftbolao.api.Repository.IRepository;

public interface IImageRepository
{
    Task<Image> Upload(Image image);
}
