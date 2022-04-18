using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace JaspreetSinghChat.Server.Hubs
{
    public class ChatHub : Hub
    {
     public Task SendMessage(string user, string message)
{
return Clients.All.SendAsync("ReceiveMessage", user, message);
}
public Task SendMessageToCaller(string user, string message)
{
return Clients.Caller.SendAsync("ReceiveMessage", user, message);
}
public Task SendMessageToGroup(string user, string message)
{
return Clients.Group("SignalR Users").SendAsync("ReceiveMessage", user, message);
}
public Task SendSomeoneTyping(string user)
        {
            return Clients.All.SendAsync("ReceiveSomeoneTyping", user);
        }
    }}