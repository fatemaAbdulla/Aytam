namespace Aytam.Data
{
    /// <summary>
    /// types of all outgoing and incoming payments
    /// e.g. incoming: donations, sponsership payment
    ///      outgoing: stationary, sponsership payment
    /// </summary>
    public class PaymentType
    {
        public PaymentType()
        {

        }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public bool isExpense { get; set; }
    }
}