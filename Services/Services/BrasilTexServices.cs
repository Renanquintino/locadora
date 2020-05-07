

namespace Pereirão.Services.Services
{
    class BrasilTexServices:ITaxservice
    {
        public double Tax(double amount)
        {
            if (amount <100.0)
            {
                return amount * 0.12;
            }
            else
            {
                return amount *0.9;
            }
        }

    }
}
