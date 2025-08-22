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
            ((System.ComponentModel.ISupportInitialize)PlayersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PlayersDataGrid
            // 
            PlayersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayersDataGrid.Location = new Point(721, 50);
            PlayersDataGrid.Name = "PlayersDataGrid";
            PlayersDataGrid.RowHeadersWidth = 51;
            PlayersDataGrid.Size = new Size(323, 188);
            PlayersDataGrid.TabIndex = 0;
            PlayersDataGrid.SelectionChanged += PlayersDataGrid_SelectionChanged;
            // 
            // UseAbilityButton
            // 
            UseAbilityButton.Location = new Point(503, 321);
            UseAbilityButton.Name = "UseAbilityButton";
            UseAbilityButton.Size = new Size(94, 29);
            UseAbilityButton.TabIndex = 1;
            UseAbilityButton.Text = "Use Ability";
            UseAbilityButton.UseVisualStyleBackColor = true;
            UseAbilityButton.Click += UseAbilityButton_Click;
            // 
            // NameOfPlayerLable
            // 
            NameOfPlayerLable.AutoSize = true;
            NameOfPlayerLable.Location = new Point(81, 69);
            NameOfPlayerLable.Name = "NameOfPlayerLable";
            NameOfPlayerLable.Size = new Size(113, 20);
            NameOfPlayerLable.TabIndex = 2;
            NameOfPlayerLable.Text = "Name Of Player";
            // 
            // PlayerTypeLabel
            // 
            PlayerTypeLabel.AutoSize = true;
            PlayerTypeLabel.Location = new Point(81, 119);
            PlayerTypeLabel.Name = "PlayerTypeLabel";
            PlayerTypeLabel.Size = new Size(84, 20);
            PlayerTypeLabel.TabIndex = 3;
            PlayerTypeLabel.Text = "Player Type";
            // 
            // AbilityNameLabel
            // 
            AbilityNameLabel.AutoSize = true;
            AbilityNameLabel.Location = new Point(82, 167);
            AbilityNameLabel.Name = "AbilityNameLabel";
            AbilityNameLabel.Size = new Size(96, 20);
            AbilityNameLabel.TabIndex = 4;
            AbilityNameLabel.Text = "Player Ability";
            // 
            // PlayerSelectedLabel
            // 
            PlayerSelectedLabel.AutoSize = true;
            PlayerSelectedLabel.Location = new Point(487, 119);
            PlayerSelectedLabel.Name = "PlayerSelectedLabel";
            PlayerSelectedLabel.Size = new Size(110, 20);
            PlayerSelectedLabel.TabIndex = 5;
            PlayerSelectedLabel.Text = "Player Selected";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(818, 252);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(49, 20);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "Status";
            // 
            // PlayerControlsNight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StatusLabel);
            Controls.Add(PlayerSelectedLabel);
            Controls.Add(AbilityNameLabel);
            Controls.Add(PlayerTypeLabel);
            Controls.Add(NameOfPlayerLable);
            Controls.Add(UseAbilityButton);
            Controls.Add(PlayersDataGrid);
            Name = "PlayerControlsNight";
            Size = new Size(1088, 565);
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
    }
}
