
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButtton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(35, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(289, 38);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(37, 97);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(186, 25);
            this.tournamentNameLabel.TabIndex = 4;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Location = new System.Drawing.Point(42, 139);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(342, 20);
            this.tournamentNameText.TabIndex = 9;
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(159, 210);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(225, 20);
            this.EntryFeeValue.TabIndex = 11;
            this.EntryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(37, 206);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(99, 25);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(37, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Team";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(42, 300);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(342, 21);
            this.roundDropDown.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(311, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addTeamButton.Location = new System.Drawing.Point(130, 338);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(178, 52);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButtton
            // 
            this.createPrizeButtton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createPrizeButtton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createPrizeButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButtton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButtton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createPrizeButtton.Location = new System.Drawing.Point(130, 408);
            this.createPrizeButtton.Name = "createPrizeButtton";
            this.createPrizeButtton.Size = new System.Drawing.Size(178, 52);
            this.createPrizeButtton.TabIndex = 17;
            this.createPrizeButtton.Text = "Create Prize";
            this.createPrizeButtton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(432, 119);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(226, 145);
            this.tournamentPlayersListBox.TabIndex = 18;
            // 
            // teamPlayersLabel
            // 
            this.teamPlayersLabel.AutoSize = true;
            this.teamPlayersLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayersLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamPlayersLabel.Location = new System.Drawing.Point(427, 77);
            this.teamPlayersLabel.Name = "teamPlayersLabel";
            this.teamPlayersLabel.Size = new System.Drawing.Size(157, 25);
            this.teamPlayersLabel.TabIndex = 19;
            this.teamPlayersLabel.Text = "Teams /Players";
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(676, 163);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(117, 62);
            this.deleteSelectedPlayerButton.TabIndex = 20;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(676, 374);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(117, 62);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prizeLabel.Location = new System.Drawing.Point(427, 288);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(58, 25);
            this.prizeLabel.TabIndex = 22;
            this.prizeLabel.Text = "Prize";
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.Location = new System.Drawing.Point(432, 330);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(226, 145);
            this.prizeListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(298, 516);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(239, 52);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 580);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.teamPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButtton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameText);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = " Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButtton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label teamPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}