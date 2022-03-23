using crm.Services.Implements;
using NUnit.Framework;

namespace crm.Tests.Services.Tests.Implements.Tests
{
    [TestFixture]
    public class TestFactorService
    {
        private FactorService _factorService;

        [SetUp]
        public void SetUp()
        {
            _factorService = new FactorService();
        }
    }
}