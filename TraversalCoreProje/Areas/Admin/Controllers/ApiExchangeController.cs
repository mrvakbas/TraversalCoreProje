using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //List<BookingExchangeViewModel2> bookingExchangeViewModels = new List<BookingExchangeViewModel2>(); 
            //var client = new HttpClient();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/meta/getExchangeRates?base_currency=TRY"),
            //    Headers =
            //        {
            //            { "x-rapidapi-key", "d7f19d1bf5msh50a60de510327f9p1566d2jsn0cf89b447924" },
            //            { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            //        },
            //};
            //using (var response = await client.SendAsync(request))
            //{
            //    response.EnsureSuccessStatusCode();
            //    var body = await response.Content.ReadAsStringAsync();
            //    var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
            //    return View(values.exchange_rates.ToList());
            //}

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "d7f19d1bf5msh50a60de510327f9p1566d2jsn0cf89b447924" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(values.exchange_rates.ToList());
            }
        }
    }
}
