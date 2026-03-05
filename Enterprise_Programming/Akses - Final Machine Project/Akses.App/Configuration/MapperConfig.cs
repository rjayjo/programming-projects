using Akses.App.Models;
using Akses.DataModel;
using AutoMapper;

namespace Akses.App.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<MedicineInventory, MedicineInventoryVM>().ReverseMap();
            CreateMap<OrderHeader, PurchaseOrderVM>().ReverseMap();

        }
    }
}
