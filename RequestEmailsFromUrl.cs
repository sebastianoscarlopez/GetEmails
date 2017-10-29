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
                // Read the content.  
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                // Regular expression search emails
                var regExp = new Regex(@"([_a-z0-9-]+[\._a-z0-9-]*@[_a-z0-9-]+[\._a-z0-9-]*\.[a-z]{2,4})");
                var matches = regExp.Matches(responseFromServer);
                // To string array
                var emails = (from m in matches.Cast<Match>()
                             select m.Captures[0].Value).ToArray();
                return emails;

            }catch(Exception)
            {
                return null;
            }
        }
    }
}
