using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using Newtonsoft.Json;
using bowlingGameWebAPI;

namespace bowlingGameWebAPITest
{
    public class bowlingGameE2ETest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;
        public bowlingGameE2ETest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        private async Task<string> PostJsonWebApiValuesResponseString( string uri,
           string jsonString)
       {
           var request = "/api/bowlingGame/";
           
           var response = await _client.PostAsync(request + uri, new StringContent(jsonString, Encoding.UTF8, "application/json"));
           response.EnsureSuccessStatusCode();
 
           return await response.Content.ReadAsStringAsync();
       }

       [Fact] 
       public async Task AfterRolling2And5ScoreIs7() 
       { 
           // Act 
           var responseString = await PostJsonWebApiValuesResponseString("roll/2", "");
           responseString = await PostJsonWebApiValuesResponseString("roll/5", responseString);
           responseString = await PostJsonWebApiValuesResponseString("score", responseString);
           int score = JsonConvert.DeserializeObject<int>(responseString);

           // Assert 
           Assert.Equal(7, score);
       }
    }
}
