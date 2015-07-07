using System;
using Microsoft.AspNet.SignalR;

namespace Demo2
{
    public class GameHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello(DateTime.Now.ToString());
        }
    }
}