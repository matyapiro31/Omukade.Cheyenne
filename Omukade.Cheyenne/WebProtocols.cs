using System;

namespace ClientNetworking
{
    public record struct WebProtocols
    {
        public string web;

        public string websocket;

        public static readonly WebProtocols SECURE = new WebProtocols
        {
            web = "https",
            websocket = "wss"
        };

        public static readonly WebProtocols DANGEROUS = new WebProtocols
        {
            web = "http",
            websocket = "ws"
        };
    }
}

