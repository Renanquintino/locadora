

using System.Globalization;

namespace Pereirão.Entities
{
    class Invoice
    {
        public Client Client { get; set; }
        public double BasicPayment { get; set; }
        public double AdministrativeTax { get; set; }
        public double TotalPayment
        {
            get { return BasicPayment + AdministrativeTax; }
        }

        public Invoice(double basicPayment, double administrativeTax)
        {
            BasicPayment = basicPayment;
            AdministrativeTax = administrativeTax;
        }
        public override string ToString()
        {
            return 
                " Payment Basic: $ "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\n Tax Adm.: $  "
                + AdministrativeTax.ToString("F2", CultureInfo.InvariantCulture)
                + "\n Total: $"
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
