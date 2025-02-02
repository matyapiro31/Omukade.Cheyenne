using ClientNetworking;
using System;

namespace ClientNetworking
{
    public static class CreateUrl
    {
        public static Uri Websocket(WebProtocols protocols, string domain, string port)
        {
            return CreateUrl.Create(protocols.websocket, domain, port, "/websocket/v1/external/stomp");
        }

        public static Uri Api(WebProtocols protocols, string domain, string port, string api)
        {
            return CreateUrl.Create(protocols.web, domain, port, api);
        }

        private static Uri Create(string protocol, string domain, string port, string api)
        {
            if (port != null)
            {
                return new Uri(string.Concat(new string[] { protocol, "://", domain, ":", port, api }));
            }
            return new Uri(protocol + "://" + domain + api);
        }
    }
}
    