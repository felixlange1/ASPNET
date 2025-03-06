using System.Collections.Generic;
using System.Data;
using Dapper;
using Testing.Models;

namespace Testing;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _connection;

    public ProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<Product> GetAllProducts()
    {
        return _connection.Query<Product>("SELECT * FROM Products");
    }

    public Product GetProduct(int id)
    {
        return _connection.QuerySingle<Product>($"SELECT * FROM Products WHERE ProductID = @id", new { id = id });
    }
}