using Midterm_Project.Models;
using System.Text.Json;

namespace Midterm_Project.Services
{
    /// <summary>
    /// public class GenderApiService used to create HttpClient object and use it to physically collect the json data from the API
    /// </summary>
    public class GenderApiService : IGenderApiService
    {
        // create a public static readonly HttpClient client to create a BaseAddress later
        private static readonly HttpClient client;
        // static GenderApiService method 
        static GenderApiService()
        {
            // set client to a new HttpClient
            client = new HttpClient()
            {
                // set BaseAddress as a new url with the genderize url base
                BaseAddress = new Uri("https://api.genderize.io?name=")
            }; // end of client setting
        } // end of GenderApiService method
        // public async task using GetInputModel for the GetName method using a name parameter
        public async Task<GetInputModel> GetName(string name)
        {
            // set variable url as a formatted string with the BaseAddress with the addition of the name arguement
            var url = string.Format($"https://api.genderize.io/?name={name}"); 
            // set result variable as a new GetInputModel
            var result = new GetInputModel();
            // set response variable as an await client using the GetAsync property of the url variable
            var response = await client.GetAsync(url);
            // if statement for checking if the response was successful using the IsSuccessStatusCode property
            if (response.IsSuccessStatusCode)
            {
                // set variable stringResponse as an await response using the content and ReadAsStringAsyn properties
                var stringResponse = await response.Content.ReadAsStringAsync();
                // set result as a json serializer to collect the json data from the API
                result = JsonSerializer.Deserialize<GetInputModel>(stringResponse, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            } // end of if statement
            // else statement for if response wasn't succesful
            else
            {
                // throw a new exception request using the response's property ReasonPhrase
                throw new HttpRequestException(response.ReasonPhrase);
            } // end of else statement
            // resturn the result variable
            return result;
        } // end of GetName method
    } // end of GenderApiService class
}
