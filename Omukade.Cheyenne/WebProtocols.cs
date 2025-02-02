using System;

namespace ClientNetworking
{
    public class WebProtocols
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

