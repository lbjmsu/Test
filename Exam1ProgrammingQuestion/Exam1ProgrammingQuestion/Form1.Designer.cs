namespace Exam1ProgrammingQuestion
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.sportLabel = new System.Windows.Forms.Label();
            this.coachLabel = new System.Windows.Forms.Label();
            this.maxPlayersLabel = new System.Windows.Forms.Label();
            this.currentPlayersLabel = new System.Windows.Forms.Label();
            this.toStringTextBox = new System.Windows.Forms.TextBox();
            this.golfButton = new System.Windows.Forms.Button();
            this.baseballButton = new System.Windows.Forms.Button();
            this.sportTextBox = new System.Windows.Forms.TextBox();
            this.coachTextBox = new System.Windows.Forms.TextBox();
            this.maxPlayersTextBox = new System.Windows.Forms.TextBox();
            this.currentPlayersTextBox = new System.Windows.Forms.TextBox();
            this.playerSlotsLabel = new System.Windows.Forms.Label();
            this.playerSlotsTextBox = new System.Windows.Forms.TextBox();
            this.howToPlayTextBox = new System.Windows.Forms.TextBox();
            this.toStringLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.signatureLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(87, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(155, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Sporting Teams";
            // 
            // sportLabel
            // 
            this.sportLabel.AutoSize = true;
            this.sportLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sportLabel.Location = new System.Drawing.Point(30, 163);
            this.sportLabel.Name = "sportLabel";
            this.sportLabel.Size = new System.Drawing.Size(62, 30);
            this.sportLabel.TabIndex = 1;
            this.sportLabel.Text = "Sport";
            // 
            // coachLabel
            // 
            this.coachLabel.AutoSize = true;
            this.coachLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coachLabel.Location = new System.Drawing.Point(30, 228);
            this.coachLabel.Name = "coachLabel";
            this.coachLabel.Size = new System.Drawing.Size(71, 30);
            this.coachLabel.TabIndex = 2;
            this.coachLabel.Text = "Coach";
            // 
            // maxPlayersLabel
            // 
            this.maxPlayersLabel.AutoSize = true;
            this.maxPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxPlayersLabel.Location = new System.Drawing.Point(30, 293);
            this.maxPlayersLabel.Name = "maxPlayersLabel";
            this.maxPlayersLabel.Size = new System.Drawing.Size(124, 30);
            this.maxPlayersLabel.TabIndex = 3;
            this.maxPlayersLabel.Text = "Max Players";
            // 
            // currentPlayersLabel
            // 
            this.currentPlayersLabel.AutoSize = true;
            this.currentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPlayersLabel.Location = new System.Drawing.Point(30, 357);
            this.currentPlayersLabel.Name = "currentPlayersLabel";
            this.currentPlayersLabel.Size = new System.Drawing.Size(153, 30);
            this.currentPlayersLabel.TabIndex = 4;
            this.currentPlayersLabel.Text = "Current Players";
            // 
            // toStringTextBox
            // 
            this.toStringTextBox.Location = new System.Drawing.Point(460, 68);
            this.toStringTextBox.Multiline = true;
            this.toStringTextBox.Name = "toStringTextBox";
            this.toStringTextBox.Size = new System.Drawing.Size(328, 104);
            this.toStringTextBox.TabIndex = 5;
            // 
            // golfButton
            // 
            this.golfButton.Location = new System.Drawing.Point(55, 99);
            this.golfButton.Name = "golfButton";
            this.golfButton.Size = new System.Drawing.Size(75, 23);
            this.golfButton.TabIndex = 6;
            this.golfButton.Text = "Golf Team";
            this.golfButton.UseVisualStyleBackColor = true;
            this.golfButton.Click += new System.EventHandler(this.golfButton_Click);
            // 
            // baseballButton
            // 
            this.baseballButton.Location = new System.Drawing.Point(182, 99);
            this.baseballButton.Name = "baseballButton";
            this.baseballButton.Size = new System.Drawing.Size(103, 23);
            this.baseballButton.TabIndex = 7;
            this.baseballButton.Text = "Baseball Team";
            this.baseballButton.UseVisualStyleBackColor = true;
            this.baseballButton.Click += new System.EventHandler(this.baseballButton_Click);
            // 
            // sportTextBox
            // 
            this.sportTextBox.Location = new System.Drawing.Point(196, 170);
            this.sportTextBox.Name = "sportTextBox";
            this.sportTextBox.Size = new System.Drawing.Size(153, 23);
            this.sportTextBox.TabIndex = 8;
            // 
            // coachTextBox
            // 
            this.coachTextBox.Location = new System.Drawing.Point(196, 235);
            this.coachTextBox.Name = "coachTextBox";
            this.coachTextBox.Size = new System.Drawing.Size(153, 23);
            this.coachTextBox.TabIndex = 9;
            // 
            // maxPlayersTextBox
            // 
            this.maxPlayersTextBox.Location = new System.Drawing.Point(196, 300);
            this.maxPlayersTextBox.Name = "maxPlayersTextBox";
            this.maxPlayersTextBox.Size = new System.Drawing.Size(153, 23);
            this.maxPlayersTextBox.TabIndex = 10;
            // 
            // currentPlayersTextBox
            // 
            this.currentPlayersTextBox.Location = new System.Drawing.Point(196, 364);
            this.currentPlayersTextBox.Name = "currentPlayersTextBox";
            this.currentPlayersTextBox.Size = new System.Drawing.Size(153, 23);
            this.currentPlayersTextBox.TabIndex = 11;
            // 
            // playerSlotsLabel
            // 
            this.playerSlotsLabel.AutoSize = true;
            this.playerSlotsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerSlotsLabel.Location = new System.Drawing.Point(30, 411);
            this.playerSlotsLabel.Name = "playerSlotsLabel";
            this.playerSlotsLabel.Size = new System.Drawing.Size(161, 30);
            this.playerSlotsLabel.TabIndex = 12;
            this.playerSlotsLabel.Text = "Slots Remaining";
            // 
            // playerSlotsTextBox
            // 
            this.playerSlotsTextBox.Location = new System.Drawing.Point(196, 418);
            this.playerSlotsTextBox.Name = "playerSlotsTextBox";
            this.playerSlotsTextBox.Size = new System.Drawing.Size(153, 23);
            this.playerSlotsTextBox.TabIndex = 13;
            // 
            // howToPlayTextBox
            // 
            this.howToPlayTextBox.Location = new System.Drawing.Point(460, 208);
            this.howToPlayTextBox.Multiline = true;
            this.howToPlayTextBox.Name = "howToPlayTextBox";
            this.howToPlayTextBox.Size = new System.Drawing.Size(328, 104);
            this.howToPlayTextBox.TabIndex = 14;
            // 
            // toStringLabel
            // 
            this.toStringLabel.AutoSize = true;
            this.toStringLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toStringLabel.Location = new System.Drawing.Point(567, 35);
            this.toStringLabel.Name = "toStringLabel";
            this.toStringLabel.Size = new System.Drawing.Size(97, 30);
            this.toStringLabel.TabIndex = 15;
            this.toStringLabel.Text = "About us";
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.AutoSize = true;
            this.howToPlayLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.howToPlayLabel.Location = new System.Drawing.Point(549, 175);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(124, 30);
            this.howToPlayLabel.TabIndex = 16;
            this.howToPlayLabel.Text = "How to Play";
            // 
            // signatureLabel
            // 
            this.signatureLabel.AutoSize = true;
            this.signatureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signatureLabel.Location = new System.Drawing.Point(12, 18);
            this.signatureLabel.Name = "signatureLabel";
            this.signatureLabel.Size = new System.Drawing.Size(230, 21);
            this.signatureLabel.TabIndex = 17;
            this.signatureLabel.Text = "by Larry Johnson on 9/29/2022";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.budgetLabel.Location = new System.Drawing.Point(567, 315);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(120, 30);
            this.budgetLabel.TabIndex = 18;
            this.budgetLabel.Text = "Our Budget";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(460, 348);
            this.budgetTextBox.Multiline = true;
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(328, 93);
            this.budgetTextBox.TabIndex = 19;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.signatureLabel);
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.toStringLabel);
            this.Controls.Add(this.howToPlayTextBox);
            this.Controls.Add(this.playerSlotsTextBox);
            this.Controls.Add(this.playerSlotsLabel);
            this.Controls.Add(this.currentPlayersTextBox);
            this.Controls.Add(this.maxPlayersTextBox);
            this.Controls.Add(this.coachTextBox);
            this.Controls.Add(this.sportTextBox);
            this.Controls.Add(this.baseballButton);
            this.Controls.Add(this.golfButton);
            this.Controls.Add(this.toStringTextBox);
            this.Controls.Add(this.currentPlayersLabel);
            this.Controls.Add(this.maxPlayersLabel);
            this.Controls.Add(this.coachLabel);
            this.Controls.Add(this.sportLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.Text = "Sporting Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label sportLabel;
        private Label coachLabel;
        private Label maxPlayersLabel;
        private Label currentPlayersLabel;
        private TextBox toStringTextBox;
        private Button golfButton;
        private Button baseballButton;
        private TextBox sportTextBox;
        private TextBox coachTextBox;
        private TextBox maxPlayersTextBox;
        private TextBox currentPlayersTextBox;
        private Label playerSlotsLabel;
        private TextBox playerSlotsTextBox;
        private TextBox howToPlayTextBox;
        private Label toStringLabel;
        private Label howToPlayLabel;
        private Label signatureLabel;
        private Label budgetLabel;
        private TextBox budgetTextBox;
    }
}