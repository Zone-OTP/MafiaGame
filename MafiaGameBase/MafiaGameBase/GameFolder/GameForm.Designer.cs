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
            playerCount.Location = new Point(29, 69);
            playerCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            playerCount.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            playerCount.Name = "playerCount";
            playerCount.Size = new Size(150, 27);
            playerCount.TabIndex = 0;
            playerCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            playerCount.ValueChanged += playerCount_ValueChanged;
            // 
            // PlayerNamesTextBox
            // 
            PlayerNamesTextBox.Location = new Point(301, 68);
            PlayerNamesTextBox.Name = "PlayerNamesTextBox";
            PlayerNamesTextBox.Size = new Size(183, 27);
            PlayerNamesTextBox.TabIndex = 1;
            PlayerNamesTextBox.Text = "Player Name";
            // 
            // NumberOfPlayers
            // 
            NumberOfPlayers.AutoSize = true;
            NumberOfPlayers.Location = new Point(29, 46);
            NumberOfPlayers.Name = "NumberOfPlayers";
            NumberOfPlayers.Size = new Size(133, 20);
            NumberOfPlayers.TabIndex = 2;
            NumberOfPlayers.Text = "Number Of Players";
            // 
            // AddPlayer
            // 
            AddPlayer.Location = new Point(525, 69);
            AddPlayer.Name = "AddPlayer";
            AddPlayer.Size = new Size(94, 29);
            AddPlayer.TabIndex = 3;
            AddPlayer.Text = "Add Player";
            AddPlayer.UseVisualStyleBackColor = true;
            AddPlayer.Click += AddPlayer_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(352, 114);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(49, 20);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // PlayerListBox
            // 
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.Location = new Point(638, 46);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(150, 104);
            PlayerListBox.TabIndex = 5;
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(352, 231);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(94, 29);
            StartGameButton.TabIndex = 6;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // NumberOfDetectivesNud
            // 
            NumberOfDetectivesNud.Location = new Point(29, 380);
            NumberOfDetectivesNud.Name = "NumberOfDetectivesNud";
            NumberOfDetectivesNud.Size = new Size(150, 27);
            NumberOfDetectivesNud.TabIndex = 7;
            // 
            // NumberOfJestersNud
            // 
            NumberOfJestersNud.Location = new Point(214, 380);
            NumberOfJestersNud.Name = "NumberOfJestersNud";
            NumberOfJestersNud.Size = new Size(150, 27);
            NumberOfJestersNud.TabIndex = 8;
            // 
            // NumberOfDoctorsNud
            // 
            NumberOfDoctorsNud.Location = new Point(425, 380);
            NumberOfDoctorsNud.Name = "NumberOfDoctorsNud";
            NumberOfDoctorsNud.Size = new Size(150, 27);
            NumberOfDoctorsNud.TabIndex = 9;
            // 
            // NumberOfMafiaNud
            // 
            NumberOfMafiaNud.Location = new Point(638, 380);
            NumberOfMafiaNud.Name = "NumberOfMafiaNud";
            NumberOfMafiaNud.Size = new Size(150, 27);
            NumberOfMafiaNud.TabIndex = 10;
            // 
            // NumberOfVillagersNud
            // 
            NumberOfVillagersNud.Location = new Point(321, 322);
            NumberOfVillagersNud.Name = "NumberOfVillagersNud";
            NumberOfVillagersNud.Size = new Size(150, 27);
            NumberOfVillagersNud.TabIndex = 11;
            // 
            // NumberOfVilagersLabel
            // 
            NumberOfVilagersLabel.AutoSize = true;
            NumberOfVilagersLabel.Location = new Point(301, 299);
            NumberOfVilagersLabel.Name = "NumberOfVilagersLabel";
            NumberOfVilagersLabel.Size = new Size(198, 20);
            NumberOfVilagersLabel.TabIndex = 12;
            NumberOfVilagersLabel.Text = "Number Of Vilagers in game";
            // 
            // NumberOfDetectivesLabel
            // 
            NumberOfDetectivesLabel.AutoSize = true;
            NumberOfDetectivesLabel.Location = new Point(60, 357);
            NumberOfDetectivesLabel.Name = "NumberOfDetectivesLabel";
            NumberOfDetectivesLabel.Size = new Size(78, 20);
            NumberOfDetectivesLabel.TabIndex = 13;
            NumberOfDetectivesLabel.Text = "Detectives";
            // 
            // NumberOfJestersLabel
            // 
            NumberOfJestersLabel.AutoSize = true;
            NumberOfJestersLabel.Location = new Point(260, 357);
            NumberOfJestersLabel.Name = "NumberOfJestersLabel";
            NumberOfJestersLabel.Size = new Size(52, 20);
            NumberOfJestersLabel.TabIndex = 14;
            NumberOfJestersLabel.Text = "Jesters";
            // 
            // NumberOfDoctorsLabel
            // 
            NumberOfDoctorsLabel.AutoSize = true;
            NumberOfDoctorsLabel.Location = new Point(466, 357);
            NumberOfDoctorsLabel.Name = "NumberOfDoctorsLabel";
            NumberOfDoctorsLabel.Size = new Size(61, 20);
            NumberOfDoctorsLabel.TabIndex = 15;
            NumberOfDoctorsLabel.Text = "Doctors";
            // 
            // NumberOfMafiaLabel
            // 
            NumberOfMafiaLabel.AutoSize = true;
            NumberOfMafiaLabel.Location = new Point(678, 360);
            NumberOfMafiaLabel.Name = "NumberOfMafiaLabel";
            NumberOfMafiaLabel.Size = new Size(47, 20);
            NumberOfMafiaLabel.TabIndex = 16;
            NumberOfMafiaLabel.Text = "Mafia";
            // 
            // GameForm
            // 
            AcceptButton = StartGameButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "GameForm";
            Text = "GameForm";
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
    }
}