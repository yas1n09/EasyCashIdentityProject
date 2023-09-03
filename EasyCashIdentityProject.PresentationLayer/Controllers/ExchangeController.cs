﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            
            #region
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?to=TRY&from=USD&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "160a021ed4mshfc060708cb61716p12107djsnca743025e83f" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToTry = body;
            }
            #endregion



            #region
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?to=TRY&from=EUR&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "160a021ed4mshfc060708cb61716p12107djsnca743025e83f" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ViewBag.EurToTry = body2;
            }

            #endregion

            #region
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?to=TRY&from=GBP&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "160a021ed4mshfc060708cb61716p12107djsnca743025e83f" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ViewBag.GbpToTry = body3;

                #endregion
            }
            #region
            var client4 = new HttpClient();
            var request4 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?to=EUR&from=USD&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "160a021ed4mshfc060708cb61716p12107djsnca743025e83f" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response4 = await client4.SendAsync(request4))
            {
                response4.EnsureSuccessStatusCode();
                var body4 = await response4.Content.ReadAsStringAsync();
                ViewBag.UsdToEur = body4;

                #endregion
            }

                return View();
        }
    }
}