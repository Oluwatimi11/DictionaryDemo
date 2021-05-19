using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DictionaryDemo
{

    public class Program
    {
        //private static Dictionary<int, string> dict;
        [STAThread]
        static void Main()
        {
        }

        private static void Add(int strkey, int value)
        {
            IDictionary<int, string> ResponseCode = new Dictionary<int, string>();
            ResponseCode.Add(00, "Approved or completed successfully");
            ResponseCode.Add(01, "Status unknown");
            ResponseCode.Add(07, "Account name mismatch");
            ResponseCode.Add(98, "Transaction reversed");
            ResponseCode.Add(01, "Status unkown, please wait for settlement report");
            ResponseCode.Add(03, "Invalid Sender");
            ResponseCode.Add(05, "Do not honor");
            ResponseCode.Add(06, "Dormant Account");
            ResponseCode.Add(07, "Invalid Account");
            ResponseCode.Add(08, "Account Name Mismatch");
            ResponseCode.Add(09, "Request processing in progress");
            ResponseCode.Add(12, "Invalid Transaction");
            ResponseCode.Add(13, "Invalid Amount");
            ResponseCode.Add(14, "Invalid Batch Number");

            ResponseCode.Add(15, "Invalid Session or Record ID");
            ResponseCode.Add(16, "Unknown Bank Code");
            ResponseCode.Add(17, "Invalid Channel");
            ResponseCode.Add(18, "Wrong Method Call");
            ResponseCode.Add(21, "No Action Taken");
            ResponseCode.Add(25, "Unable to locate record");
            ResponseCode.Add(26, "Duplicate record");
            ResponseCode.Add(30, "Format error");
            ResponseCode.Add(34, "Suspected Fraud");
            ResponseCode.Add(35, "Contact sending bank");
            ResponseCode.Add(51, "No sufficient funds");
            ResponseCode.Add(57, "Transaction not permitted to sender");
            ResponseCode.Add(58, "Transaction not permitted on channel");
            ResponseCode.Add(61, "Transfer limit Exceeded");

            ResponseCode.Add(63, "Security violation");
            ResponseCode.Add(65, "Exceeds withdrawal frequency");
            ResponseCode.Add(68, "Response received too late");
            ResponseCode.Add(69, "Unsuccessful Account/Amount block");
            ResponseCode.Add(70, "Unsuccessful Account/Amount unblock");
            ResponseCode.Add(71, "Empty Mandate Reference Number");
            ResponseCode.Add(84, "User to be registered already exists");
            ResponseCode.Add(85, "Funding account not found");
            ResponseCode.Add(86, "Invalid receive code");
            ResponseCode.Add(87, "Invalid hash value");
            ResponseCode.Add(88, "Wrong Partner Institution at user registration");
            ResponseCode.Add(89, "Error at user registration");
            ResponseCode.Add(90, "Invalid token");
            ResponseCode.Add(91, "Beneficiary Financial Institution not available");

            ResponseCode.Add(92, "Routing error");
            ResponseCode.Add(93, "Mismatch in hash values");
            ResponseCode.Add(94, "Duplicate transaction");
            ResponseCode.Add(95, "Hash key not found");
            ResponseCode.Add(96, "System malfunction");
            ResponseCode.Add(95, "Sender's hash key not found");
            ResponseCode.Add(97, "Timeout waiting for response from destination");
            ResponseCode.Add(98, "Transaction reversed");

            foreach (KeyValuePair<int, string> kvp in ResponseCode)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.ReadLine();

            for (int i = 0; i < ResponseCode.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        ResponseCode.ElementAt(i).Key,
                                                        ResponseCode.ElementAt(i).Value);
            }
            //public static void Main(string[] args)
            //{
            //    CreateHostBuilder(args).Build().Run();
            //}

            //public static IHostBuilder CreateHostBuilder(string[] args) =>
            //    Host.CreateDefaultBuilder(args)
            //        .ConfigureWebHostDefaults(webBuilder =>
            //        {
            //            webBuilder.UseStartup<Startup>();
            //        });
        }
    }
}
