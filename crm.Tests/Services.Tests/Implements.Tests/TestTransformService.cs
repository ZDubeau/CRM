using dotNetApp.Services.Implements;
using NUnit.Framework;

namespace dotNetApp.Tests.Services.Tests.Implements.Tests
{
    [TestFixture]
    public class TestTransformService
    {
        private TransformService _transformService;

        [SetUp]
        public void SetUp()
        {
            _transformService = new TransformService();
        }
    }
}