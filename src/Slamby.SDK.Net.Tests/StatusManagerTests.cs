using System.Threading.Tasks;
using Slamby.SDK.Net.Managers;
using Xunit;

namespace Slamby.SDK.Net.Tests
{
    public class StatusManagerTests
    {
        private readonly Configuration config;

        public StatusManagerTests()
        {
            config = TestHelper.GetConfiguration();
        }

        [Fact]
        public async Task Status_result_should_be_returned_succesfully()
        {
            // Arrange
            var manager = new StatusManager(config);

            //Act
            var response = await manager.GetStatusAsync();

            // Assert
            Assert.NotNull(response);
            Assert.True(response.IsSuccessFul);
            Assert.NotNull(response.ResponseObject);
        }
    }
}
