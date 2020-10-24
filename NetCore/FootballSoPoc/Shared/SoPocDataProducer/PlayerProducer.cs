using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoPocDataProducer
{
    public static class PlayerProducer
    {
        public static List<string> GetAllFirstNames()
        {
            var result = new List<string> 
            {
                "Arne",
                "August",
            };

            return result;
        }

        public static List<string> GetAllSurnames()
        {
            var result = new List<string>
            {
                "Swinton",
                "Andersen",
            };

            return result;
        }
    }
}
