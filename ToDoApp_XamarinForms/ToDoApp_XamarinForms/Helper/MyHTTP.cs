using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.Models;

namespace ToDoApp_XamarinForms.Helper {

    public class MyHTTP {

        internal static async Task GetWebApiItems(Action<IEnumerable<ToDoItem>> action) {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/k730v");

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                var list = JsonConvert.DeserializeObject<IEnumerable<ToDoItem>>(await response.Content.ReadAsStringAsync());
                action(list);
            }
        }
    }
}
