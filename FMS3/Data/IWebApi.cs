using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public interface IWebApi
    {
        
        HttpResponseMessage Post(string url, object param = null);
        HttpResponseMessage Put(string url, object param);
        HttpResponseMessage Delete(string url, int id);


        HttpResponseMessage GetById(string url, int id);
        HttpResponseMessage GetAll(string url, Dictionary<string, object> paramList = null);

    }
}