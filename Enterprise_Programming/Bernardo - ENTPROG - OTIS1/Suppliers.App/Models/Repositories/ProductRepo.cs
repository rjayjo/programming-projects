using Bernardo___ENTPROG___OTIS1;
using Generic.DataModel.Repository;

namespace Suppliers.App.Models.Repositories

{
    public class ProductRepo : GenericRepo<Product>, IProductRepo
    {
       
        public ProductRepo(AppDbContext context) : base(context)
        {
            
        }

        
    }
}
