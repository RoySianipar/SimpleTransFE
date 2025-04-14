namespace SempurnaFE.Models
{
    public class Transaction
    {
        public string AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal BalanceAfterTransaction { get; set; }
    }
}
