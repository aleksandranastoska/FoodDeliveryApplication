using ClosedXML.Excel;
using FoodDeliveryAdminApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FoodDeliveryAdminApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string URL = "http://localhost:5270/api/Admin/GetAllOrders";
            HttpResponseMessage response = client.GetAsync(URL).Result;

            var data = response.Content.ReadAsAsync<List<Order>>().Result;
            return View(data);
        }

        public IActionResult Details(string id)
        {
            HttpClient client = new HttpClient();
            string URL = "http://localhost:5270/api/Admin/GetDetails";
            var model = new
            {
                Id = id
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(URL, content).Result;

            var result = response.Content.ReadAsAsync<Order>().Result;


            return View(result);

        }

        [HttpGet]
        public FileContentResult ExportOrders()
        {
            string fileName = "AllOrdersWithDetails.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workBook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workBook.Worksheets.Add("Orders");

                worksheet.Cell(1, 1).Value = "Order ID";
                worksheet.Cell(1, 2).Value = "Customer Username";
                worksheet.Cell(1, 3).Value = "Address";
                worksheet.Cell(1, 4).Value = "Phone Number";
                worksheet.Cell(1, 5).Value = "Restaurant Name";
                worksheet.Cell(1, 6).Value = "Food Item Name";
                worksheet.Cell(1, 7).Value = "Quantity";
                worksheet.Cell(1, 8).Value = "Price";

                var headerRow = worksheet.Range("A1:H1");
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Font.FontColor = XLColor.White;
                headerRow.Style.Fill.BackgroundColor = XLColor.BlueGreen; 
                headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                HttpClient client = new HttpClient();
                string URL = "http://localhost:5270/api/Admin/GetAllOrders"; 
                HttpResponseMessage response = client.GetAsync(URL).Result;

                var data = response.Content.ReadAsAsync<List<Order>>().Result;

                int currentRow = 2; 
                foreach (var order in data)
                {
                    string address = order.Address != null
                        ? $"{order.Address.Street}, {order.Address.Number}, {order.Address.Flat}"
                        : "N/A";

                    foreach (var foodInOrder in order.FoodsInOrder)
                    {
                        worksheet.Cell(currentRow, 1).Value = order.Id.ToString();
                        worksheet.Cell(currentRow, 2).Value = order.Owner?.UserName ?? "N/A";
                        worksheet.Cell(currentRow, 3).Value = address;

                        string phoneNumber = order.Owner?.PhoneNumber ?? "N/A";
                        worksheet.Cell(currentRow, 4).Value = phoneNumber;

                        string restaurantName = foodInOrder.Food?.Restaurant?.Name ?? "N/A";
                        worksheet.Cell(currentRow, 5).Value = restaurantName;

                        worksheet.Cell(currentRow, 6).Value = foodInOrder.Food?.Name ?? "N/A";
                        worksheet.Cell(currentRow, 7).Value = foodInOrder.Quantity;
                        worksheet.Cell(currentRow, 8).Value = foodInOrder.Price.ToString("C");
                       
                        var row = worksheet.Row(currentRow);

                        currentRow++;
                    }
                }

                var usedRange = worksheet.RangeUsed();
                usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                worksheet.Columns().AdjustToContents();

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, contentType, fileName);
                }
            }
        }


    }
}
