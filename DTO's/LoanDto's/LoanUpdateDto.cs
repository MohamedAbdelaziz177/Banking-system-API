﻿using Banking_system.DTO_s.Custom_Validations;
using Banking_system.Enums.Loan;
using System.ComponentModel.DataAnnotations;

namespace Banking_system.DTO_s.LoanDto_s
{
    public class LoanUpdateDto
    {
        public decimal amount { get; set; }

        [CheckEnumValue(typeof(LoanStatus), ErrorMessage = "only active - paid - defaulted")]
        public string loanStatus { get; set; }

        [Range(10, 50)]
        public decimal InterestRate { get; set; }
    }
}
