using Mediator.Mediators;
using Mediator.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            ChatMediator chat = new ChatMediator();

            SimpleUser user1 = new SimpleUser(chat, "Janna0");
            SimpleUser user2 = new SimpleUser(chat, "Serafim98");
            SimpleUser user3 = new SimpleUser(chat, "Octavian777");


            chat.AddSimpleUserToChat(user1);
            chat.AddSimpleUserToChat(user2);
            chat.AddSimpleUserToChat(user3);


            user1.SendMessageAll("Salutare la toti !");
            user2.SendMessageTo("Ce faci Octavian ?", "Octavian777");
            user3.SendMessageTo("Ce faci Janna ?", "Andrei02");
        }
    }
}
