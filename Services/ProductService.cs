namespace Minimal_API.Services;
using Models;

public class ProductService:IProductService
{

    private readonly List<Product> _products = new List<Product>();

    public List<Product> getAll()
    {
        return _products;
    }

    public Product getbyID(int id)
    {

        return _products.FirstOrDefault(p => p.Id == id);

    }

    public Product Add(Product product)
    {
        product.Id = _products.Count + 1;
        
        _products.Add(product);

        return product;
    }
}