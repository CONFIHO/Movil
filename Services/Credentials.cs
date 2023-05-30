using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Confiho.Services
{
    public class Credentials
    {
        public HttpClient client;
        public JsonSerializerOptions _serializerOptions;
        public string baseUrl = "http://20.169.252.136:8080/api";

        private static Credentials _instance = null;

        public static Credentials getInstance()
        {
            if(_instance == null)
            {
                _instance = new Credentials();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        private Credentials() {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }
    }
}
