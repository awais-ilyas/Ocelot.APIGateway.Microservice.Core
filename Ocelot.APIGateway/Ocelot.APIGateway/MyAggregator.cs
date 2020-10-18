using Microsoft.AspNetCore.Http;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ocelot.APIGateway
{
    public class MyAggregator : IDefinedAggregator
    {

        //public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        //{
        //    var one = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();
        //    var two = await responses[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

        //    var contentBuilder = new StringBuilder();
        //    contentBuilder.Append(one);
        //    contentBuilder.Append(two);

        //    var stringContent = new StringContent(contentBuilder.ToString())
        //    {
        //        Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
        //    };

        //    return new DownstreamResponse(stringContent, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), "OK");
        //}

        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var readers = responses.Select(r => new StreamReader(r.Response.Body)).ToList();
            var objects = await Task.WhenAll(readers.Select(r => r.ReadToEndAsync()));

            readers.ForEach(r => r.Dispose());

            throw new NotImplementedException();
        }
    }
}
