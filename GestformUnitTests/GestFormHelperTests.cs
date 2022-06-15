using GestForm;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GestformUnitTests
{
    public class GestFormHelperTests
    {
        [Fact]
        public void CreateRandomIntegerListTest()
        {
            // Act
            List<int> integers = GestFormHelper.CreateRandomIntegerList();

            // Assert
            Assert.NotNull(integers);
            Assert.Equal(Constants.ListLength, integers.Count);
            Assert.True(integers.All(i => i >= Constants.MinValue && i <= Constants.MaxValue));
        }
    }
}
