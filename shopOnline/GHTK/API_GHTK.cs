using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace shopOnline.GHTK
{
    public class API_GHTK
    {
        static string token = "3c2c765d84f05a587123324ed30e9323458b25d4";
        static string url_api = "https://services.giaohangtietkiem.vn";
        static string pick_province = "Hồ Chí Minh";
        static string pick_district = "Quận 8";
        static string deliver_option = "none";


        public static async Task<string> postOrderAsync(string json)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Token", token);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            string url = url_api + "/services/shipment/order/?ver=1.5";
            HttpResponseMessage response = await client.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }


        public static async Task<string> getFeeShipAsync(string province, string district, double weight, int totalMoney=0)
        {
            weight = weight * 1000;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Token", token);
            string url = url_api + String.Format("/services/shipment/fee?pick_province={0}&pick_district={1}&deliver_option={2}&province={3}&district={4}&weight={5}&value={6}&transport=road", pick_province, pick_district, deliver_option, province, district, weight, totalMoney);
            HttpResponseMessage response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }


        public static async Task<string> getOrderStatusAsync(string label)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Token", token);
            string url = url_api + "/services/shipment/v2/" + label;
            HttpResponseMessage response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> cancelOrderAsync(string label)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Token", token);
            string url = url_api + "/services/shipment/cancel/" + label;
            HttpResponseMessage response = await client.PostAsync(url, new StringContent(""));
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<Stream> printOrderStatusAsync(string label)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Token", token);
            string url = url_api + "/services/label/" + label;
            Stream response = await client.GetStreamAsync(url);
            return response;
        }

    }
}
