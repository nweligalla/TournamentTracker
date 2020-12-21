
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchUpListBox = new System.Windows.Forms.ListBox();
            this.team1Label = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team1ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(28, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(197, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tournamentName.Location = new System.Drawing.Point(231, 39);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(126, 38);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<None>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.roundLabel.Location = new System.Drawing.Point(30, 118);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(73, 25);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(116, 120);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(183, 23);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(116, 164);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(144, 27);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            this.matchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchUpListBox.FormattingEnabled = true;
            this.matchUpListBox.ItemHeight = 15;
            this.matchUpListBox.Location = new System.Drawing.Point(35, 212);
            this.matchUpListBox.Name = "matchUpListBox";
            this.matchUpListBox.Size = new System.Drawing.Size(264, 242);
            this.matchUpListBox.TabIndex = 5;
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.team1Label.Location = new System.Drawing.Point(347, 166);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(103, 25);
            this.team1Label.TabIndex = 6;
            this.team1Label.Text = "<Team 1>";
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1ScoreLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.team1ScoreLabel.Location = new System.Drawing.Point(347, 221);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(65, 25);
            this.team1ScoreLabel.TabIndex = 7;
            this.team1ScoreLabel.Text = "Score";
            // 
            // team1ScoreValue
            // 
            this.team1ScoreValue.Location = new System.Drawing.Point(429, 223);
            this.team1ScoreValue.Name = "team1ScoreValue";
            this.team1ScoreValue.Size = new System.Drawing.Size(220, 23);
            this.team1ScoreValue.TabIndex = 8;
            // 
            // team2ScoreValue
            // 
            this.team2ScoreValue.Location = new System.Drawing.Point(429, 383);
            this.team2ScoreValue.Name = "team2ScoreValue";
            this.team2ScoreValue.Size = new System.Drawing.Size(220, 23);
            this.team2ScoreValue.TabIndex = 11;
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2ScoreLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.team2ScoreLabel.Location = new System.Drawing.Point(346, 381);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(65, 25);
            this.team2ScoreLabel.TabIndex = 10;
            this.team2ScoreLabel.Text = "Score";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.team2Label.Location = new System.Drawing.Point(347, 326);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(103, 25);
            this.team2Label.TabIndex = 9;
            this.team2Label.Text = "<Team 2>";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vsLabel.Location = new System.Drawing.Point(510, 291);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(37, 25);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "VS";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.scoreButton.Location = new System.Drawing.Point(697, 279);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(115, 51);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 494);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.team2ScoreValue);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team2Label);
            this.Controls.Add(this.team1ScoreValue);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.matchUpListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TournamentViewerForm";
            this.Text = "Tornament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchUpListBox;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.TextBox team1ScoreValue;
        private System.Windows.Forms.TextBox team2ScoreValue;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

