namespace Web.Api.Samples.Controllers.CustomValuesControllerTests
{
    using System.Web.Http.Controllers;
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        private CustomValuesController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new CustomValuesController();
        }

        [Test]
        public void InstanceIsDefined()
        {
            // Assert
            Assert.IsNotNull(_controller);
        }

        [Test]
        public void IsOfTypeIHttpController()
        {
            // Assert
            Assert.IsInstanceOf<IHttpController>(_controller);
        }
    }
}