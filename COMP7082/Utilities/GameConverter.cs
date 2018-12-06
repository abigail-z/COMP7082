using COMP7082.Models;
using System.Windows.Forms;

namespace COMP7082.Utilities
{
    public static class GameConverter
    {
        public static ListViewItem GameToItem(Game g)
        {
            string[] values = new string[]
            {
                g.player,
                g.opponent,
                g.stage,
                g.result.ToString(),
                g.timeStamp
            };

            return new ListViewItem(values);
        }

        public static Game ItemToGame(ListViewItem i)
        {
            return new Game
            {
                player = i.SubItems[0].Text,
                opponent = i.SubItems[1].Text,
                stage = i.SubItems[2].Text,
                result = i.SubItems[3].Text == "Win" ? Result.Win : Result.Loss,
                timeStamp = i.SubItems[4].Text
            };
        }
    }
}
