using Interfaces;
using Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platforms.iOS
{
    class IosHttpMessageHandler : IPlatformHttpMessageHandler
    {
        public HttpMessageHandler GetHttpMessageHandler() =>
        new NSUrlSessionHandler
            {
                TrustOverrideForUrl = (NSUrlSessionHandler sender, string url, SecTrust trust) => url.StartsWith("https://locahost")
            };
    }
}
