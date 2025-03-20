using Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using Xamarin.Android.Net;

namespace Platforms.Android
{
    class AndroidHttpMessageHandler : IPlatformHttpMessageHandler
    {
        public HttpMessageHandler GetHttpMessageHandler() =>
            new AndroidMessageHandler
            {
                ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, sslPolicyErrors) =>
                certificate?.Issuer == "CN=localhost" || sslPolicyErrors == SslPolicyErrors.None
            };
    }
}
