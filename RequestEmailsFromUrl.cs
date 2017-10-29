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
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                var regExp = new Regex(@"([_a-z0-9-]+[\._a-z0-9-]*@[_a-z0-9-]+[\._a-z0-9-]*\.[a-z]{2,4})");
                var matches = regExp.Matches(responseFromServer);
                var emails = (from m in matches.Cast<Match>()
                             select m.Captures[0].Value)
                             .Distinct().ToArray();
                return emails;

            }catch(Exception)
            {
                return null;
            }
        }
    }
}
