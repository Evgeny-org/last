using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
//using System.Windows.Forms;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.icndb.com/jokes/random";
            string response;

            HttpWebRequest httpWebRequest = (HttpWebRequest)httpWebRequest.create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream)))
            {
                response = streamReader.ReadToEnd();
            }

            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
