using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        //as before create the primary key of the class
        [Key]
        public int TransactionId { get; set; }

        //CategoryId needs to be saved here which is a forieng
        public int Amount { get; set; }
        public string? Note { get; set; }

        public DateTime date { get; set; } = DateTime.Now;
    
    }
}
