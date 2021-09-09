using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
namespace Ash.Swe.Test.Data.Entities {
    // [Table("employee_type")]
    public class EmployeeType {
        // [Key]
        // [MaxLength(50)]
        // [Column("id")]
        public string ID { get; set; }

        // [Column("title")]
        public string Title { get; set; }        

        // [Column("is_salaried")]
        public bool IsSalaried { get; set; }

    }
}