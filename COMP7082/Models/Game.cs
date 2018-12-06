using COMP7082.Utilities;
using System;
using System.Collections.Generic;

namespace COMP7082.Models
{
    public class GameHistory
    {
        public List<Game> games;
        private const string SAVE_LOCATION = "gamehistory.bin";

        public GameHistory()
        {
            games = Serializer.Load<List<Game>>(SAVE_LOCATION);

            if (games == null)
            {
                games = new List<Game>();
            }
        }

        public GameHistory(string location)
        {
            games = Serializer.Load<List<Game>>(location);

            if (games == null)
            {
                games = new List<Game>();
            }
        }

        public void Save ()
        {
            Serializer.Save(SAVE_LOCATION, games);
        }
    }

    [Serializable]
    public struct Game
    {
        public string player;
        public string opponent;
        public string stage;
        public Result result;
        public string timeStamp;
    }

    public enum Result
    {
        Win, Loss
    }
}
