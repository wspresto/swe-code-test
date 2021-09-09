using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
namespace Ash.Swe.Test.Data.Entities {
    // [Table("expense_account")]
    public class ExpenseAccount {
        // [Key]
        // [MaxLength(50)]
        // [Column("worker_id")]
        public long WorkerID { get; set; }

        // [Column("max_expense")]
        public double MaxExpense { get; set; }

    }
}