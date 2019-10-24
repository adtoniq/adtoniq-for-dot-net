using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace AdtoniqForDotNet
{
    public class Adtoniq
    {
        private string apiKey;
        private string javaScript = "";
        private readonly string version = ".net 1.0.1";

        public string JavaScript
        {
            get { return javaScript;  }
            set { javaScript = value; }
        }
        public Adtoniq(string apiKey)
        {
            this.apiKey = apiKey;
            getLatestJavaScript();
        }

        public void getLatestJavaScript(String nonce = "")
        {
            WebRequest request = WebRequest.Create("https://integration.adtoniq.com/api/v1/?operation=update&apiKey=" + apiKey + "&version=" + version + "&nonce=" + nonce);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string ret = reader.ReadToEnd();
            reader.Close();

            if (ret.Length > 0)
            {
                javaScript = ret;
                // If you must take some action to update your page caches, implement the updatePageCache() function and put that logic there.
                // updatePageCache();
            }
        }
    }
}