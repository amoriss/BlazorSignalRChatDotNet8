using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRChatDotNet8.Hubs;

public class ChatHub : Hub // inherits from SignalR Hub which provides connection point for clients
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message); // sends message to all clients
    }
}
