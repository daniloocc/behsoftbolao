using behsoftbolao.web.Models.BolaoModel;
using DataAccess.Data.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;

namespace behsoftbolao.web.Controllers;

public class BolaoController : Controller
{
    private readonly IHttpClientFactory _httpClient;

    public BolaoController(IHttpClientFactory httpClient)
    {
        this._httpClient = httpClient;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<ReadBolaoDto> response = [];
        try
        {
            var client = _httpClient.CreateClient();

            var httpResponse = await client.GetAsync("https://localhost:7077/api/bolao");

            httpResponse.EnsureSuccessStatusCode();

            response.AddRange(await httpResponse.Content.ReadFromJsonAsync<IEnumerable<ReadBolaoDto>>());

            //ViewBag.Response = stringResponseBody;
        }
        catch (Exception)
        {

        }

        // get all boloes from webapi
        return View(response);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateBolaoDto bolao)
    {
        try
        {
            var client = _httpClient.CreateClient();

            bolao.DonoId = "29784a75-4721-4da4-b8b7-d167c588d5cf";

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:7077/api/bolao"),
                Content = new StringContent(JsonSerializer.Serialize(bolao), Encoding.UTF8, "application/json"),
            };

            var responseMessage = await client.SendAsync(httpRequestMessage);

            responseMessage.EnsureSuccessStatusCode();

            var body = await httpRequestMessage.Content.ReadFromJsonAsync<CreateBolaoDto>();

            if (body is not null)
            {
                return RedirectToAction("Index", "Bolao");
            }
        }
        catch (Exception)
        {
            ViewBag.Message = "Erro no modelo";
        }

        return View(bolao);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string code)
    {

        var client = _httpClient.CreateClient();

        var response =  await client.GetFromJsonAsync<ReadBolaoDto>($"https://localhost:7077/api/bolao/{code}");

        if(response is not null)
        {
            return View(response);
        }
        return View(null);
    }

    [HttpPost]
    public async Task<IActionResult> EditPost(string code)
    {

        /*
        var client = _httpClient.CreateClient();

        var request = new HttpRequestMessage
        {
            Method= HttpMethod.Post,
            RequestUri= new Uri($"https://localhost:7077/api/bolao/{code}"),
            Content=new StringContent(JsonSerializer.Serialize(), Encoding.UTF8, "")
        };

        var response = await client.GetFromJsonAsync<ReadBolaoDto>($"https://localhost:7077/api/bolao/{code}");

        if (response is not null)
        {
            return View(response);
        }
        return View(null);//*/
        throw new NotImplementedException();
    }

}
