using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http.Filters;
using HttpClient = Windows.Web.Http.HttpClient;

namespace Privat24Info.Services
{
    public class DataServicecs
    {
        private readonly HttpClient _client;

        public DataServicecs(HttpClient client)
        {
            _client = client;
        }
    }
}
