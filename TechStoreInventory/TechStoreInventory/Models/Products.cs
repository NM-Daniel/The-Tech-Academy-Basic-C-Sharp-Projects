namespace TechStoreInventory.Models
{
    public class Products
    {
        public Guid Id { get; set; } //globally unique identifier. 128 bit int that's unique
        public required string Product { get; set; }
        public string? Description { get; set; } //? --> It is nullable
        public string? Type { get; set; }
        public decimal? Price { get; set; }

    }
}
