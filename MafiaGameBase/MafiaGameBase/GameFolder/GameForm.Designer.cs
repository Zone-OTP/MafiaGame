namespace MafiaGameBase.GameFolder
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playerCount = new NumericUpDown();
            PlayerNamesTextBox = new TextBox();
            NumberOfPlayers = new Label();
            AddPlayer = new Button();
            StatusLabel = new Label();
            PlayerListBox = new ListBox();
            StartGameButton = new Button();
            NumberOfDetectivesNud = new NumericUpDown();
            NumberOfJestersNud = new NumericUpDown();
            NumberOfDoctorsNud = new NumericUpDown();
            NumberOfMafiaNud = new NumericUpDown();
            NumberOfVillagersNud = new NumericUpDown();
            NumberOfVilagersLabel = new Label();
            NumberOfDetectivesLabel = new Label();
            NumberOfJestersLabel = new Label();
            NumberOfDoctorsLabel = new Label();
            NumberOfMafiaLabel = new Label();
            RemovePlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)playerCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDetectivesNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfJestersNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDoctorsNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfMafiaNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfVillagersNud).BeginInit();
            SuspendLayout();
            // 
            // playerCount
            // 
            playerCount.Location = new Point(25, 52);
            playerCount.Margin = new Padding(3, 2, 3, 2);
            playerCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            playerCount.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            playerCount.Name = "playerCount";
            playerCount.Size = new Size(131, 23);
            playerCount.TabIndex = 0;
            playerCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            playerCount.ValueChanged += playerCount_ValueChanged;
            // 
            // PlayerNamesTextBox
            // 
            PlayerNamesTextBox.BackColor = SystemColors.Menu;
            PlayerNamesTextBox.BorderStyle = BorderStyle.FixedSingle;
            PlayerNamesTextBox.Location = new Point(263, 51);
            PlayerNamesTextBox.Margin = new Padding(3, 2, 3, 2);
            PlayerNamesTextBox.Name = "PlayerNamesTextBox";
            PlayerNamesTextBox.PlaceholderText = "Player Name";
            PlayerNamesTextBox.Size = new Size(161, 23);
            PlayerNamesTextBox.TabIndex = 1;
            // 
            // NumberOfPlayers
            // 
            NumberOfPlayers.AutoSize = true;
            NumberOfPlayers.Location = new Point(25, 34);
            NumberOfPlayers.Name = "NumberOfPlayers";
            NumberOfPlayers.Size = new Size(107, 15);
            NumberOfPlayers.TabIndex = 2;
            NumberOfPlayers.Text = "Number Of Players";
            // 
            // AddPlayer
            // 
            AddPlayer.Location = new Point(459, 52);
            AddPlayer.Margin = new Padding(3, 2, 3, 2);
            AddPlayer.Name = "AddPlayer";
            AddPlayer.Size = new Size(82, 22);
            AddPlayer.TabIndex = 3;
            AddPlayer.Text = "Add Player";
            AddPlayer.UseVisualStyleBackColor = true;
            AddPlayer.Click += AddPlayer_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(308, 86);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // PlayerListBox
            // 
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.Location = new Point(558, 34);
            PlayerListBox.Margin = new Padding(3, 2, 3, 2);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(132, 79);
            PlayerListBox.TabIndex = 5;
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(308, 173);
            StartGameButton.Margin = new Padding(3, 2, 3, 2);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(82, 22);
            StartGameButton.TabIndex = 6;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // NumberOfDetectivesNud
            // 
            NumberOfDetectivesNud.Location = new Point(25, 285);
            NumberOfDetectivesNud.Margin = new Padding(3, 2, 3, 2);
            NumberOfDetectivesNud.Name = "NumberOfDetectivesNud";
            NumberOfDetectivesNud.Size = new Size(131, 23);
            NumberOfDetectivesNud.TabIndex = 7;
            // 
            // NumberOfJestersNud
            // 
            NumberOfJestersNud.Location = new Point(187, 285);
            NumberOfJestersNud.Margin = new Padding(3, 2, 3, 2);
            NumberOfJestersNud.Name = "NumberOfJestersNud";
            NumberOfJestersNud.Size = new Size(131, 23);
            NumberOfJestersNud.TabIndex = 8;
            // 
            // NumberOfDoctorsNud
            // 
            NumberOfDoctorsNud.Location = new Point(372, 285);
            NumberOfDoctorsNud.Margin = new Padding(3, 2, 3, 2);
            NumberOfDoctorsNud.Name = "NumberOfDoctorsNud";
            NumberOfDoctorsNud.Size = new Size(131, 23);
            NumberOfDoctorsNud.TabIndex = 9;
            // 
            // NumberOfMafiaNud
            // 
            NumberOfMafiaNud.Location = new Point(558, 285);
            NumberOfMafiaNud.Margin = new Padding(3, 2, 3, 2);
            NumberOfMafiaNud.Name = "NumberOfMafiaNud";
            NumberOfMafiaNud.Size = new Size(131, 23);
            NumberOfMafiaNud.TabIndex = 10;
            // 
            // NumberOfVillagersNud
            // 
            NumberOfVillagersNud.Location = new Point(281, 242);
            NumberOfVillagersNud.Margin = new Padding(3, 2, 3, 2);
            NumberOfVillagersNud.Name = "NumberOfVillagersNud";
            NumberOfVillagersNud.Size = new Size(131, 23);
            NumberOfVillagersNud.TabIndex = 11;
            // 
            // NumberOfVilagersLabel
            // 
            NumberOfVilagersLabel.AutoSize = true;
            NumberOfVilagersLabel.Location = new Point(263, 224);
            NumberOfVilagersLabel.Name = "NumberOfVilagersLabel";
            NumberOfVilagersLabel.Size = new Size(157, 15);
            NumberOfVilagersLabel.TabIndex = 12;
            NumberOfVilagersLabel.Text = "Number Of Vilagers in game";
            // 
            // NumberOfDetectivesLabel
            // 
            NumberOfDetectivesLabel.AutoSize = true;
            NumberOfDetectivesLabel.Location = new Point(52, 268);
            NumberOfDetectivesLabel.Name = "NumberOfDetectivesLabel";
            NumberOfDetectivesLabel.Size = new Size(61, 15);
            NumberOfDetectivesLabel.TabIndex = 13;
            NumberOfDetectivesLabel.Text = "Detectives";
            // 
            // NumberOfJestersLabel
            // 
            NumberOfJestersLabel.AutoSize = true;
            NumberOfJestersLabel.Location = new Point(228, 268);
            NumberOfJestersLabel.Name = "NumberOfJestersLabel";
            NumberOfJestersLabel.Size = new Size(41, 15);
            NumberOfJestersLabel.TabIndex = 14;
            NumberOfJestersLabel.Text = "Jesters";
            // 
            // NumberOfDoctorsLabel
            // 
            NumberOfDoctorsLabel.AutoSize = true;
            NumberOfDoctorsLabel.Location = new Point(408, 268);
            NumberOfDoctorsLabel.Name = "NumberOfDoctorsLabel";
            NumberOfDoctorsLabel.Size = new Size(48, 15);
            NumberOfDoctorsLabel.TabIndex = 15;
            NumberOfDoctorsLabel.Text = "Doctors";
            // 
            // NumberOfMafiaLabel
            // 
            NumberOfMafiaLabel.AutoSize = true;
            NumberOfMafiaLabel.Location = new Point(593, 270);
            NumberOfMafiaLabel.Name = "NumberOfMafiaLabel";
            NumberOfMafiaLabel.Size = new Size(37, 15);
            NumberOfMafiaLabel.TabIndex = 16;
            NumberOfMafiaLabel.Text = "Mafia";
            // 
            // RemovePlayer
            // 
            RemovePlayer.Location = new Point(558, 118);
            RemovePlayer.Name = "RemovePlayer";
            RemovePlayer.Size = new Size(130, 23);
            RemovePlayer.TabIndex = 17;
            RemovePlayer.Text = "Remove Player";
            RemovePlayer.UseVisualStyleBackColor = true;
            RemovePlayer.Click += RemovePlayer_Click;
            // 
            // GameForm
            // 
            AcceptButton = StartGameButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(RemovePlayer);
            Controls.Add(NumberOfMafiaLabel);
            Controls.Add(NumberOfDoctorsLabel);
            Controls.Add(NumberOfJestersLabel);
            Controls.Add(NumberOfDetectivesLabel);
            Controls.Add(NumberOfVilagersLabel);
            Controls.Add(NumberOfVillagersNud);
            Controls.Add(NumberOfMafiaNud);
            Controls.Add(NumberOfDoctorsNud);
            Controls.Add(NumberOfJestersNud);
            Controls.Add(NumberOfDetectivesNud);
            Controls.Add(StartGameButton);
            Controls.Add(PlayerListBox);
            Controls.Add(StatusLabel);
            Controls.Add(AddPlayer);
            Controls.Add(NumberOfPlayers);
            Controls.Add(PlayerNamesTextBox);
            Controls.Add(playerCount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)playerCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDetectivesNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfJestersNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDoctorsNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfMafiaNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfVillagersNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown playerCount;
        private TextBox PlayerNamesTextBox;
        private Label NumberOfPlayers;
        private Button AddPlayer;
        private Label StatusLabel;
        private ListBox PlayerListBox;
        private Button StartGameButton;
        private NumericUpDown NumberOfDetectivesNud;
        private NumericUpDown NumberOfJestersNud;
        private NumericUpDown NumberOfDoctorsNud;
        private NumericUpDown NumberOfMafiaNud;
        private NumericUpDown NumberOfVillagersNud;
        private Label NumberOfVilagersLabel;
        private Label NumberOfDetectivesLabel;
        private Label NumberOfJestersLabel;
        private Label NumberOfDoctorsLabel;
        private Label NumberOfMafiaLabel;
        private Button RemovePlayer;
    }
}