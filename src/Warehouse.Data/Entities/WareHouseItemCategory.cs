// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Warehouse.Data.Entities
{
    public partial class WareHouseItemCategory : BaseEntity
    {
        public string? Code { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string? Path { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}