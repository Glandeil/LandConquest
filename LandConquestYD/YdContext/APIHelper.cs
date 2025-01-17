﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Security.Cryptography;

namespace LandConquestYD.YdContext
{
    public static class APIHelper
    {
        public static string GetRandomName(bool male)
        {
            HttpMethod method = HttpMethod.Get;
            HttpClient httpClient = new HttpClient();

            string requestUri = "http://random-data-api.com/api/name/random_name";

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(method, requestUri);
            dynamic nameObject = JObject.Parse(httpClient.SendAsync(httpRequestMessage).Result.Content.ReadAsStringAsync().Result);

            if (!male)
            {
                return nameObject.female_first_name;
            }
            else
            {
                return nameObject.male_first_name;
            }
            
        }
    }
}
