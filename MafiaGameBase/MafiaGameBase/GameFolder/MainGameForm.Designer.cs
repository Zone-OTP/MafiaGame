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
            StartDayButton.Location = new Point(296, 282);
            StartDayButton.Margin = new Padding(3, 2, 3, 2);
            StartDayButton.Name = "StartDayButton";
            StartDayButton.Size = new Size(115, 22);
            StartDayButton.TabIndex = 0;
            StartDayButton.Text = "Start New Day";
            StartDayButton.UseVisualStyleBackColor = true;
            StartDayButton.Click += StartDayButton_Click;
            // 
            // DayCounterLabel
            // 
            DayCounterLabel.AutoSize = true;
            DayCounterLabel.Location = new Point(43, 33);
            DayCounterLabel.Name = "DayCounterLabel";
            DayCounterLabel.Size = new Size(63, 15);
            DayCounterLabel.TabIndex = 1;
            DayCounterLabel.Text = "Day Count";
            // 
            // PreviusDayUpNightLabel
            // 
            PreviusDayUpNightLabel.AutoSize = true;
            PreviusDayUpNightLabel.Location = new Point(296, 119);
            PreviusDayUpNightLabel.Name = "PreviusDayUpNightLabel";
            PreviusDayUpNightLabel.Size = new Size(104, 15);
            PreviusDayUpNightLabel.TabIndex = 2;
            PreviusDayUpNightLabel.Text = "Prev Night Update";
            // 
            // MainGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(PreviusDayUpNightLabel);
            Controls.Add(DayCounterLabel);
            Controls.Add(StartDayButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainGameForm";
            Text = "MainGameForm";
            Activated += MainGameForm_Activated;
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