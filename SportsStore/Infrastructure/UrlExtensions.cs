using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        //adding the preperation before adding the add to cart buttons
        public static string PathAndQuery(this HttpRequest request) =>
             request.QueryString.HasValue 
             ? $"{request.Path}{request.QueryString}"
             : request.Path.ToString();
    }
}
