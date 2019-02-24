namespace PokemonStorageOptimizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hiddenAbilityDropDown = new System.Windows.Forms.ComboBox();
            this.ballDropDown = new System.Windows.Forms.ComboBox();
            this.eggMovesDropDown = new System.Windows.Forms.ComboBox();
            this.EggMovesAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.ivCountDropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownIVCount = new System.Windows.Forms.NumericUpDown();
            this.zeroSpeedIVCheckBox = new System.Windows.Forms.CheckBox();
            this.zeroAttackIVCheckBox = new System.Windows.Forms.CheckBox();
            this.thirtiesIVCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.legendaryCheckBox = new System.Windows.Forms.CheckBox();
            this.obviousHacksCheckBox = new System.Windows.Forms.CheckBox();
            this.dittoCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anyBallSpecialListBox = new System.Windows.Forms.ListBox();
            this.selectAllStartersButton = new System.Windows.Forms.Button();
            this.selectAllFossilsButton = new System.Windows.Forms.Button();
            this.selectAllPokemonButton = new System.Windows.Forms.Button();
            this.downloadReportButton = new System.Windows.Forms.Button();
            this.updateBoxesButton = new System.Windows.Forms.Button();
            this.resultsView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIVCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.exportDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importDataToolStripMenuItem.Text = "Import Data";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attributes to Check";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ball";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hidden Ability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Egg Moves";
            // 
            // hiddenAbilityDropDown
            // 
            this.hiddenAbilityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hiddenAbilityDropDown.FormattingEnabled = true;
            this.hiddenAbilityDropDown.Items.AddRange(new object[] {
            "Check to Keep",
            "Tie Breaker"});
            this.hiddenAbilityDropDown.Location = new System.Drawing.Point(134, 93);
            this.hiddenAbilityDropDown.Name = "hiddenAbilityDropDown";
            this.hiddenAbilityDropDown.Size = new System.Drawing.Size(121, 21);
            this.hiddenAbilityDropDown.TabIndex = 5;
            // 
            // ballDropDown
            // 
            this.ballDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ballDropDown.FormattingEnabled = true;
            this.ballDropDown.Items.AddRange(new object[] {
            "Check to Keep",
            "Tie Breaker"});
            this.ballDropDown.Location = new System.Drawing.Point(134, 62);
            this.ballDropDown.Name = "ballDropDown";
            this.ballDropDown.Size = new System.Drawing.Size(121, 21);
            this.ballDropDown.TabIndex = 6;
            // 
            // eggMovesDropDown
            // 
            this.eggMovesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eggMovesDropDown.FormattingEnabled = true;
            this.eggMovesDropDown.Items.AddRange(new object[] {
            "Check to Keep",
            "Tie Breaker"});
            this.eggMovesDropDown.Location = new System.Drawing.Point(134, 123);
            this.eggMovesDropDown.Name = "eggMovesDropDown";
            this.eggMovesDropDown.Size = new System.Drawing.Size(121, 21);
            this.eggMovesDropDown.TabIndex = 7;
            // 
            // EggMovesAllowDuplicates
            // 
            this.EggMovesAllowDuplicates.AutoSize = true;
            this.EggMovesAllowDuplicates.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EggMovesAllowDuplicates.Location = new System.Drawing.Point(134, 150);
            this.EggMovesAllowDuplicates.Name = "EggMovesAllowDuplicates";
            this.EggMovesAllowDuplicates.Size = new System.Drawing.Size(114, 18);
            this.EggMovesAllowDuplicates.TabIndex = 8;
            this.EggMovesAllowDuplicates.Text = "Allow Duplicates";
            this.EggMovesAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // ivCountDropDown
            // 
            this.ivCountDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ivCountDropDown.FormattingEnabled = true;
            this.ivCountDropDown.Items.AddRange(new object[] {
            "Check to Keep",
            "Tie Breaker"});
            this.ivCountDropDown.Location = new System.Drawing.Point(134, 174);
            this.ivCountDropDown.Name = "ivCountDropDown";
            this.ivCountDropDown.Size = new System.Drawing.Size(121, 21);
            this.ivCountDropDown.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(18, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "IV Count";
            // 
            // numericUpDownIVCount
            // 
            this.numericUpDownIVCount.Location = new System.Drawing.Point(96, 174);
            this.numericUpDownIVCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownIVCount.Name = "numericUpDownIVCount";
            this.numericUpDownIVCount.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownIVCount.TabIndex = 11;
            // 
            // zeroSpeedIVCheckBox
            // 
            this.zeroSpeedIVCheckBox.AutoSize = true;
            this.zeroSpeedIVCheckBox.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroSpeedIVCheckBox.Location = new System.Drawing.Point(134, 249);
            this.zeroSpeedIVCheckBox.Name = "zeroSpeedIVCheckBox";
            this.zeroSpeedIVCheckBox.Size = new System.Drawing.Size(125, 18);
            this.zeroSpeedIVCheckBox.TabIndex = 12;
            this.zeroSpeedIVCheckBox.Text = "Include 0 Speed IV";
            this.zeroSpeedIVCheckBox.UseVisualStyleBackColor = true;
            // 
            // zeroAttackIVCheckBox
            // 
            this.zeroAttackIVCheckBox.AutoSize = true;
            this.zeroAttackIVCheckBox.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroAttackIVCheckBox.Location = new System.Drawing.Point(134, 225);
            this.zeroAttackIVCheckBox.Name = "zeroAttackIVCheckBox";
            this.zeroAttackIVCheckBox.Size = new System.Drawing.Size(127, 18);
            this.zeroAttackIVCheckBox.TabIndex = 13;
            this.zeroAttackIVCheckBox.Text = "Include 0 Attack IV";
            this.zeroAttackIVCheckBox.UseVisualStyleBackColor = true;
            // 
            // thirtiesIVCheckBox
            // 
            this.thirtiesIVCheckBox.AutoSize = true;
            this.thirtiesIVCheckBox.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirtiesIVCheckBox.Location = new System.Drawing.Point(134, 201);
            this.thirtiesIVCheckBox.Name = "thirtiesIVCheckBox";
            this.thirtiesIVCheckBox.Size = new System.Drawing.Size(99, 18);
            this.thirtiesIVCheckBox.TabIndex = 14;
            this.thirtiesIVCheckBox.Text = "Include 30 IVs";
            this.thirtiesIVCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import Settings";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(337, 23);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Size = new System.Drawing.Size(154, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Exclusions";
            // 
            // legendaryCheckBox
            // 
            this.legendaryCheckBox.AutoSize = true;
            this.legendaryCheckBox.Font = new System.Drawing.Font("Constantia", 12F);
            this.legendaryCheckBox.Location = new System.Drawing.Point(342, 64);
            this.legendaryCheckBox.Name = "legendaryCheckBox";
            this.legendaryCheckBox.Size = new System.Drawing.Size(268, 23);
            this.legendaryCheckBox.TabIndex = 16;
            this.legendaryCheckBox.Text = "Legendary and Mythical Pokemon";
            this.legendaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // obviousHacksCheckBox
            // 
            this.obviousHacksCheckBox.AutoSize = true;
            this.obviousHacksCheckBox.Font = new System.Drawing.Font("Constantia", 12F);
            this.obviousHacksCheckBox.Location = new System.Drawing.Point(342, 123);
            this.obviousHacksCheckBox.Name = "obviousHacksCheckBox";
            this.obviousHacksCheckBox.Size = new System.Drawing.Size(134, 23);
            this.obviousHacksCheckBox.TabIndex = 17;
            this.obviousHacksCheckBox.Text = "Obvious Hacks";
            this.obviousHacksCheckBox.UseVisualStyleBackColor = true;
            // 
            // dittoCheckBox
            // 
            this.dittoCheckBox.AutoSize = true;
            this.dittoCheckBox.Font = new System.Drawing.Font("Constantia", 12F);
            this.dittoCheckBox.Location = new System.Drawing.Point(342, 93);
            this.dittoCheckBox.Name = "dittoCheckBox";
            this.dittoCheckBox.Size = new System.Drawing.Size(66, 23);
            this.dittoCheckBox.TabIndex = 18;
            this.dittoCheckBox.Text = "Ditto";
            this.dittoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(337, 158);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Size = new System.Drawing.Size(230, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Any Ball Special";
            // 
            // anyBallSpecialListBox
            // 
            this.anyBallSpecialListBox.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anyBallSpecialListBox.FormattingEnabled = true;
            this.anyBallSpecialListBox.ItemHeight = 14;
            this.anyBallSpecialListBox.Location = new System.Drawing.Point(342, 199);
            this.anyBallSpecialListBox.Name = "anyBallSpecialListBox";
            this.anyBallSpecialListBox.Size = new System.Drawing.Size(225, 74);
            this.anyBallSpecialListBox.TabIndex = 20;
            // 
            // selectAllStartersButton
            // 
            this.selectAllStartersButton.FlatAppearance.BorderSize = 0;
            this.selectAllStartersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllStartersButton.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllStartersButton.Location = new System.Drawing.Point(573, 225);
            this.selectAllStartersButton.Name = "selectAllStartersButton";
            this.selectAllStartersButton.Size = new System.Drawing.Size(118, 23);
            this.selectAllStartersButton.TabIndex = 21;
            this.selectAllStartersButton.Text = "Select All Starters";
            this.selectAllStartersButton.UseVisualStyleBackColor = true;
            // 
            // selectAllFossilsButton
            // 
            this.selectAllFossilsButton.FlatAppearance.BorderSize = 0;
            this.selectAllFossilsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllFossilsButton.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllFossilsButton.Location = new System.Drawing.Point(573, 201);
            this.selectAllFossilsButton.Name = "selectAllFossilsButton";
            this.selectAllFossilsButton.Size = new System.Drawing.Size(112, 23);
            this.selectAllFossilsButton.TabIndex = 22;
            this.selectAllFossilsButton.Text = "Select All Fossils";
            this.selectAllFossilsButton.UseVisualStyleBackColor = true;
            // 
            // selectAllPokemonButton
            // 
            this.selectAllPokemonButton.FlatAppearance.BorderSize = 0;
            this.selectAllPokemonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllPokemonButton.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllPokemonButton.Location = new System.Drawing.Point(573, 249);
            this.selectAllPokemonButton.Name = "selectAllPokemonButton";
            this.selectAllPokemonButton.Size = new System.Drawing.Size(130, 23);
            this.selectAllPokemonButton.TabIndex = 23;
            this.selectAllPokemonButton.Text = "Select All Pokemon";
            this.selectAllPokemonButton.UseVisualStyleBackColor = true;
            this.selectAllPokemonButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // downloadReportButton
            // 
            this.downloadReportButton.FlatAppearance.BorderSize = 0;
            this.downloadReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadReportButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.downloadReportButton.ForeColor = System.Drawing.Color.SlateGray;
            this.downloadReportButton.Location = new System.Drawing.Point(199, 290);
            this.downloadReportButton.Name = "downloadReportButton";
            this.downloadReportButton.Size = new System.Drawing.Size(209, 32);
            this.downloadReportButton.TabIndex = 24;
            this.downloadReportButton.Text = "Download Report";
            this.downloadReportButton.UseVisualStyleBackColor = true;
            // 
            // updateBoxesButton
            // 
            this.updateBoxesButton.FlatAppearance.BorderSize = 0;
            this.updateBoxesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBoxesButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBoxesButton.ForeColor = System.Drawing.Color.SlateGray;
            this.updateBoxesButton.Location = new System.Drawing.Point(22, 289);
            this.updateBoxesButton.Name = "updateBoxesButton";
            this.updateBoxesButton.Size = new System.Drawing.Size(171, 35);
            this.updateBoxesButton.TabIndex = 25;
            this.updateBoxesButton.Text = "Update Boxes";
            this.updateBoxesButton.UseVisualStyleBackColor = true;
            // 
            // resultsView
            // 
            this.resultsView.Location = new System.Drawing.Point(12, 330);
            this.resultsView.Name = "resultsView";
            this.resultsView.Size = new System.Drawing.Size(679, 300);
            this.resultsView.TabIndex = 26;
            this.resultsView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(703, 641);
            this.Controls.Add(this.resultsView);
            this.Controls.Add(this.updateBoxesButton);
            this.Controls.Add(this.downloadReportButton);
            this.Controls.Add(this.selectAllPokemonButton);
            this.Controls.Add(this.selectAllFossilsButton);
            this.Controls.Add(this.selectAllStartersButton);
            this.Controls.Add(this.anyBallSpecialListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dittoCheckBox);
            this.Controls.Add(this.obviousHacksCheckBox);
            this.Controls.Add(this.legendaryCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.thirtiesIVCheckBox);
            this.Controls.Add(this.zeroAttackIVCheckBox);
            this.Controls.Add(this.zeroSpeedIVCheckBox);
            this.Controls.Add(this.numericUpDownIVCount);
            this.Controls.Add(this.ivCountDropDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EggMovesAllowDuplicates);
            this.Controls.Add(this.eggMovesDropDown);
            this.Controls.Add(this.ballDropDown);
            this.Controls.Add(this.hiddenAbilityDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pokemon Storage Optimizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIVCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hiddenAbilityDropDown;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ComboBox ballDropDown;
        private System.Windows.Forms.ComboBox eggMovesDropDown;
        private System.Windows.Forms.CheckBox EggMovesAllowDuplicates;
        private System.Windows.Forms.ComboBox ivCountDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownIVCount;
        private System.Windows.Forms.CheckBox zeroSpeedIVCheckBox;
        private System.Windows.Forms.CheckBox zeroAttackIVCheckBox;
        private System.Windows.Forms.CheckBox thirtiesIVCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox legendaryCheckBox;
        private System.Windows.Forms.CheckBox obviousHacksCheckBox;
        private System.Windows.Forms.CheckBox dittoCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox anyBallSpecialListBox;
        private System.Windows.Forms.Button selectAllStartersButton;
        private System.Windows.Forms.Button selectAllFossilsButton;
        private System.Windows.Forms.Button selectAllPokemonButton;
        private System.Windows.Forms.Button downloadReportButton;
        private System.Windows.Forms.Button updateBoxesButton;
        private System.Windows.Forms.ListView resultsView;
    }
}

