using System;
using COMP7082.Models;
using COMP7082.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace COMP7082Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestModelIntegrity ()
        {
            GameHistory history = new GameHistory("../../../COMP7082/bin/debug/gamehistory.bin");

            if (history.games.Count <= 0)
            {
                Assert.Inconclusive("History empty.");
            }

            foreach (Game g in history.games)
            {
                Assert.IsNotNull(g.player);
                Assert.IsTrue(g.player.Length > 0);

                Assert.IsNotNull(g.opponent);
                Assert.IsTrue(g.opponent.Length > 0);

                Assert.IsNotNull(g.stage);
                Assert.IsTrue(g.stage.Length > 0);

                DateTime date = DateTime.Parse(g.timeStamp);
                Assert.IsNotNull(date);
                Assert.IsTrue(date < DateTime.UtcNow);
            }
        }

        [TestMethod]
        public void TestSerialization ()
        {
            Game game1 = new Game
            {
                player = "Player",
                opponent = "Opponent",
                stage = "Stage",
                result = Result.Win,
                timeStamp = DateTime.UtcNow.ToString()
            };

            Serializer.Save("test.bin", game1);
            Game game2 = Serializer.Load<Game>("test.bin");

            Assert.AreEqual(game1, game2);
        }

        [TestMethod]
        public void TestConversionToListViewItem ()
        {
            Game game = new Game
            {
                player = "Player",
                opponent = "Opponent",
                stage = "Stage",
                result = Result.Win,
                timeStamp = DateTime.UtcNow.ToString()
            };

            ListViewItem item = GameConverter.GameToItem(game);

            Assert.AreEqual(item.SubItems[0].Text, game.player);
            Assert.AreEqual(item.SubItems[1].Text, game.opponent);
            Assert.AreEqual(item.SubItems[2].Text, game.stage);
            Assert.AreEqual(item.SubItems[3].Text, game.result.ToString());
            Assert.AreEqual(item.SubItems[4].Text, game.timeStamp);
        }

        [TestMethod]
        public void TestConversionToGame ()
        {
            string time = DateTime.UtcNow.ToString();

            string[] values = new string[]
            {
                "Player",
                "Opponent",
                "Stage",
                "Win",
                time
            };

            ListViewItem item = new ListViewItem(values);

            Game game1 = new Game()
            {
                player = "Player",
                opponent = "Opponent",
                stage = "Stage",
                result = Result.Win,
                timeStamp = time
            };

            Game game2 = GameConverter.ItemToGame(item);

            Assert.AreEqual(game1, game2);
        }

        [TestMethod]
        public void TestConversion ()
        {
            Game game1 = new Game()
            {
                player = "Player",
                opponent = "Opponent",
                stage = "Stage",
                result = Result.Win,
                timeStamp = DateTime.UtcNow.ToString()
            };

            ListViewItem item = GameConverter.GameToItem(game1);
            Game game2 = GameConverter.ItemToGame(item);

            Assert.AreEqual(game1, game2);
        }
    }
}
