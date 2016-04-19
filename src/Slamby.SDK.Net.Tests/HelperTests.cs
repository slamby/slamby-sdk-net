using System;
using Slamby.SDK.Net.Helpers;
using Xunit;

namespace Slamby.SDK.Net.Tests
{
    public class HelperTests
    {
        [Fact]
        public void RawMessagePublisher_should_not_accept_null_reference_subscriber()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => RawMessagePublisher.Instance.AddSubscriber(null));
            Assert.Throws<ArgumentNullException>(() => RawMessagePublisher.Instance.RemoveSubscriber(null));
        }
    }
}
