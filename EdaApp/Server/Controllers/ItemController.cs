using EdaApp.Shared;
using Microsoft.AspNetCore.Mvc;
using EdaApp.Client.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace EdaApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly List<Item> items = new List<Item>() {
        new Item()
        {
            name = "Помидоры",
            price = 80,
            img = "1.png"
        },

        new Item()
        {
            name = "Мясо",
            price = 600,
            img = "2.png"
        },

        new Item()
        {
            name = "Картофель",
            price = 60,
            img = "3.png"
        },

        new Item()
        {
            name = "Капуста",
            price = 60,
            img = "4.png"
        },

        new Item()
        {
            name = "Огурцы",
            price = 80,
            img = "5.png"
        },

        new Item()
        {
            name = "Помидоры",
            price = 55,
            img = "1.png"
        },

        new Item()
        {
            name = "Бананы",
            price = 120,
            img = "6.png"
        },

        new Item()
        {
            name = "Лук",
            price = 40,
            img = "7.png"
        },

        new Item()
        {
            name = "Нуд",
            price = 120,
            img = "14.png"
        },


    };

        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            string path = "C:\\Users\\79103\\source\\repos\\EdaApp\\EdaApp\\Server\\kod11_v3_task3.json";
            return System.IO.File.ReadAllText(path);
        }
    }
}