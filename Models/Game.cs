using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP7082
{
    public class GameHistory
    {
        public ReadOnlyCollection<Game> Games { get { return games.AsReadOnly(); } }
        private List<Game> games;

        public GameHistory ()
        {
            games = new List<Game>
            {
                new Game
                {
                    player = "Mario",
                    opponent = "Luigi",
                    stage = "Battlefield",
                    result = Result.Win,
                    timeStamp = DateTime.UtcNow.ToString()
                }
            };
        }

        public Game Get (int index)
        {
            return games[index];
        }

        public void Remove (int index)
        {
            games.RemoveAt(index);
        }

        public void Add (Game game)
        {
            games.Add(game);
        }
    }

    [Serializable]
    public class Game
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
