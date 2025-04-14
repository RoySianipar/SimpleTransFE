namespace SempurnaFE.Models
{
    public class TransactionDTO
    {
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } = "";
        public decimal Amount { get; set; }
        public decimal? Balance { get; set; }
        public bool IsFailedWithdrawal { get; set; }
    }
}
