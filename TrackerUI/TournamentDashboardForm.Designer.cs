
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.selectExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.selectExistingTournamentLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectExistingTournamentDropDown
            // 
            this.selectExistingTournamentDropDown.FormattingEnabled = true;
            this.selectExistingTournamentDropDown.Location = new System.Drawing.Point(74, 145);
            this.selectExistingTournamentDropDown.Name = "selectExistingTournamentDropDown";
            this.selectExistingTournamentDropDown.Size = new System.Drawing.Size(274, 21);
            this.selectExistingTournamentDropDown.TabIndex = 35;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.loadTournamentButton.Location = new System.Drawing.Point(122, 209);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(178, 52);
            this.loadTournamentButton.TabIndex = 34;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // selectExistingTournamentLabel
            // 
            this.selectExistingTournamentLabel.AutoSize = true;
            this.selectExistingTournamentLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExistingTournamentLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectExistingTournamentLabel.Location = new System.Drawing.Point(81, 115);
            this.selectExistingTournamentLabel.Name = "selectExistingTournamentLabel";
            this.selectExistingTournamentLabel.Size = new System.Drawing.Size(261, 25);
            this.selectExistingTournamentLabel.TabIndex = 33;
            this.selectExistingTournamentLabel.Text = "Select existing tournament";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(35, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(352, 38);
            this.headerLabel.TabIndex = 32;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(122, 304);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(178, 72);
            this.createTournamentButton.TabIndex = 36;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.selectExistingTournamentDropDown);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.selectExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Label selectExistingTournamentLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}