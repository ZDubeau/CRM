using System;
using crm.Services.Interface;

namespace crm.Services.Implements
{
    public class FactorService : IFactorService
    {
        Client client = new Client();
        Factor factor = new Factor();

        public void AllPaid()
        {
            if (factor.Clients != null)
            {
                string paid = factor.Status;

                if (paid == "paid")
                {
                    Console.WriteLine(paid);
                }
            }
        }
    }
}