using GestForm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace GestformUnitTests
{
    public class GestFormHandlerTests
    {
        readonly IGestFormHandler gestForm = new GestFormHandler();

        [Fact]
        public void GestFormDisplay_WhenIntegersIsNull_ThenWriteNothing()
        {
            // Arrange
            List<int> integers = null;

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            gestForm.GestFormDisplay(integers);

            // Assert
            Assert.Equal("", stringWriter.ToString());
        }

        [Fact]
        public void GestFormDisplay_WhenIntegersIsEmpty_ThenWriteNothing()
        {
            // Arrange
            List<int> integers = new List<int>();

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            gestForm.GestFormDisplay(integers);

            // Assert
            Assert.Equal("", stringWriter.ToString());
        }

        [Fact]
        public void GestFormDisplay_WhenIntegersHasvalues_Nominal()
        {
            // Arrange
            List<int> integers = new List<int>() { 2, 3, 5, 15 };

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            gestForm.GestFormDisplay(integers);

            // Assert
            string[] outputLines = stringWriter
                .ToString()
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.NotNull(outputLines);
            Assert.Equal(4, outputLines.Count());

            Assert.Equal("2", outputLines[0]);
            Assert.Equal(Constants.Geste, outputLines[1]);
            Assert.Equal(Constants.Forme, outputLines[2]);
            Assert.Equal(Constants.Gestform, outputLines[3]);
        }
    }
}
