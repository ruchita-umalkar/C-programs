// Real-time Communication using SignalR 
using System;
using Microsoft.AspNetCore.SignalR; 
public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}