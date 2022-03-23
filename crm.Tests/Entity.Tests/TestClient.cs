using System;
using NUnit.Framework;

namespace crm.Tests.Entity.Tests
{
    [TestFixture]
    public class TestClient
    {
        private Client _client;

        [SetUp]
        public void SetUp()
        {
            _client = new Client();
        }

        //[Test]
        //public void TestArgCostructor(long Id, string Lastname, string Firstname, ClientTypes clientTypes, Factors factors)
        //{
        //    Assert.AreEqual(1, "Dubois", "Jean", );
        //}
    }
}