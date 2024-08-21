using System.Text.Json.Serialization;

namespace Api.Models;

public partial class EmployeeAccountForm
{
    public int? EmployeeId { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmployeePosition { get; set; }
    public string? EmployeeStatus { get; set; }
    public int? EmployeePositionId { get; set; }
    public int? EmployeeStatusId { get; set; }
    public ICollection<PotionListing>? Potions { get; set; } = new List<PotionListing>();
    public ICollection<ReceiptListing>? Receipts { get; set; } = new List<ReceiptListing>();

    public static List<PotionListing> BuildPotionsList(Employee employee)
    {
        List<PotionListing> potions = [];
        foreach (Potion p in employee.Potions)
        {
            potions.Add(new()
            {
                PotionId = p.PotionId,
                Name = p.Product.Name,
                Description = p.Product.Description,
                Price = p.Product.Price,
                Cost = p.Product.Cost,
                CurrentStock = p.Product.CurrentStock,
                Image = p.Product.Image,
                Active = p.Product.Active,
                PotionEffects = PotionListing.BuildEffectsList(p)
            });
        }

        return potions;
    }

    public static List<ReceiptListing> BuildReceiptsList(Employee employee)
    {
        List<ReceiptListing> receipts = [];
        foreach (Receipt r in employee.Receipts)
        {
            receipts.Add(new()
            {
                ReceiptId = r.ReceiptId,
                ReceiptNumber = r.ReceiptNumber,
                Order = r.Order.OrderNumber,
                DateFulfilled = r.DateFulfilled,
                Employee = $"{r.Employee.FirstName} {r.Employee.LastName}",
                Customer = $"{r.Order.Customer.FirstName} {r.Order.Customer.LastName}",
                Total = r.Order.Total
            });
        }

        return receipts;
    }
}
