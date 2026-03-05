using AutoMapper;
using Bernardo___ENTPROG___OTIS1;
using Suppliers.App.Models;

namespace Suppliers.App.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Supplier, SupplierVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
