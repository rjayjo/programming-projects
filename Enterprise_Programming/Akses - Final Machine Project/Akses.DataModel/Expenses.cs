using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class Expenses
    {
        [Key]
        public int EntryID { get; set; }

        public DateTime MonthAndYear { get; set; }

        public decimal RestockTotalPrice { get; set; }

        public decimal ElectricityBill { get; set; }

        public decimal WaterBill { get; set; }

        public decimal WorkersSalaries { get; set; }

        public decimal TotalCost { get; set; }

    }
}
