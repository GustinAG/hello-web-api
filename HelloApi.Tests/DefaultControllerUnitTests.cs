using System;
using FluentAssertions;
using HelloApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloApi.Tests
{
    [TestClass]
    public class DefaultControllerUnitTests
    {
        [TestMethod]
        public void Get_ShouldReturnSomeContent()
        {
            // Arrange
            string text;
            using (var controller = new DefaultController())
            {
                // Act
                text = controller.Get();
            }

            // Assert
            text.Should().NotBeNullOrWhiteSpace("text should contain something");
        }
    }
}
