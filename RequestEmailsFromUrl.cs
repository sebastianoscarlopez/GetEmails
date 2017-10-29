using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace GetEmail
{
    class RequestEmailsFromUrl
    {
        public string[] Request(string url)
        {
            try
            {
                // Create a request for the URL.   
                WebRequest request = WebRequest.Create(url);
                // If required by the server, set the credentials.  
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.  
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.  
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Clean up the streams and the response.  
                reader.Close();
                response.Close();

                var regExp = new Regex("[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})");

                var matches = regExp.Matches(responseFromServer);
                var emails = matches[0];
                return null;

            }catch(Exception)
            {
                return null;
            }
        }
    }
}
