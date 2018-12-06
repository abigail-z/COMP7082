using COMP7082.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace COMP7082.ViewsControllers
{
    public partial class EditDialog : Form
    {
        public Game ReturnValue { get; private set; }
        private static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        private string timeStamp;

        public EditDialog(Game g)
        {
            InitializeComponent();

            characterBox.Text = g.player;
            opponentBox.Text = g.opponent;
            stageBox.Text = g.stage;

            if (g.result == Result.Win)
            {
                winRadio.Checked = true;
            }
            else
            {
                lossRadio.Checked = true;
            }

            timeStamp = g.timeStamp;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int error = 0;

            error += CheckTextEntry(characterBox);
            error += CheckTextEntry(opponentBox);
            error += CheckTextEntry(stageBox);

            Result r;
            if (winRadio.Checked)
            {
                r = Result.Win;
            }
            else
            {
                r = Result.Loss;
            }

            if (!winRadio.Checked && !lossRadio.Checked)
            {
                error++;
                errorProvider.SetError(resultBox, "Required Field");
            }

            if (error > 0)
            {
                return;
            }

            ReturnValue = new Game
            {
                player = textInfo.ToTitleCase(characterBox.Text),
                opponent = textInfo.ToTitleCase(opponentBox.Text),
                stage = textInfo.ToTitleCase(stageBox.Text),
                result = r,
                timeStamp = timeStamp
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        public int CheckTextEntry (TextBox t)
        {
            if (t.Text.Length == 0)
            {
                errorProvider.SetError(t, "Required Field");
                return 1;
            }

            return 0;
        }
    }
}
