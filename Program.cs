using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClienteSumas {
    class Program {
        readonly String sAdd = "https://localhost:44374/api/v1/Operations/Add";
        readonly String sSubtraction = "https://localhost:44374/api/v1/Operations/Subtraction";
        readonly String sMultiplication = "https://localhost:44374/api/v1/Operations/Multiplication";
        readonly String sDivision = "https://localhost:44374/api/v1/Operations/Division";

        private async Task<double> Add() {
            HttpClient oCliente = new HttpClient();
            HttpResponseMessage oResponse;

            try {
                oResponse = await oCliente.PostAsJsonAsync(sAdd, new Tuple<double, double>(2, 3));
                if (oResponse.IsSuccessStatusCode)
                    return Convert.ToDouble(await oResponse.Content.ReadAsStringAsync());
                else
                    return -1;
            } catch (Exception ex) {
                return -1;
            }
        }

        private async Task<double> Subtraction() {
            HttpClient oCliente = new HttpClient();
            HttpResponseMessage oResponse;

            try {
                oResponse = await oCliente.PostAsJsonAsync(sSubtraction, new Tuple<double, double>(6, 3));
                if (oResponse.IsSuccessStatusCode)
                    return Convert.ToDouble(await oResponse.Content.ReadAsStringAsync());
                else
                    return -1;
            } catch (Exception ex) {
                return -1;
            }
        }

        private async Task<double> Multiplication() {
            HttpClient oCliente = new HttpClient();
            HttpResponseMessage oResponse;

            try {
                oResponse = await oCliente.PostAsJsonAsync(sMultiplication, new Tuple<double, double>(58490, 3));
                if (oResponse.IsSuccessStatusCode)
                    return Convert.ToDouble(await oResponse.Content.ReadAsStringAsync());
                else
                    return -1;
            } catch (Exception ex) {
                return -1;
            }
        }

        private async Task<double> Division() {
            HttpClient oCliente = new HttpClient();
            HttpResponseMessage oResponse;

            try {
                oResponse = await oCliente.PostAsJsonAsync(sDivision, new Tuple<double, double>(10, 5));
                if (oResponse.IsSuccessStatusCode)
                    return Convert.ToDouble(await oResponse.Content.ReadAsStringAsync());
                else
                    return -1;
            } catch (Exception ex) {
                return -1;
            }
        }

        static async Task Main(string[] args) {
            Program IrA = new Program();

            Console.WriteLine(await IrA.Add());
            Console.WriteLine(await IrA.Division());
            Console.WriteLine(await IrA.Multiplication());
            Console.WriteLine(await IrA.Division());
        }
    }
}
