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
using ClassLibraryOfCharacters.Functionality;

namespace MafiaGameBase.GameFolder
{
    public partial class MainGameForm : Form
    {
        private static int dayCount = 0;
        public static string dayUpdate = "nothing's happened yet";
        public MainGameForm()
        {
            InitializeComponent();
        }

        private void StartDayButton_Click(object sender, EventArgs e)
        {
            dayUpdate = "";
            dayCount++;
            DayCounterLabel.Text = $"Day {dayCount}";
            this.Hide();
            foreach (var player in Game.Players)
            {
                MessageBox.Show($"player {player.Name} Come to the controls");
                var playerMove = new ControlForm(false, player);
                playerMove.ShowDialog();
            }
            this.Show();
            int maxVote = 0;
            
        }

        private void MainGameForm_Load(object sender, EventArgs e)
        {
        }

        private void MainGameForm_Shown(object sender, EventArgs e)
        {
            PreviusDayUpNightLabel.Text = dayUpdate;
            
        }

        private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainGameForm_Activated(object sender, EventArgs e)
        {
            PreviusDayUpNightLabel.Text = dayUpdate;
            if (dayCount > 0) {
                var playerName = Game.RemoveVotedPlayer();
                PreviusDayUpNightLabel.Text = $"player {playerName} HAS BEEN KILLED";
            }
        }
    }
}

