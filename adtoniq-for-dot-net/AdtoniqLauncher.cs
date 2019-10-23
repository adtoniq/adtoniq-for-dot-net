using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdtoniqForDotNet
{
    public class AdtoniqLauncher
    {
        private static string apiKey = "put-your-api-key-here";

        public static Adtoniq adtoniq = new Adtoniq(apiKey);
    }
}