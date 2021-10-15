using System;
using System.Collections.Generic;

namespace TaskPlayerLobby
{
    class Room
    {
        private List<Player> _players;

        private Chat _chat;

        public int MaxPlayers { get; private set; }
        public int MaxReadyPlayers { get; private set; }

        public bool IsInGame { get; private set; }

        public Room(Player player, int maxPlayers, int maxReadyPlayers)
        {
            _players = new List<Player>();
            _players.Add(player);

            _chat = new Chat();
            player.SetChat(_chat);

            MaxPlayers = maxPlayers;
            MaxReadyPlayers = maxReadyPlayers;
        }

        public void AddPlayer(Player player)
        {
            if (_players.Count < MaxPlayers)
            {
                _players.Add(player);

                CheckPlayersStatus();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(player));
            }
        }

        private void CheckPlayersStatus()
        {
            int readyPlayers = 0;

            foreach (var player in _players)
            {
                if (player.IsReady)
                    readyPlayers++;
            }

            if (readyPlayers == MaxReadyPlayers)
                IsInGame = true;
        }
    }
}