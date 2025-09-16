namespace MafiaGameBase.GameFolder
{
    partial class PlayerControlsNight
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
            PlayersDataGrid = new DataGridView();
            UseAbilityButton = new Button();
            NameOfPlayerLable = new Label();
            PlayerTypeLabel = new Label();
            AbilityNameLabel = new Label();
            PlayerSelectedLabel = new Label();
            StatusLabel = new Label();
            Contuinue = new Button();
            TeamM8 = new Label();
            ((System.ComponentModel.ISupportInitialize)PlayersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PlayersDataGrid
            // 
            PlayersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayersDataGrid.Location = new Point(631, 38);
            PlayersDataGrid.Margin = new Padding(3, 2, 3, 2);
            PlayersDataGrid.Name = "PlayersDataGrid";
            PlayersDataGrid.RowHeadersWidth = 51;
            PlayersDataGrid.Size = new Size(283, 141);
            PlayersDataGrid.TabIndex = 0;
            PlayersDataGrid.SelectionChanged += PlayersDataGrid_SelectionChanged;
            // 
            // UseAbilityButton
            // 
            UseAbilityButton.Location = new Point(440, 241);
            UseAbilityButton.Margin = new Padding(3, 2, 3, 2);
            UseAbilityButton.Name = "UseAbilityButton";
            UseAbilityButton.Size = new Size(82, 22);
            UseAbilityButton.TabIndex = 1;
            UseAbilityButton.Text = "Use Ability";
            UseAbilityButton.UseVisualStyleBackColor = true;
            UseAbilityButton.Click += UseAbilityButton_Click;
            // 
            // NameOfPlayerLable
            // 
            NameOfPlayerLable.AutoSize = true;
            NameOfPlayerLable.Location = new Point(71, 52);
            NameOfPlayerLable.Name = "NameOfPlayerLable";
            NameOfPlayerLable.Size = new Size(90, 15);
            NameOfPlayerLable.TabIndex = 2;
            NameOfPlayerLable.Text = "Name Of Player";
            // 
            // PlayerTypeLabel
            // 
            PlayerTypeLabel.AutoSize = true;
            PlayerTypeLabel.Location = new Point(71, 89);
            PlayerTypeLabel.Name = "PlayerTypeLabel";
            PlayerTypeLabel.Size = new Size(67, 15);
            PlayerTypeLabel.TabIndex = 3;
            PlayerTypeLabel.Text = "Player Type";
            // 
            // AbilityNameLabel
            // 
            AbilityNameLabel.AutoSize = true;
            AbilityNameLabel.Location = new Point(72, 125);
            AbilityNameLabel.Name = "AbilityNameLabel";
            AbilityNameLabel.Size = new Size(76, 15);
            AbilityNameLabel.TabIndex = 4;
            AbilityNameLabel.Text = "Player Ability";
            // 
            // PlayerSelectedLabel
            // 
            PlayerSelectedLabel.AutoSize = true;
            PlayerSelectedLabel.Location = new Point(426, 89);
            PlayerSelectedLabel.Name = "PlayerSelectedLabel";
            PlayerSelectedLabel.Size = new Size(86, 15);
            PlayerSelectedLabel.TabIndex = 5;
            PlayerSelectedLabel.Text = "Player Selected";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(716, 189);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "Status";
            // 
            // Contuinue
            // 
            Contuinue.Location = new Point(440, 275);
            Contuinue.Margin = new Padding(3, 2, 3, 2);
            Contuinue.Name = "Contuinue";
            Contuinue.Size = new Size(82, 22);
            Contuinue.TabIndex = 7;
            Contuinue.Text = "Continue";
            Contuinue.UseVisualStyleBackColor = true;
            Contuinue.Click += Contuinue_Click;
            // 
            // TeamM8
            // 
            TeamM8.AutoSize = true;
            TeamM8.Location = new Point(72, 151);
            TeamM8.Name = "TeamM8";
            TeamM8.Size = new Size(0, 15);
            TeamM8.TabIndex = 8;
            // 
            // PlayerControlsNight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TeamM8);
            Controls.Add(Contuinue);
            Controls.Add(StatusLabel);
            Controls.Add(PlayerSelectedLabel);
            Controls.Add(AbilityNameLabel);
            Controls.Add(PlayerTypeLabel);
            Controls.Add(NameOfPlayerLable);
            Controls.Add(UseAbilityButton);
            Controls.Add(PlayersDataGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlayerControlsNight";
            Size = new Size(952, 424);
            ((System.ComponentModel.ISupportInitialize)PlayersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PlayersDataGrid;
        private Button UseAbilityButton;
        private Label NameOfPlayerLable;
        private Label PlayerTypeLabel;
        private Label AbilityNameLabel;
        private Label PlayerSelectedLabel;
        private Label StatusLabel;
        private Button Contuinue;
        private Label TeamM8;
    }
}
