using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace JaspreetSinghChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string Name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Name, message);
        }
    }
}