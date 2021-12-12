using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MoveElementRealtime.AppCode.Hubs
{
    public class MoveHub : Hub
    {
        public async Task PushPosition(int x,int y)
        {
            //await Clients.All.SendAsync("ReceiveMessage", user, message);
            //await Clients.Caller.SendAsync("ReceiveMessage", user, message);
            await Clients.Others.SendAsync("ReceivePosition", x,y);

            //Clients.Group("developers").SendAsync("SendMessage","demo");
        }
    }
}
