using Daltonsbaker.Com.Common;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Daltonsbaker.Com.Pages
{
    public class FetchDataBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
