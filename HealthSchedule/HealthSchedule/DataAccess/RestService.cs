using RestSharp;
using System.Threading.Tasks;

namespace HealthSchedule.DataAccess
{
    public class RestService
    {
        public RestClient client;
        public RestService()
        {
            client = new RestClient(Constants.RestUrl);
        }

        public async Task<dynamic> Execute(string route, dynamic data, Method method)
        {
            var request = new RestRequest(route, method);
            IRestResponse t =   client.ExecuteTaskAsync(request,data);
            return t.Content;
        }
    }
}
