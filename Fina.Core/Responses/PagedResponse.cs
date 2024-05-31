using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(
            TData data, 
            int totalCount, 
            int currentPage = 1, 
            int pageSize = Configuration.DefaultPageSize)
            : base(data)  // Herda o construtor da classe base
        {
            Data = data; // Isso não era necessário, pois já está sendo feito no construtor da classe base
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null)
            : base(data, code, message)
        {
            Data = data;
        }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; } = Configuration.DefaultPageSize;

        public int TotalPages  => (int)Math.Ceiling(TotalCount / (double)PageSize);    
        
        public int TotalCount { get; set; }

    }
}
