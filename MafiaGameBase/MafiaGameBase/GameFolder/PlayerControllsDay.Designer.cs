namespace MafiaGameBase.GameFolder
{
    partial class PlayerControllsDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayerNameLabel = new Label();
            VotedPlayer = new Label();
            PlayersDataGrid = new DataGridView();
            VoteButton = new Button();
            ContinueButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Location = new Point(69, 74);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(93, 20);
            PlayerNameLabel.TabIndex = 0;
            PlayerNameLabel.Text = "Player Name";
            // 
            // VotedPlayer
            // 
            VotedPlayer.AutoSize = true;
            VotedPlayer.Location = new Point(334, 74);
            VotedPlayer.Name = "VotedPlayer";
            VotedPlayer.Size = new Size(92, 20);
            VotedPlayer.TabIndex = 1;
            VotedPlayer.Text = "Player Voted";
            // 
            // PlayersDataGrid
            // 
            PlayersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayersDataGrid.Location = new Point(680, 74);
            PlayersDataGrid.Name = "PlayersDataGrid";
            PlayersDataGrid.RowHeadersWidth = 51;
            PlayersDataGrid.Size = new Size(300, 188);
            PlayersDataGrid.TabIndex = 2;
            // 
            // VoteButton
            // 
            VoteButton.Location = new Point(444, 452);
            VoteButton.Name = "VoteButton";
            VoteButton.Size = new Size(94, 29);
            VoteButton.TabIndex = 3;
            VoteButton.Text = "Vote";
            VoteButton.UseVisualStyleBackColor = true;
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(618, 452);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(94, 29);
            ContinueButton.TabIndex = 4;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            // 
            // PlayerControllsDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContinueButton);
            Controls.Add(VoteButton);
            Controls.Add(PlayersDataGrid);
            Controls.Add(VotedPlayer);
            Controls.Add(PlayerNameLabel);
            Name = "PlayerControllsDay";
            Size = new Size(1088, 565);
            ((System.ComponentModel.ISupportInitialize)PlayersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerNameLabel;
        private Label VotedPlayer;
        private DataGridView PlayersDataGrid;
        private Button VoteButton;
        private Button ContinueButton;
    }
}
