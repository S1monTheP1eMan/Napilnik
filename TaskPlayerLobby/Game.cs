using System.Collections.Generic;

namespace TaskPlayerLobby
{
    class Game
    {
        private List<Room> _rooms;

        public Game()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
    }
}