using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternDemo
{
    // Create mediator class.
    public class ChatRoom
    {
        public static void ShowMessage(User User, string Message)
        {
            Console.WriteLine(new DateTime().ToString()+"["+User.Name +"]: "+ Message);
        }
    }
}
