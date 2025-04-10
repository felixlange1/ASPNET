using System.Collections.Generic;
using Testing.Models;

namespace Testing;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    public Product GetProduct(int id);
    public void UpdateProduct(Product product);
    public Product AssignCategory();
    public IEnumerable<Category> GetCategories();
    public void InsertProduct(Product productToInsert);
    public void DeleteProduct(Product productToDelete);
}