using business.Back;
using business.div;
using business.Join;
using business.business;
using CMS.Data;
using CMS.Models.Repository;
using CMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.div;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace CMS.Controllers
{
    [ApiController]
    [Route("api/chatgpt")]
    public class ChatGptController : ControllerBase
    {
        
        public IConfiguration Configuration { get; }

        public ChatGptController( IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        
        public async Task<ChatGptViewModel> Get([FromBody] ChatGptInputModel chat, [FromServices] IConfiguration configuration)
        {
            var token = Configuration.GetConnectionString("Token");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
             new AuthenticationHeaderValue("Bearer", token);
           
             var requestBody = JsonConvert.SerializeObject(chat);
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://api.openai.com/v1/completions", content);
            var result = (ChatGptViewModel) await response.Content.ReadAsAsync(typeof(ChatGptViewModel));

            return result;
        }
       
       

    }
}
