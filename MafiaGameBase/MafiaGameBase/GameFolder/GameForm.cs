using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryOfCharacters.Functionality;

namespace MafiaGameBase.GameFolder
{
    public partial class GameForm : Form
    {

        private List<string> playerNames = new List<string>();
        private int playersToAdd = 4;
        public GameForm()
        {
            InitializeComponent();

        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            string name = PlayerNamesTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                StatusLabel.Text = "Enter a name.";
                return;
            }
            if (playerNames.Contains(name))
            {
                StatusLabel.Text = "Duplicate name.";
                return;
            }
            if (playerNames.Count >= playersToAdd)
            {
                StatusLabel.Text = "Player limit reached.";
                return;
            }

            playerNames.Add(name);
            PlayerListBox.Items.Add(name);
            PlayerNamesTextBox.Clear();
            StatusLabel.Text = $"{playerNames.Count}/{playersToAdd} players added.";
        }

        private void playerCount_ValueChanged(object sender, EventArgs e)
        {
            playersToAdd = (int)playerCount.Value;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Game.Initialize(playerNames,
               (int)NumberOfDetectivesNud.Value,
               (int)NumberOfJestersNud.Value,
               (int)NumberOfDoctorsNud.Value,
               (int)NumberOfMafiaNud.Value,
               (int)NumberOfVillagersNud.Value);

            var gamePlayStart = new MainGameForm();
            gamePlayStart.ShowDialog();
            this.Hide();
            
        }
    }
}
