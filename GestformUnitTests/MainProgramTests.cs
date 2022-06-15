using GestForm;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace GestformUnitTests
{
    public class MainProgramTests
    {
        [Fact]
        public void MainTest()
        {
            // Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            Program.Main();

            // Assert
            string[] outputLines = stringWriter
                .ToString()
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.NotNull(outputLines);
            Assert.Equal(Constants.ListLength, outputLines.Count());
            Assert.True(outputLines.All(line => !string.IsNullOrEmpty(line)), "The output must not be null or empty");
            Assert.True(outputLines.All(line => line.IsValueValid()), "The output must be in the right format");
        }
    }
}
