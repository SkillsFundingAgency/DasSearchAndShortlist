﻿using System;
using System.Net;
using System.Text;

using Sfa.Das.Sas.Core.Logging;

namespace Sfa.Das.Sas.ApplicationServices.Http
{
    using Logging;

    public class HttpService : IHttpGet
    {
        private readonly ILog _logger;

        public HttpService(ILog logger)
        {
            this._logger = logger;
        }

        public string Get(string url, string username, string pwd)
        {
            using (var client = new WebClient())
            {
                if (!string.IsNullOrEmpty(username))
                {
                    var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{pwd}"));
                    client.Headers[HttpRequestHeader.Authorization] = $"Basic {credentials}";
                }

                try
                {
                    client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);

                    return client.DownloadString(url);
                }
                catch (WebException ex)
                {
                    _logger.Warn(ex.ToString(), new HttpErrorLogEntry { Url = url });
                    throw;
                }
            }
        }
    }
}
