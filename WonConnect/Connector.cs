using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace WonConnect
{
    internal class Connector
    {
        public string url = "http://www.wonaruto.com/login.php";

        public int connect(string username, string password)
        {
            try
            {
                var client = new WebClient();
                client.InitializeLifetimeService();

                var values = new NameValueCollection();
                byte[] response;
                values["redirec"] = "/";
                values["mpseudo"] = username;
                values["mpass"] = password;

                response = client.UploadValues(url, values);

                if (Encoding.Default.GetString(response).StartsWith("<html><head>"))
                    return 1;
                else
                    return 0;
            }
            catch (WebException ex)
            {               
                return -1;
            }
        }
    }
}
