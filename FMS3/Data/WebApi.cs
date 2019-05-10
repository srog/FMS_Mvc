using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace FMS3.Data
{
    public class WebApi : IWebApi
    {
        public HttpResponseMessage GetById(string url, int id)
        {
            var client = new HttpClient
                {
                    BaseAddress = new Uri(url + "?id=" + id)
                };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(String.Empty).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return new HttpResponseMessage { StatusCode = response.StatusCode };
            }
        }

        // GET ALL
        // structure is controller / gamedetailsid / seasonid / divisionid / week / 

        private string ConstructUrl(string url,Dictionary<string, object> paramList)
        {
            var actualUrl = url;
            if (paramList.ContainsKey("teamId"))
            {
                // for player
                if (paramList.ContainsKey("gameDetailsId"))
                {
                    actualUrl += "/";
                    actualUrl += paramList["gameDetailsId"];
                    actualUrl += "/";
                    actualUrl += paramList["teamId"];
                    return actualUrl;
                }

                // for news 
                actualUrl += "?teamId=" + paramList["teamId"];
                return actualUrl;
            }
            if (paramList.ContainsKey("playerId"))
            {
                actualUrl += "?playerId=" + paramList["playerId"];
                return actualUrl;
            }

            if (paramList.ContainsKey("gameDetailsId"))
            {
                actualUrl += "/";
                actualUrl += paramList["gameDetailsId"].ToString();

                if (paramList.ContainsKey("seasonId"))
                {
                    actualUrl += "/";
                    actualUrl += paramList["seasonId"].ToString();

                    if (paramList.ContainsKey("divisionId"))
                    {
                        actualUrl += "/";
                        actualUrl += paramList["divisionId"].ToString();

                        if (paramList.ContainsKey("week"))
                        {
                            actualUrl += "/";
                            actualUrl += paramList["week"].ToString();
                        }
                    }
                }
            }
            return actualUrl;
        }

        public HttpResponseMessage GetAll(string url, Dictionary<string, object> paramList = null)
        {
            var client = new HttpClient
                {
                    BaseAddress = paramList == null ? new Uri(url) : new Uri(ConstructUrl(url,paramList)) // new Uri(url + "/" + id)
                };

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(string.Empty).Result;

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
    }
}
