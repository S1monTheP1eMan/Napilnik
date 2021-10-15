using System;

namespace TaskPlayerLobby
{
    class Player
    {
        private Chat _chat;
        private string _message = "abc";

        public bool IsInRoom { get; private set; }
        public bool IsReady { get; private set; }

        public void JoinRoom(Room room) 
        {
            if (room.IsInGame == false)
            {
                room.AddPlayer(this);

                IsInRoom = true;
            }
        }

        public void CreateRoom(Game game, int maxPlayers, int maxReadyPlayers)
        {
            Room room = new Room(this, maxPlayers, maxReadyPlayers);
            game.AddRoom(room);

            IsInRoom = true;
        }

        public void ReadyUp()
        {
            if (IsInRoom)
            {
                IsReady = true;
            }
            else
            {
                throw new Exception();
            }
        }

        public void SetChat(Chat chat)
        {
            _chat = chat;
        }

        private void WriteMessage()
        {
            if (IsReady)
                _chat.Write(_message);
        }

        private void ReadChat()
        {
            if (IsReady)
                _chat.Read();
        }
    }
}