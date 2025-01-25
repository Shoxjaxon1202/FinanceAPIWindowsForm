namespace FinanceAPI.Entities
{
    public class Income
    {
        public int IncomeID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Source { get; set; }
        public string? Description { get; set; }
    }
}
