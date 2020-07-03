namespace TournamentUI
{
    partial class CreateTournament
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameBox = new System.Windows.Forms.TextBox();
            this.TournNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeBotton = new System.Windows.Forms.Button();
            this.TournTeamsListBox = new System.Windows.Forms.ListBox();
            this.TournPlayersLabel = new System.Windows.Forms.Label();
            this.DeletePlayersButton = new System.Windows.Forms.Button();
            this.deleteprizebutton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.PrizeslistBox = new System.Windows.Forms.ListBox();
            this.CreateTournButoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(291, 45);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameBox
            // 
            this.TournamentNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentNameBox.Location = new System.Drawing.Point(20, 146);
            this.TournamentNameBox.Name = "TournamentNameBox";
            this.TournamentNameBox.Size = new System.Drawing.Size(283, 35);
            this.TournamentNameBox.TabIndex = 10;
            // 
            // TournNameLabel
            // 
            this.TournNameLabel.AutoSize = true;
            this.TournNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournNameLabel.Location = new System.Drawing.Point(14, 96);
            this.TournNameLabel.Name = "TournNameLabel";
            this.TournNameLabel.Size = new System.Drawing.Size(215, 32);
            this.TournNameLabel.TabIndex = 9;
            this.TournNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntryFeeValue.Location = new System.Drawing.Point(134, 205);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(14, 208);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(114, 32);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(20, 340);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(283, 38);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(13, 285);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateTeamlinkLabel
            // 
            this.CreateTeamlinkLabel.AutoSize = true;
            this.CreateTeamlinkLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamlinkLabel.Location = new System.Drawing.Point(220, 285);
            this.CreateTeamlinkLabel.Name = "CreateTeamlinkLabel";
            this.CreateTeamlinkLabel.Size = new System.Drawing.Size(163, 37);
            this.CreateTeamlinkLabel.TabIndex = 15;
            this.CreateTeamlinkLabel.TabStop = true;
            this.CreateTeamlinkLabel.Text = "Create Team";
            this.CreateTeamlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTeamlinkLabel_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTeamButton.Location = new System.Drawing.Point(75, 396);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(173, 44);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreatePrizeBotton
            // 
            this.CreatePrizeBotton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreatePrizeBotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreatePrizeBotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CreatePrizeBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeBotton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeBotton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreatePrizeBotton.Location = new System.Drawing.Point(75, 461);
            this.CreatePrizeBotton.Name = "CreatePrizeBotton";
            this.CreatePrizeBotton.Size = new System.Drawing.Size(173, 44);
            this.CreatePrizeBotton.TabIndex = 17;
            this.CreatePrizeBotton.Text = "Create Prize";
            this.CreatePrizeBotton.UseVisualStyleBackColor = true;
            this.CreatePrizeBotton.Click += new System.EventHandler(this.CreatePrizeBotton_Click);
            // 
            // TournTeamsListBox
            // 
            this.TournTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournTeamsListBox.FormattingEnabled = true;
            this.TournTeamsListBox.ItemHeight = 30;
            this.TournTeamsListBox.Location = new System.Drawing.Point(445, 88);
            this.TournTeamsListBox.Name = "TournTeamsListBox";
            this.TournTeamsListBox.Size = new System.Drawing.Size(305, 152);
            this.TournTeamsListBox.TabIndex = 18;
            // 
            // TournPlayersLabel
            // 
            this.TournPlayersLabel.AutoSize = true;
            this.TournPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournPlayersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournPlayersLabel.Location = new System.Drawing.Point(439, 38);
            this.TournPlayersLabel.Name = "TournPlayersLabel";
            this.TournPlayersLabel.Size = new System.Drawing.Size(179, 32);
            this.TournPlayersLabel.TabIndex = 19;
            this.TournPlayersLabel.Text = "Teams / Players";
            // 
            // DeletePlayersButton
            // 
            this.DeletePlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.DeletePlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeletePlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.DeletePlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePlayersButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeletePlayersButton.Location = new System.Drawing.Point(793, 378);
            this.DeletePlayersButton.Name = "DeletePlayersButton";
            this.DeletePlayersButton.Size = new System.Drawing.Size(119, 81);
            this.DeletePlayersButton.TabIndex = 20;
            this.DeletePlayersButton.Text = "Delete Selected";
            this.DeletePlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteprizebutton
            // 
            this.deleteprizebutton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteprizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteprizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.deleteprizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteprizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteprizebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteprizebutton.Location = new System.Drawing.Point(793, 121);
            this.deleteprizebutton.Name = "deleteprizebutton";
            this.deleteprizebutton.Size = new System.Drawing.Size(119, 82);
            this.deleteprizebutton.TabIndex = 23;
            this.deleteprizebutton.Text = "Delete Selected";
            this.deleteprizebutton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizesLabel.Location = new System.Drawing.Point(439, 290);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(76, 32);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Prizes";
            // 
            // PrizeslistBox
            // 
            this.PrizeslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeslistBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeslistBox.FormattingEnabled = true;
            this.PrizeslistBox.ItemHeight = 30;
            this.PrizeslistBox.Location = new System.Drawing.Point(445, 340);
            this.PrizeslistBox.Name = "PrizeslistBox";
            this.PrizeslistBox.Size = new System.Drawing.Size(305, 152);
            this.PrizeslistBox.TabIndex = 21;
            // 
            // CreateTournButoon
            // 
            this.CreateTournButoon.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateTournButoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournButoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CreateTournButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournButoon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournButoon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournButoon.Location = new System.Drawing.Point(580, 546);
            this.CreateTournButoon.Name = "CreateTournButoon";
            this.CreateTournButoon.Size = new System.Drawing.Size(360, 44);
            this.CreateTournButoon.TabIndex = 24;
            this.CreateTournButoon.Text = "Create Tournament";
            this.CreateTournButoon.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 602);
            this.Controls.Add(this.CreateTournButoon);
            this.Controls.Add(this.deleteprizebutton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.PrizeslistBox);
            this.Controls.Add(this.DeletePlayersButton);
            this.Controls.Add(this.TournPlayersLabel);
            this.Controls.Add(this.TournTeamsListBox);
            this.Controls.Add(this.CreatePrizeBotton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamlinkLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameBox);
            this.Controls.Add(this.TournNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameBox;
        private System.Windows.Forms.Label TournNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateTeamlinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeBotton;
        private System.Windows.Forms.ListBox TournTeamsListBox;
        private System.Windows.Forms.Label TournPlayersLabel;
        private System.Windows.Forms.Button DeletePlayersButton;
        private System.Windows.Forms.Button deleteprizebutton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox PrizeslistBox;
        private System.Windows.Forms.Button CreateTournButoon;
    }
}