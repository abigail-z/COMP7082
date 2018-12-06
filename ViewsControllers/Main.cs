using COMP7082.Models;
using COMP7082.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace COMP7082.ViewsControllers
{
    public partial class Main : Form
    {
        private GameHistory history;

        public Main()
        {
            InitializeComponent();

            history = new GameHistory();

            PopulateHistoryListview();
            PopulateStatisticListView();
        }

        protected override void OnFormClosing (FormClosingEventArgs e)
        {
            history.games = new List<Game>();
            foreach (ListViewItem i in historyList.Items)
            {
                history.games.Add(GameConverter.ItemToGame(i));
            }

            history.Save();
            base.OnFormClosing(e);
        }

        // History panel

        private void PopulateHistoryListview ()
        {
            foreach (Game g in history.games)
            {
                ListViewItem item = GameConverter.GameToItem(g);
                historyList.Items.Add(item);
            }
        }

        private void AddButton_Click (object sender, EventArgs e)
        {
            AddDialog dialog = new AddDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = GameConverter.GameToItem(dialog.ReturnValue);
                historyList.Items.Add(item);

                PopulateStatisticListView();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (historyList.SelectedItems.Count <= 0)
            {
                return;
            }

            Game g = GameConverter.ItemToGame(historyList.SelectedItems[0]);
            EditDialog dialog = new EditDialog(g);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int index = historyList.SelectedIndices[0];

                ListViewItem item = GameConverter.GameToItem(dialog.ReturnValue);
                historyList.Items.Remove(historyList.SelectedItems[0]);
                historyList.Items.Insert(index, item);

                PopulateStatisticListView();
            }
        }

        private void RemoveButton_Click (object sender, EventArgs e)
        {
            foreach (ListViewItem item in historyList.SelectedItems)
            {
                historyList.Items.Remove(item);
                PopulateStatisticListView();
            }
        }

        // Statistic panel

        private void PopulateStatisticListView ()
        {
            foreach (ListViewItem item in statisticList.Items)
            {
                statisticList.Items.Remove(item);
            }

            uint gameCount = 0;
            uint winCount = 0;
            foreach (ListViewItem item in historyList.Items)
            {
                bool matchesCharacter = characterBox.Text.Length <= 0
                    || item.SubItems[0].Text.Equals(characterBox.Text, StringComparison.InvariantCultureIgnoreCase);

                bool matchesOpponent = opponentBox.Text.Length <= 0
                    || item.SubItems[1].Text.Equals(opponentBox.Text, StringComparison.InvariantCultureIgnoreCase);

                bool matchesStage = stageBox.Text.Length <= 0
                    || item.SubItems[2].Text.Equals(stageBox.Text, StringComparison.InvariantCultureIgnoreCase);

                bool won = item.SubItems[3].Text.Equals("Win", StringComparison.InvariantCultureIgnoreCase);

                if (matchesCharacter && matchesOpponent && matchesStage)
                {
                    statisticList.Items.Add((ListViewItem)item.Clone());

                    gameCount++;
                    if (won)
                    {
                        winCount++;
                    }
                }
            }

            chart.Series[0].Points.Clear();
            if (gameCount > 0)
            {
                double winRate = (double)winCount / gameCount;
                percentLabel.Text = String.Format("{0:P}", winRate);

                chart.Series[0].Points.Add(winRate);
                chart.Series[0].Points[0].Color = Color.Green;
                chart.Series[0].Points.Add(1 - winRate);
                chart.Series[0].Points[1].Color = Color.Red;
            }
            else
            {
                percentLabel.Text = "N/A";

                chart.Series[0].Points.Add(1);
                chart.Series[0].Points[0].Color = Color.Gray;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PopulateStatisticListView();
        }
    }
}
