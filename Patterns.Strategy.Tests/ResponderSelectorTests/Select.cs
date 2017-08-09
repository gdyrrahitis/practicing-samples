namespace Patterns.Strategy.Tests.ResponderSelectorTests
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using NUnit.Framework;
    using PartialTypeNameRoleHint;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class Select
    {
        private List<IResponder> _mocks;

        [SetUp]
        public void Setup()
        {
            _mocks = new List<IResponder> {
                new OkResponder(),
                new NotFoundResponder(),
                new InternalServerErrorResponder()
            };
        }

        [Test]
        public void ThrowsInvalidOperationExceptionForEmptyCandidatesList()
        {
            // Arrange
            var selector = new ResponderSelector(new List<IResponder>());

            // Act | Assert
            Throws<InvalidOperationException>(() => selector.Select(HttpStatusCode.OK));
        }

        [TestCase(typeof(OkResponder), HttpStatusCode.OK, "Ok_Result")]
        [TestCase(typeof(NotFoundResponder), HttpStatusCode.NotFound, "NotFound_Result")]
        [TestCase(typeof(InternalServerErrorResponder), HttpStatusCode.InternalServerError, "InternalServerError_Result")]
        public void ReturnsOkResponderForOkCode(Type type, HttpStatusCode code, string expected)
        {
            // Arrange
            var selector = new ResponderSelector(_mocks);

            // Act
            var result = selector.Select(code);

            // Assert
            IsInstanceOf(type, result);
            AreEqual(expected, result.Content());
        }
    }
}