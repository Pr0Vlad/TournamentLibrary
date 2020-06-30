namespace TournamentUI
{
    partial class CreateTeam
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
            this.TeamNameValueBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.creatteamlabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.creatememberbutton = new System.Windows.Forms.Button();
            this.PhoneValue = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.RemovMemberbutton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValueBox
            // 
            this.TeamNameValueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNameValueBox.Location = new System.Drawing.Point(20, 113);
            this.TeamNameValueBox.Name = "TeamNameValueBox";
            this.TeamNameValueBox.Size = new System.Drawing.Size(289, 39);
            this.TeamNameValueBox.TabIndex = 13;
            this.TeamNameValueBox.TextChanged += new System.EventHandler(this.TeamNameValueBox_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(14, 63);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // creatteamlabel
            // 
            this.creatteamlabel.AutoSize = true;
            this.creatteamlabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatteamlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.creatteamlabel.Location = new System.Drawing.Point(12, 9);
            this.creatteamlabel.Name = "creatteamlabel";
            this.creatteamlabel.Size = new System.Drawing.Size(196, 45);
            this.creatteamlabel.TabIndex = 11;
            this.creatteamlabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddMemberButton.Location = new System.Drawing.Point(75, 287);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(173, 44);
            this.AddMemberButton.TabIndex = 19;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(20, 231);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(289, 40);
            this.SelectTeamMemberDropDown.TabIndex = 18;
            this.SelectTeamMemberDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamMemberDropDown_SelectedIndexChanged);
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(13, 176);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMemberLabel.TabIndex = 17;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.creatememberbutton);
            this.AddNewMemberBox.Controls.Add(this.PhoneValue);
            this.AddNewMemberBox.Controls.Add(this.PhoneLabel);
            this.AddNewMemberBox.Controls.Add(this.EmailValue);
            this.AddNewMemberBox.Controls.Add(this.EmailAddressLabel);
            this.AddNewMemberBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMemberBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddNewMemberBox.Location = new System.Drawing.Point(20, 375);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(397, 344);
            this.AddNewMemberBox.TabIndex = 20;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // creatememberbutton
            // 
            this.creatememberbutton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.creatememberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.creatememberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.creatememberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatememberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatememberbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.creatememberbutton.Location = new System.Drawing.Point(90, 281);
            this.creatememberbutton.Name = "creatememberbutton";
            this.creatememberbutton.Size = new System.Drawing.Size(203, 44);
            this.creatememberbutton.TabIndex = 20;
            this.creatememberbutton.Text = "Create Member";
            this.creatememberbutton.UseVisualStyleBackColor = true;
            this.creatememberbutton.Click += new System.EventHandler(this.creatememberbutton_Click);
            // 
            // PhoneValue
            // 
            this.PhoneValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneValue.Location = new System.Drawing.Point(155, 223);
            this.PhoneValue.Name = "PhoneValue";
            this.PhoneValue.Size = new System.Drawing.Size(207, 43);
            this.PhoneValue.TabIndex = 16;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PhoneLabel.Location = new System.Drawing.Point(15, 230);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(83, 32);
            this.PhoneLabel.TabIndex = 15;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailValue
            // 
            this.EmailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailValue.Location = new System.Drawing.Point(155, 162);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(207, 43);
            this.EmailValue.TabIndex = 14;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EmailAddressLabel.Location = new System.Drawing.Point(15, 169);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(72, 32);
            this.EmailAddressLabel.TabIndex = 13;
            this.EmailAddressLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameValue.Location = new System.Drawing.Point(155, 97);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(207, 43);
            this.LastNameValue.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LastNameLabel.Location = new System.Drawing.Point(15, 104);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(127, 32);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameValue.Location = new System.Drawing.Point(155, 42);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(207, 43);
            this.FirstNameValue.TabIndex = 10;
            this.FirstNameValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 49);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(130, 32);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(437, 113);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(430, 572);
            this.TeamMembersListBox.TabIndex = 22;
            // 
            // RemovMemberbutton
            // 
            this.RemovMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.RemovMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RemovMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RemovMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovMemberbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RemovMemberbutton.Location = new System.Drawing.Point(935, 350);
            this.RemovMemberbutton.Name = "RemovMemberbutton";
            this.RemovMemberbutton.Size = new System.Drawing.Size(119, 110);
            this.RemovMemberbutton.TabIndex = 24;
            this.RemovMemberbutton.Text = "Remove Selected Member";
            this.RemovMemberbutton.UseVisualStyleBackColor = true;
            this.RemovMemberbutton.Click += new System.EventHandler(this.RemovMemberbutton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTeamButton.Location = new System.Drawing.Point(731, 729);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(356, 44);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 785);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.RemovMemberbutton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValueBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.creatteamlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.Load += new System.EventHandler(this.CreateTeam_Load);
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValueBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label creatteamlabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button creatememberbutton;
        private System.Windows.Forms.TextBox PhoneValue;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button RemovMemberbutton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}