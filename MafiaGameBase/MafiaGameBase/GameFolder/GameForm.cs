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

        private BindingList<string> playerNames = new BindingList<string>();
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
            PlayerListBox.DataSource = playerNames;
            PlayerNamesTextBox.Clear();
            StatusLabel.Text = $"{playerNames.Count}/{playersToAdd} players added.";
        }

        private void playerCount_ValueChanged(object sender, EventArgs e)
        {
            playersToAdd = (int)playerCount.Value;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            if (playersToAdd != playerNames.Count)
            {
                MessageBox.Show("ether too many players or too little players to run the game compared to player count, please make sure player count and the ammount of players are equal");
                return;
            }

            try
            {
                Game.Initialize(playerNames,
                   (int)NumberOfDetectivesNud.Value,
                   (int)NumberOfJestersNud.Value,
                   (int)NumberOfDoctorsNud.Value,
                   (int)NumberOfMafiaNud.Value,
                   (int)NumberOfVillagersNud.Value);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }


            var gamePlayStart = new MainGameForm();
            gamePlayStart.ShowDialog();
            this.Hide();

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            string player = PlayerListBox.SelectedItem.ToString();
            if (player != null)
            {
                StatusLabel.Text = $"Removed Player {player}";
                playerNames.Remove(player);
                return;
            }
            else { StatusLabel.Text = "Select a player to Remove"; }
        }
    }
}
