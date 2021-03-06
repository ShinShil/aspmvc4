﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
            var result = client.GetAsync(new Uri("http://localhost:27261/api/videos")).Result;
            if(result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var doc = XDocument.Load(result.Content.ReadAsStreamAsync().Result);
                var ns = (XNamespace)"http://schemas.datacontract.org/2004/07/_04_WebAPI.Models";
                foreach(var title in doc.Descendants(ns + "Title"))
                {
                    Console.WriteLine(title.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
