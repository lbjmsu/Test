namespace Ch12Ex6
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
            this.gramsTextBox = new System.Windows.Forms.TextBox();
            this.kilogramsTextBox = new System.Windows.Forms.TextBox();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesTextBox = new System.Windows.Forms.TextBox();
            this.gramsLabel = new System.Windows.Forms.Label();
            this.kilogramsLabel = new System.Windows.Forms.Label();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.unitListBox = new System.Windows.Forms.ListBox();
            this.unitListBoxLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uCWByLarryJohnsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ver0109212022ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(233, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(331, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Unit Converter: Weight";
            // 
            // gramsTextBox
            // 
            this.gramsTextBox.Enabled = false;
            this.gramsTextBox.Location = new System.Drawing.Point(69, 162);
            this.gramsTextBox.Name = "gramsTextBox";
            this.gramsTextBox.Size = new System.Drawing.Size(229, 23);
            this.gramsTextBox.TabIndex = 1;
            // 
            // kilogramsTextBox
            // 
            this.kilogramsTextBox.Enabled = false;
            this.kilogramsTextBox.Location = new System.Drawing.Point(69, 269);
            this.kilogramsTextBox.Name = "kilogramsTextBox";
            this.kilogramsTextBox.Size = new System.Drawing.Size(229, 23);
            this.kilogramsTextBox.TabIndex = 2;
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Enabled = false;
            this.poundsTextBox.Location = new System.Drawing.Point(488, 162);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(229, 23);
            this.poundsTextBox.TabIndex = 3;
            // 
            // ouncesTextBox
            // 
            this.ouncesTextBox.Enabled = false;
            this.ouncesTextBox.Location = new System.Drawing.Point(488, 269);
            this.ouncesTextBox.Name = "ouncesTextBox";
            this.ouncesTextBox.Size = new System.Drawing.Size(229, 23);
            this.ouncesTextBox.TabIndex = 4;
            // 
            // gramsLabel
            // 
            this.gramsLabel.AutoSize = true;
            this.gramsLabel.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gramsLabel.Location = new System.Drawing.Point(149, 134);
            this.gramsLabel.Name = "gramsLabel";
            this.gramsLabel.Size = new System.Drawing.Size(71, 25);
            this.gramsLabel.TabIndex = 5;
            this.gramsLabel.Text = "Grams";
            // 
            // kilogramsLabel
            // 
            this.kilogramsLabel.AutoSize = true;
            this.kilogramsLabel.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kilogramsLabel.Location = new System.Drawing.Point(133, 241);
            this.kilogramsLabel.Name = "kilogramsLabel";
            this.kilogramsLabel.Size = new System.Drawing.Size(105, 25);
            this.kilogramsLabel.TabIndex = 6;
            this.kilogramsLabel.Text = "Kilograms";
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poundsLabel.Location = new System.Drawing.Point(564, 134);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(81, 25);
            this.poundsLabel.TabIndex = 7;
            this.poundsLabel.Text = "Pounds";
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.AutoSize = true;
            this.ouncesLabel.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ouncesLabel.Location = new System.Drawing.Point(564, 241);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(81, 25);
            this.ouncesLabel.TabIndex = 8;
            this.ouncesLabel.Text = "Ounces";
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.computeButton.Location = new System.Drawing.Point(328, 350);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(130, 43);
            this.computeButton.TabIndex = 9;
            this.computeButton.Text = "Compute!";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // unitListBox
            // 
            this.unitListBox.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.ItemHeight = 32;
            this.unitListBox.Items.AddRange(new object[] {
            "lbs",
            "g",
            "kg",
            "oz"});
            this.unitListBox.Location = new System.Drawing.Point(364, 162);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(50, 132);
            this.unitListBox.TabIndex = 10;
            this.unitListBox.SelectedIndexChanged += new System.EventHandler(this.unitListBox_SelectedIndexChanged);
            // 
            // unitListBoxLabel
            // 
            this.unitListBoxLabel.AutoSize = true;
            this.unitListBoxLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unitListBoxLabel.Location = new System.Drawing.Point(342, 138);
            this.unitListBoxLabel.Name = "unitListBoxLabel";
            this.unitListBoxLabel.Size = new System.Drawing.Size(93, 21);
            this.unitListBoxLabel.TabIndex = 11;
            this.unitListBoxLabel.Text = "Input Type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uCWByLarryJohnsonToolStripMenuItem,
            this.ver0109212022ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // uCWByLarryJohnsonToolStripMenuItem
            // 
            this.uCWByLarryJohnsonToolStripMenuItem.Name = "uCWByLarryJohnsonToolStripMenuItem";
            this.uCWByLarryJohnsonToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.uCWByLarryJohnsonToolStripMenuItem.Text = "UC: W, by Larry Johnson";
            // 
            // ver0109212022ToolStripMenuItem
            // 
            this.ver0109212022ToolStripMenuItem.Name = "ver0109212022ToolStripMenuItem";
            this.ver0109212022ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ver0109212022ToolStripMenuItem.Text = "ver. 0.1, 09-21-2022";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unitListBoxLabel);
            this.Controls.Add(this.unitListBox);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.kilogramsLabel);
            this.Controls.Add(this.gramsLabel);
            this.Controls.Add(this.ouncesTextBox);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.kilogramsTextBox);
            this.Controls.Add(this.gramsTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Unit Converter: Weight";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private TextBox gramsTextBox;
        private TextBox kilogramsTextBox;
        private TextBox poundsTextBox;
        private TextBox ouncesTextBox;
        private Label gramsLabel;
        private Label kilogramsLabel;
        private Label poundsLabel;
        private Label ouncesLabel;
        private Button computeButton;
        private ListBox unitListBox;
        private Label unitListBoxLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem uCWByLarryJohnsonToolStripMenuItem;
        private ToolStripMenuItem ver0109212022ToolStripMenuItem;
    }
}