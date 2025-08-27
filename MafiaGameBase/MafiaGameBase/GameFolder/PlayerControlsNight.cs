using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryOfCharacters.Users;
using ClassLibraryOfCharacters.Roles;
using ClassLibraryOfCharacters.Functionality;
using System.Media;

namespace MafiaGameBase.GameFolder
{
    public partial class PlayerControlsNight : UserControl
    {
        Player _player;
        public PlayerControlsNight(Player player)
        {
            InitializeComponent();
            PlayersDataGrid.AutoGenerateColumns = false;
            PlayersDataGrid.Columns.Clear();
            PlayersDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Player Name"
            });
            PlayersDataGrid.DataSource = Game.Players;
            PlayersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PlayersDataGrid.ReadOnly = true;
            _player = player;
            AbilityNameLabel.Text = player.UseAbility();
            NameOfPlayerLable.Text = player.Name;
            PlayerTypeLabel.Text = player.GetType();
        }

        private void UseAbilityButton_Click(object sender, EventArgs e)
        {
            var abilityUseCount = 0;
            var ability = _player.UseAbility();
            var selectedPlayer = (Player)PlayersDataGrid.SelectedRows[0].DataBoundItem;

            if (selectedPlayer != null && abilityUseCount < 1)
            {
                switch (ability)
                {
                    case "kill":
                        if (!selectedPlayer.Protected && selectedPlayer != _player) { selectedPlayer.Alive = false; }
                        MainGameForm.dayUpdate += $"mafia Targeted {selectedPlayer.Name}, if they're alive doctor saved them";
                        abilityUseCount++;
                        break;
                    case "protected":
                        selectedPlayer.Protected = true;
                        selectedPlayer.Alive = true;
                        break;
                    case "deduce":
                        StatusLabel.Text = $"Player is {selectedPlayer.GetType().ToString()}";
                        abilityUseCount++;
                        break;
                    case "sleep":
                        StatusLabel.Text = "you're a villager just sleep man";
                        abilityUseCount++;
                        break;
                    case "Win on Village Vote Kill":
                        StatusLabel.Text = "you're a FUCKING CLOWN MAN, SLEEP!";
                        abilityUseCount++;
                        break;
                }
            }

        }

        private void PlayersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            //var selectedPlayer = (Player)PlayersDataGrid.SelectedRows[0].DataBoundItem;
            //PlayerSelectedLabel.Text = $"Selected {selectedPlayer.Name}";
        }

        private void Contuinue_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
