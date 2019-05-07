using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace FMS3.Data
{
    public interface IWebApi
    {
        HttpResponseMessage Get(string url, string param = "");
        HttpResponseMessage Get(string url, int id, string param = "");
        HttpResponseMessage Post(string url, object param = null);
        HttpResponseMessage Put(string url, object param);
        HttpResponseMessage Delete(string url, int id);


        HttpResponseMessage GetById(string url, int id, string param = "");

        HttpResponseMessage GetBySupplierId(string url, int supplierId, string param = "");
        HttpResponseMessage GetByGameDetailsId(string url, int gameDetailsId, string param = "");
        HttpResponseMessage GetByTeamId(string url, int teamId, string param = "");
        HttpResponseMessage GetBySeasonId(string url, int seasonId, string param = "");
            
        HttpResponseMessage GetByPlayerId(string url, int playerId, string param = "");

    }
    public class WebApi : IWebApi
    {
        #region Implementation of IWebApi

        public HttpResponseMessage Get(string url, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage Get(string url, int id, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?id=" + id)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage GetBySupplierId(string url, int supplierId, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?supplierId=" + supplierId)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage GetByPlayerId(string url, int playerId, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?playerId=" + playerId)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage GetByTeamId(string url, int teamId, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?teamId=" + teamId)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage GetByGameDetailsId(string url, int gameDetailsId, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "/" + gameDetailsId)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }
        public HttpResponseMessage GetBySeasonId(string url, int seasonId, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?seasonId=" + seasonId)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage GetById(string url, int id, string param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "/" + id)
            };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        public HttpResponseMessage Post(string url, object param = null)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(url, param).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest };
            }

        }

        public HttpResponseMessage Put(string url, object param)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsync(url, param, new JsonMediaTypeFormatter()).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
            }

        }

        public HttpResponseMessage Delete(string url, int id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(url + "?id=" + id)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
            }

        }



        #endregion
    }
}
