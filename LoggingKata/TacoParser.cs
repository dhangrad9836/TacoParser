namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','....cells is an array of 3 items (lat,lon,taco name)
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null - remember that logger.LogWarning
                //comes from the object TacoLogger which the method comes from the interface
                //ILog
                logger.LogWarning("less than three items. incomplete data.");
                return null;
            }

            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var latitude = double.Parse(cells[0]);


            // DONE TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var longitude = double.Parse(cells[1]);


            // DONE TODO: Grab the name from your array at index 2
            // No need to do any conversion b/c we will use it as a string
            var name = cells[2];

            // DONE - TODO: Create a TacoBell class
            // that conforms to ITrackable


            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 
            //why we did this b/c we cannot just store the latitude and longitude inside 
            //the tacoBell instance. we need to directly access the Point struct and 
            //assign the two values lat and long...we will assign point below to the tacoBell instance
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;

            // TODO: Create an instance of the TacoBell class
            // TODO: Set the values of the class correctly (Name and Location)
            // notice that we accessed the .Location and set it equal to the point referece we created above that holds both latitude and longitude

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return tacoBell;
        }
    }
}
