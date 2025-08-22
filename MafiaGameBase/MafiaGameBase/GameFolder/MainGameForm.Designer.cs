namespace MafiaGameBase.GameFolder
{
    partial class MainGameForm
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
            StartDayButton = new Button();
            DayCounterLabel = new Label();
            PreviusDayUpNightLabel = new Label();
            SuspendLayout();
            // 
            // StartDayButton
            // 
            StartDayButton.Location = new Point(338, 376);
            StartDayButton.Name = "StartDayButton";
            StartDayButton.Size = new Size(131, 29);
            StartDayButton.TabIndex = 0;
            StartDayButton.Text = "Start New Day";
            StartDayButton.UseVisualStyleBackColor = true;
            StartDayButton.Click += StartDayButton_Click;
            // 
            // DayCounterLabel
            // 
            DayCounterLabel.AutoSize = true;
            DayCounterLabel.Location = new Point(49, 44);
            DayCounterLabel.Name = "DayCounterLabel";
            DayCounterLabel.Size = new Size(78, 20);
            DayCounterLabel.TabIndex = 1;
            DayCounterLabel.Text = "Day Count";
            // 
            // PreviusDayUpNightLabel
            // 
            PreviusDayUpNightLabel.AutoSize = true;
            PreviusDayUpNightLabel.Location = new Point(338, 159);
            PreviusDayUpNightLabel.Name = "PreviusDayUpNightLabel";
            PreviusDayUpNightLabel.Size = new Size(131, 20);
            PreviusDayUpNightLabel.TabIndex = 2;
            PreviusDayUpNightLabel.Text = "Prev Night Update";
            // 
            // MainGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PreviusDayUpNightLabel);
            Controls.Add(DayCounterLabel);
            Controls.Add(StartDayButton);
            Name = "MainGameForm";
            Text = "MainGameForm";
            FormClosed += MainGameForm_FormClosed;
            Load += MainGameForm_Load;
            Shown += MainGameForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartDayButton;
        private Label DayCounterLabel;
        private Label PreviusDayUpNightLabel;
    }
}