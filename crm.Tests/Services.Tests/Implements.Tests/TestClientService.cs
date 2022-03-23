using dotNetApp.Services.Implements;
using NUnit.Framework;

namespace dotNetApp.Tests.Services.Tests.Implements.Tests
{
    [TestFixture]
    public class TestClientService
    {
        private ClientService _clientService;

        [SetUp]
        public void SetUp()
        {
            _clientService = new ClientService();
        }

        [Test]
        public void TestTotalCP()
        {
            _clientService.listClient._clientList.Add("a");
            _clientService.listClient._clientList.Add("b");

            _clientService.listProspect._prospectList.Add("c");
            _clientService.listProspect._prospectList.Add("d");

            var total = _clientService.TotalCP();

            Assert.AreEqual(4, total);
        }

    }
}