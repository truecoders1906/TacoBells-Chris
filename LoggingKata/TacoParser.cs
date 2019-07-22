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

            line = "34.073638,-84.677017,Taco Bell Acwort... (Free trial* Add to Cart for a full POI info)";
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');
            double lattitude, longitude;
            double.TryParse(cells[0], out lattitude);
            double.TryParse(cells[1], out longitude);
            string name = cells[2];
            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
            }
            logger.LogInfo("Begin parsing");

            // Do not fail if one record parsing fails, return null
            return null; // TODO Implement
        }
    }
}