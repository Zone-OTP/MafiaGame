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
using ClassLibraryOfCharacters.Users;

namespace MafiaGameBase.GameFolder
{
    public partial class ControlForm : Form
    {
        private bool _dayNight;
        private Player _player;

        public ControlForm(bool dayNight,Player player)
        {
            InitializeComponent();
           _dayNight = dayNight;
            _player = player;
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            if(_dayNight == false)
            {
                DisplayPlayerControls();
            }
        }

        private void DisplayPlayerControls()
        {
            // Clear existing controls if needed
            this.Controls.Clear();

            // Use a FlowLayoutPanel for dynamic layout
            var layoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown
            };
            this.Controls.Add(layoutPanel);

            // Add PlayerControlsNight for each player
                var playerMove = new PlayerControlsNight(_player);
                layoutPanel.Controls.Add(playerMove);
            
        }
    }
}
