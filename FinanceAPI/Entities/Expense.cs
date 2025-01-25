namespace FinanceAPI.Entities
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
    }
}
