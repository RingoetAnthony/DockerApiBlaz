using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BlazorApp1.Pages
{
    public partial class ProductList
    {
        public List<ProductModel> ListeProducts { get; set; }
        [Inject]
        public HttpClient Client { get; set; }

        protected override async Task OnInitializedAsync() 
        {
            ListeProducts = new List<ProductModel>();
            using (HttpResponseMessage message = await Client.GetAsync("Produits"))
            {
                string json = await message.Content.ReadAsStringAsync();
                ListeProducts = JsonConvert.DeserializeObject<List<ProductModel>>(json);
                StateHasChanged();
            }
        }
    }
}
