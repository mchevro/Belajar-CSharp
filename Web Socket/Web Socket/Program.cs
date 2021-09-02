using System;
using System.Net;
using System.Net.Sockets;
using WebSocketSharp;


namespace Web_Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new WebSocket("wss://simple-websocket-server-echo.glitch.me");
            server.Connect();
            server.Send("Hallo");
            Console.ReadKey();
        }
    }
}
