using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP7082
{
    public partial class Main : Form
    {
        private GameHistory history;

        public Main()
        {
            InitializeComponent();
            history = new GameHistory();

            foreach(Game g in history.Games)
            {
                string[] item = new string[]
                {
                    g.player,
                    g.opponent,
                    g.stage,
                    g.result.ToString(),
                    g.timeStamp
                };

                historyList.Items.Add(new ListViewItem(item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
