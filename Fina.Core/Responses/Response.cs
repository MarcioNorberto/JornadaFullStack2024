using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    // Sem abstract nesse caso, pois pode ser instanciada
    // new Response<Category> class
    // new Response<Transaction> class
    public class Response<TData>
    {
        private int _statusCode = Configuration.DefaultStatusCode;

        // o .Net não sabe qual construtor usar, já que temos dois
        // então é necessário informar atraves do atributo [JsonConstructor]
        // qual construtor ele deve usar
        [JsonConstructor]
        public Response()
            => _statusCode = Configuration.DefaultStatusCode;

        // Optional Parameters
        // var res = new Response<Category>(model);
        public Response(TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            _statusCode = code;
            Message = message ?? string.Empty;
        }

        public TData? Data { get; set; }

        public string? Message { get; set; } = string.Empty;

        [JsonIgnore] // Do not serialize this property
        public bool IsSuccessful => _statusCode is >= 200 and <= 299;
    }
}
