using System;
namespace Aytam.Data
{
    public enum Gender
    {
        NotSpecified = 0,
        Male = 1,
        Female = 2,
        
        
    }
    public enum MaritalStatus
    {
        NotSpecified = 0,
        Married = 1,
        Single  = 2,
        Widowed = 3,
        Divorced = 4
    }
    public enum FinancialStatus
    {
        NotSpecified = 0,
        VeryLow = 1,
        Low = 2,
        Average = 3,
        High = 4,

    }
    public enum PaymentFrequency
    {
        Weekly = 0,
        Fortnightly = 1,
        Monthly = 2,
        Quarterly = 3,
        HalfYearly = 4,
        Annualy = 5,
    }
    public enum PaymentType
    {
        NotSpecified = 0,
        Cash = 1,
        OnlinePayment = 2,
        BankTransfer = 3,
        Cheque = 4,
    }
}
