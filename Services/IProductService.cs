namespace Minimal_API.Services;
using Models;
public interface IProductServices
{
    List<Product> getAll();
    Product getbyID(int id);
    Product Add(Product product);
    
}