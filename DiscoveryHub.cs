using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace eDiscovery
{
    public class DiscoveryHub : Hub
    {
        public void Send(string name, string resultsCount)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.broadcastMessage(name, resultsCount);
        }

    }
}