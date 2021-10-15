using System;
using System.Collections.Generic;

namespace TaskPlayerLobby
{
    class Chat
    {
        private List<string> _messages;

        public Chat()
        {
            _messages = new List<string>();
        }

        public void Write(string message)
        {
            _messages.Add(message);
        }

        public void Read()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
