
using api.test.infrastructure;
using Microsoft.EntityFrameworkCore;
using test.api.domain;
using test.api.model;


public class RetrieveProduct : IService<ProductModel>, IDisposable
{
    private DataBaseContext _context ;
    public RetrieveProduct(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<ProductModel> Execute(int  categorId)
    {
        if (categorId < 1)
        {
            return new ProductModel();
        }

        var product = await _context.Products.FirstOrDefaultAsync(x => x.CategoryId == categorId);

        var result = new ProductModel{
            Id = product.ProductId,
            Name = product.ProductName,
            CategoryName = product.Category.CategoryName,
            CategoryId = product.CategoryId
        };

        return result;

    }

       protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

}