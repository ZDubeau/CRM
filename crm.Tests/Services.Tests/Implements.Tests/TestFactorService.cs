using dotNetApp.Services.Implements;
using NUnit.Framework;

namespace dotNetApp.Tests.Services.Tests.Implements.Tests
{
    [TestFixture]
    public class TestFactorService
    {
        private  FactorService _factorService;

        [SetUp]
        public void SetUp()
        {
            _factorService = new FactorService();
        }
    }
}