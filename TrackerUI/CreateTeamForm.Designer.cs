
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberName = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedmemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(25, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(196, 38);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(35, 110);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(271, 20);
            this.teamNameText.TabIndex = 10;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(30, 82);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(121, 25);
            this.teamNameLabel.TabIndex = 9;
            this.teamNameLabel.Text = "Team name";
            this.teamNameLabel.Click += new System.EventHandler(this.teamNameLabel_Click);
            // 
            // selectTeamMemberName
            // 
            this.selectTeamMemberName.AutoSize = true;
            this.selectTeamMemberName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamMemberName.Location = new System.Drawing.Point(27, 151);
            this.selectTeamMemberName.Name = "selectTeamMemberName";
            this.selectTeamMemberName.Size = new System.Drawing.Size(208, 25);
            this.selectTeamMemberName.TabIndex = 11;
            this.selectTeamMemberName.Text = "Select Team member";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addTeamMemberButton.Location = new System.Drawing.Point(59, 220);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(178, 40);
            this.addTeamMemberButton.TabIndex = 17;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 280);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new member";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(195, 307);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(254, 20);
            this.firstNameText.TabIndex = 20;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNamelabel.Location = new System.Drawing.Point(29, 305);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(114, 25);
            this.firstNamelabel.TabIndex = 19;
            this.firstNamelabel.Text = "First Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(195, 351);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(254, 20);
            this.lastNameText.TabIndex = 22;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lastNamelabel.Location = new System.Drawing.Point(29, 349);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(112, 25);
            this.lastNamelabel.TabIndex = 21;
            this.lastNamelabel.Text = "Last Name";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(195, 394);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(254, 20);
            this.emailText.TabIndex = 24;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.emaillabel.Location = new System.Drawing.Point(29, 392);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(63, 25);
            this.emaillabel.TabIndex = 23;
            this.emaillabel.Text = "Email";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(195, 442);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(254, 20);
            this.phoneText.TabIndex = 26;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.phonelabel.Location = new System.Drawing.Point(29, 440);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(72, 25);
            this.phonelabel.TabIndex = 25;
            this.phonelabel.Text = "Phone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createMemberButton.Location = new System.Drawing.Point(121, 479);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(178, 52);
            this.createMemberButton.TabIndex = 27;
            this.createMemberButton.Text = "Create member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.Location = new System.Drawing.Point(624, 82);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(298, 418);
            this.teamMembersListBox.TabIndex = 28;
            // 
            // deleteSelectedmemberButton
            // 
            this.deleteSelectedmemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteSelectedmemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteSelectedmemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedmemberButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedmemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedmemberButton.Location = new System.Drawing.Point(946, 180);
            this.deleteSelectedmemberButton.Name = "deleteSelectedmemberButton";
            this.deleteSelectedmemberButton.Size = new System.Drawing.Size(117, 62);
            this.deleteSelectedmemberButton.TabIndex = 29;
            this.deleteSelectedmemberButton.Text = "Delete Selected";
            this.deleteSelectedmemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTeamButton.Location = new System.Drawing.Point(594, 581);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(178, 52);
            this.createTeamButton.TabIndex = 30;
            this.createTeamButton.Text = "Create team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(32, 181);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(274, 21);
            this.selectTeamMemberDropDown.TabIndex = 31;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 664);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedmemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNamelabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNamelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberName);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label selectTeamMemberName;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedmemberButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
    }
}