namespace WebApiToTestsOn.Tests.Controllers.CustomValuesControllerTests
{
    using System.Web.Http.Controllers;
    using NUnit.Framework;
    using WebApiToTestsOn.Controllers;
    using static NUnit.Framework.Assert;

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
            IsNotNull(_controller);
        }

        [Test]
        public void IsOfTypeIHttpController()
        {
            // Assert
            IsInstanceOf<IHttpController>(_controller);
        }
    }
}