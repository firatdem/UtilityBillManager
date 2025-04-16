namespace UtilityBillManager.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string? Account { get; set; }
        public string? Meter { get; set; }
        public double UsageKwh { get; set; }
        public double CostUsd { get; set; }
        public DateTime BillDate { get; set; }

        // Automatically calculated
        public double CostPerKwh => UsageKwh == 0 ? 0 : CostUsd / UsageKwh;
    }
}
