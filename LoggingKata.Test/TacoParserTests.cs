using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell")]
        [InlineData("34.035985, -84.683302, Taco Bell")]
        [InlineData("34.087508, -84.575512, Taco Bell")]
        public void ShouldParse(string line)
        {
            //Arrange
            TacoParser tacoparser = new TacoParser();

            //Act
            ITrackable actual = tacoparser.Parse(str);

            //Assert
            Assert.NotNull(actual);
            
            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse

            //Arrange
            TacoParser tacoParser = new TacoParser();

            //Act
            ITrackable actual = tacoParser.Parse(str);

            //Assert
            Assert.Null(actual);
        }
    }
}
