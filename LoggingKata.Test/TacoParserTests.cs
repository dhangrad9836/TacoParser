using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange - create the object
            var longitudeParser = new TacoParser();

            //Act - call the method in the TacoParser class
            //remember that var actual is an ITrackable which contains Location which that belongs to the Point.cs class which contains Longitude
            //so you can do actual.Location.Longitude
            var actual = longitudeParser.Parse(line);

            //Assert - here we pass in the expected and we need to drill down to the 
            // actual.Location.Longitude in order to compare both as doubles b/c acutal is an ITrackable
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude

    }
}
