﻿using Banking_system.Enums.Loan;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_system.Model
{
    public class Loan
    {
        
        public int Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public int customerId { get; set; }

        public decimal amount { get; set; }

        public LoanStatus loanStatus { get; set; }

        public decimal InterestRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

       // public Customer customer { get; set; }
    }
}
