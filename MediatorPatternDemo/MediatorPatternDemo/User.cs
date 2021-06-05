using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternDemo
{
    public class User
    {
        public string Name { get; set; }
        public User(string Name)
        {
            this.Name = Name;
        }
  

        public void SendMessage(string Message)
        {
            ChatRoom.ShowMessage(this, Message);
        }
    }
}
