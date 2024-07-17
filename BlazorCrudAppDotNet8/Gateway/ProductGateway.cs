using BlazorCrudAppDotNet8.Models;

namespace BlazorCrudAppDotNet8.Gateway
{
    public class ProductGateway
    {
        ApplicationDBContext _db = new ApplicationDBContext();

        public bool Add(Product product)
        {
            _db.Products.Add(product);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }
        public List<Product> GetAll() 
        { 
            return _db.Products.ToList();
        }
        public Product GetById(int id) 
        {
            return _db.Products.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Product product)
        {
            _db.Products.Update(product);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
