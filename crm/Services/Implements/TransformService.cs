using System;
using System.Diagnostics;
using crm.Services.Interface;

namespace crm.Services.Implements
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class TransformService : ITransformService
    {
        readonly Client client = new();
        readonly Prospect prospect = new();
        readonly Offer offer = new();
        private readonly string isAccepted = "Accepted";
        readonly string factorStatus = new Factor().Status;

        DateTime yesterday = DateTime.Now.Date.AddDays(-1);

        public void TransformPtC()
        {
            if (prospect.ContactDate >= yesterday
                && prospect.Offers.Factors != null
                && factorStatus == isAccepted)
            {
                Console.WriteLine("Transform Prospect to Client");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}