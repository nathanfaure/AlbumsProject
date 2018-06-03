using System.Linq;
using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.DAL.EF;
using AlbumsProject.ViewModels;
using DataAccessLayer.Core.EntityFramework.UoW;
using DataAccessLayer.Core.Interfaces.UoW;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;

namespace AlbumsProject.Web.Hubs
{
    [HubName("chatHub")]
    [Microsoft.AspNetCore.SignalR.Authorize]
    public class ChatHub : Hub
    {
        private readonly IUnitOfWork _uow;
        public ChatHub()
        {
            BlogDbContext blogDbContext = new BlogDbContext(
                new Microsoft.EntityFrameworkCore.DbContextOptions<BlogDbContext>(),
                new DAL.Configuration.DatabaseOptions()
                {
                    ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=BlogDB;Integrated Security=True;"
                }
            );
            _uow = new UnitOfWork(blogDbContext);
        }

        [HubMethodName("sendMessageAll")]
        public void SendMessageAll(MessageVm message)
        {
            message.Author = Context.User.Identity.Name;
            Clients.All.showMessage(message);
        }

        [HubMethodName("sendMessageToUser")]
        public void SendMessageToUser(MessageVm message)
        {
            message.Author = Context.User.Identity.Name;
            Clients.User(message.RecipientName).showMessage(message);
        }

        [HubMethodName("sendMessageToGroup")]
        public void SendMessageToGroup(MessageVm message)
        {
            message.Author = Context.User.Identity.Name;
            Clients.Group(message.RecipientName).showMessage(message);
        }

        private void SetGroups()
        {
           
            var user = _uow.Repository<User>().Get(u => u.UserName == Context.User.Identity.Name, 
                                                   tablePredicate: u => u.ChatGroupToUsers.Select(x => x.ChatGroup));
            user.ChatGroupToUsers.Select(g => g.ChatGroup.Name)
                .ToList()
                .ForEach(group =>
                {
                    Groups.Add(Context.ConnectionId, group);
                });
        }
        public override System.Threading.Tasks.Task OnConnected()
        {
            SetGroups();
            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnReconnected()
        {
            SetGroups();
            return base.OnReconnected();
        }
    }
}
