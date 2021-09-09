using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
namespace Ash.Swe.Test.Data.Entities {
    // [Table("worker")]
    public class Worker {
        // [Key]
        // [Column("id")]
        // [DataGenerated(DataGeneratedOption.Identity)]
        public long ID { get; set; }

        // [Column("first_name")]
        public string FirstName { get; set; }
        // [Column("last_name")]
        public string LastName { get; set; }
        // [Column("address")]
        public string Address { get; set; }

        // [Column("pay_hourly")]
        public double PayHourly { get; set; }

        // [Column("employee_type_id")]
        public EmployeeType EmployeeType { get; set; }

    }
}