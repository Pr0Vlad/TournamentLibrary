namespace TournamentUI
{
    partial class tournamentDashBoard
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
            this.TournDashBoardbutton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.loadexisting = new System.Windows.Forms.Label();
            this.LoadTOurnButton = new System.Windows.Forms.Button();
            this.CreateTournButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournDashBoardbutton
            // 
            this.TournDashBoardbutton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.TournDashBoardbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.TournDashBoardbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.TournDashBoardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournDashBoardbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournDashBoardbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournDashBoardbutton.Location = new System.Drawing.Point(184, 38);
            this.TournDashBoardbutton.Name = "TournDashBoardbutton";
            this.TournDashBoardbutton.Size = new System.Drawing.Size(404, 44);
            this.TournDashBoardbutton.TabIndex = 27;
            this.TournDashBoardbutton.Text = "Tournament Dashboard";
            this.TournDashBoardbutton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(129, 204);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(515, 45);
            this.SelectTeamMemberDropDown.TabIndex = 29;
            // 
            // loadexisting
            // 
            this.loadexisting.AutoSize = true;
            this.loadexisting.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadexisting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadexisting.Location = new System.Drawing.Point(225, 143);
            this.loadexisting.Name = "loadexisting";
            this.loadexisting.Size = new System.Drawing.Size(322, 37);
            this.loadexisting.TabIndex = 28;
            this.loadexisting.Text = "Load Existing Tournament";
            // 
            // LoadTOurnButton
            // 
            this.LoadTOurnButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.LoadTOurnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadTOurnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.LoadTOurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTOurnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTOurnButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadTOurnButton.Location = new System.Drawing.Point(255, 277);
            this.LoadTOurnButton.Name = "LoadTOurnButton";
            this.LoadTOurnButton.Size = new System.Drawing.Size(262, 44);
            this.LoadTOurnButton.TabIndex = 37;
            this.LoadTOurnButton.Text = "Load Tournament";
            this.LoadTOurnButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournButton
            // 
            this.CreateTournButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CreateTournButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CreateTournButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournButton.Location = new System.Drawing.Point(255, 358);
            this.CreateTournButton.Name = "CreateTournButton";
            this.CreateTournButton.Size = new System.Drawing.Size(262, 92);
            this.CreateTournButton.TabIndex = 38;
            this.CreateTournButton.Text = "Create Tournament";
            this.CreateTournButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 511);
            this.Controls.Add(this.CreateTournButton);
            this.Controls.Add(this.LoadTOurnButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.loadexisting);
            this.Controls.Add(this.TournDashBoardbutton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "tournamentDashBoard";
            this.Text = "tournamentDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TournDashBoardbutton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label loadexisting;
        private System.Windows.Forms.Button LoadTOurnButton;
        private System.Windows.Forms.Button CreateTournButton;
    }
}