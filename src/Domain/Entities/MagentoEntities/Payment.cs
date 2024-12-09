

namespace Domain.Entities.MagentoEntities
{
    public class Payment
    {
        //public List<object>? additional_information { get; set; }
        public string cc_exp_year { get; set; } = string.Empty;
        public string cc_last4 { get; set; } = string.Empty;
        public double? amount_paid { get; set; }
        public double? base_amount_paid { get; set; }
        public string cc_exp_month { get; set; } = string.Empty;
        public string cc_type { get; set; } = string.Empty;

    }
}