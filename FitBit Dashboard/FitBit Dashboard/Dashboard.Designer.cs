namespace FitBit_Dashboard
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.competitionTab = new System.Windows.Forms.TabControl();
            this.myStuffTab = new System.Windows.Forms.TabPage();
            this.fitbitLoginButton = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.distanceClimbedLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.distanceImage = new System.Windows.Forms.PictureBox();
            this.distanceClimbedTextBox = new System.Windows.Forms.TextBox();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.distanceClimbedImage = new System.Windows.Forms.PictureBox();
            this.foodImage = new System.Windows.Forms.PictureBox();
            this.myStatsLabel = new System.Windows.Forms.Label();
            this.myStatsTextBox = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.myGroupsTab = new System.Windows.Forms.TabPage();
            this.groupStatsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statsTextBox = new System.Windows.Forms.TextBox();
            this.teammatesListBox = new System.Windows.Forms.ListBox();
            this.teammatesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.myGroupTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTab = new System.Windows.Forms.TabPage();
            this.add_user_button = new System.Windows.Forms.Button();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.removeFromGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addToGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.leaderboardTab = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupLeaderboardLabel = new System.Windows.Forms.Label();
            this.indLeaderboardLabel = new System.Windows.Forms.Label();
            this.individualLeaderboard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupLeaderboard = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.leaderboardComboBox = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.competitionTab.SuspendLayout();
            this.myStuffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceClimbedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).BeginInit();
            this.myGroupsTab.SuspendLayout();
            this.userTab.SuspendLayout();
            this.groupsTab.SuspendLayout();
            this.leaderboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLeaderboard)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // competitionTab
            // 
            this.competitionTab.Controls.Add(this.myStuffTab);
            this.competitionTab.Controls.Add(this.myGroupsTab);
            this.competitionTab.Controls.Add(this.userTab);
            this.competitionTab.Controls.Add(this.groupsTab);
            this.competitionTab.Controls.Add(this.leaderboardTab);
            this.competitionTab.Controls.Add(this.tabPage1);
            this.competitionTab.Location = new System.Drawing.Point(9, 10);
            this.competitionTab.Margin = new System.Windows.Forms.Padding(2);
            this.competitionTab.Name = "competitionTab";
            this.competitionTab.SelectedIndex = 0;
            this.competitionTab.Size = new System.Drawing.Size(700, 311);
            this.competitionTab.TabIndex = 4;
            this.competitionTab.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // myStuffTab
            // 
            this.myStuffTab.BackColor = System.Drawing.Color.Gray;
            this.myStuffTab.Controls.Add(this.fitbitLoginButton);
            this.myStuffTab.Controls.Add(this.distanceLabel);
            this.myStuffTab.Controls.Add(this.foodLabel);
            this.myStuffTab.Controls.Add(this.distanceClimbedLabel);
            this.myStuffTab.Controls.Add(this.distanceTextBox);
            this.myStuffTab.Controls.Add(this.distanceImage);
            this.myStuffTab.Controls.Add(this.distanceClimbedTextBox);
            this.myStuffTab.Controls.Add(this.foodTextBox);
            this.myStuffTab.Controls.Add(this.distanceClimbedImage);
            this.myStuffTab.Controls.Add(this.foodImage);
            this.myStuffTab.Controls.Add(this.myStatsLabel);
            this.myStuffTab.Controls.Add(this.myStatsTextBox);
            this.myStuffTab.Controls.Add(this.logoutButton);
            this.myStuffTab.Location = new System.Drawing.Point(4, 22);
            this.myStuffTab.Margin = new System.Windows.Forms.Padding(2);
            this.myStuffTab.Name = "myStuffTab";
            this.myStuffTab.Padding = new System.Windows.Forms.Padding(2);
            this.myStuffTab.Size = new System.Drawing.Size(692, 285);
            this.myStuffTab.TabIndex = 3;
            this.myStuffTab.Text = "My Stuff";
            // 
            // fitbitLoginButton
            // 
            this.fitbitLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("fitbitLoginButton.Image")));
            this.fitbitLoginButton.Location = new System.Drawing.Point(98, 6);
            this.fitbitLoginButton.Name = "fitbitLoginButton";
            this.fitbitLoginButton.Size = new System.Drawing.Size(41, 36);
            this.fitbitLoginButton.TabIndex = 14;
            this.fitbitLoginButton.UseVisualStyleBackColor = true;
            this.fitbitLoginButton.Click += new System.EventHandler(this.fitbitLoginButton_Click);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.Color.Black;
            this.distanceLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.distanceLabel.Location = new System.Drawing.Point(166, 24);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(166, 18);
            this.distanceLabel.TabIndex = 13;
            this.distanceLabel.Text = "Distance Traveled";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.BackColor = System.Drawing.Color.Black;
            this.foodLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.foodLabel.Location = new System.Drawing.Point(538, 24);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(147, 18);
            this.foodLabel.TabIndex = 12;
            this.foodLabel.Text = "Calories Burned";
            // 
            // distanceClimbedLabel
            // 
            this.distanceClimbedLabel.AutoSize = true;
            this.distanceClimbedLabel.BackColor = System.Drawing.Color.Black;
            this.distanceClimbedLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceClimbedLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.distanceClimbedLabel.Location = new System.Drawing.Point(352, 24);
            this.distanceClimbedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceClimbedLabel.Name = "distanceClimbedLabel";
            this.distanceClimbedLabel.Size = new System.Drawing.Size(157, 18);
            this.distanceClimbedLabel.TabIndex = 10;
            this.distanceClimbedLabel.Text = "Distance Climbed";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(172, 46);
            this.distanceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.distanceTextBox.Multiline = true;
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.distanceTextBox.Size = new System.Drawing.Size(144, 49);
            this.distanceTextBox.TabIndex = 8;
            // 
            // distanceImage
            // 
            this.distanceImage.Location = new System.Drawing.Point(161, 99);
            this.distanceImage.Margin = new System.Windows.Forms.Padding(2);
            this.distanceImage.Name = "distanceImage";
            this.distanceImage.Size = new System.Drawing.Size(164, 178);
            this.distanceImage.TabIndex = 7;
            this.distanceImage.TabStop = false;
            // 
            // distanceClimbedTextBox
            // 
            this.distanceClimbedTextBox.Location = new System.Drawing.Point(356, 46);
            this.distanceClimbedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.distanceClimbedTextBox.Multiline = true;
            this.distanceClimbedTextBox.Name = "distanceClimbedTextBox";
            this.distanceClimbedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.distanceClimbedTextBox.Size = new System.Drawing.Size(144, 49);
            this.distanceClimbedTextBox.TabIndex = 6;
            // 
            // foodTextBox
            // 
            this.foodTextBox.Location = new System.Drawing.Point(537, 46);
            this.foodTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.foodTextBox.Multiline = true;
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foodTextBox.Size = new System.Drawing.Size(144, 49);
            this.foodTextBox.TabIndex = 4;
            // 
            // distanceClimbedImage
            // 
            this.distanceClimbedImage.Location = new System.Drawing.Point(343, 99);
            this.distanceClimbedImage.Margin = new System.Windows.Forms.Padding(2);
            this.distanceClimbedImage.Name = "distanceClimbedImage";
            this.distanceClimbedImage.Size = new System.Drawing.Size(164, 178);
            this.distanceClimbedImage.TabIndex = 5;
            this.distanceClimbedImage.TabStop = false;
            // 
            // foodImage
            // 
            this.foodImage.Location = new System.Drawing.Point(525, 99);
            this.foodImage.Margin = new System.Windows.Forms.Padding(2);
            this.foodImage.Name = "foodImage";
            this.foodImage.Size = new System.Drawing.Size(164, 178);
            this.foodImage.TabIndex = 3;
            this.foodImage.TabStop = false;
            // 
            // myStatsLabel
            // 
            this.myStatsLabel.AutoSize = true;
            this.myStatsLabel.BackColor = System.Drawing.Color.Black;
            this.myStatsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myStatsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.myStatsLabel.Location = new System.Drawing.Point(40, 51);
            this.myStatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myStatsLabel.Name = "myStatsLabel";
            this.myStatsLabel.Size = new System.Drawing.Size(83, 18);
            this.myStatsLabel.TabIndex = 2;
            this.myStatsLabel.Text = "My Stats";
            // 
            // myStatsTextBox
            // 
            this.myStatsTextBox.Location = new System.Drawing.Point(12, 74);
            this.myStatsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myStatsTextBox.Multiline = true;
            this.myStatsTextBox.Name = "myStatsTextBox";
            this.myStatsTextBox.Size = new System.Drawing.Size(136, 174);
            this.myStatsTextBox.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(2, 5);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(56, 24);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // myGroupsTab
            // 
            this.myGroupsTab.BackColor = System.Drawing.Color.Gray;
            this.myGroupsTab.Controls.Add(this.groupStatsTextBox);
            this.myGroupsTab.Controls.Add(this.label5);
            this.myGroupsTab.Controls.Add(this.statsTextBox);
            this.myGroupsTab.Controls.Add(this.teammatesListBox);
            this.myGroupsTab.Controls.Add(this.teammatesLabel);
            this.myGroupsTab.Controls.Add(this.nameLabel);
            this.myGroupsTab.Controls.Add(this.myGroupTextBox);
            this.myGroupsTab.Controls.Add(this.label4);
            this.myGroupsTab.Controls.Add(this.label3);
            this.myGroupsTab.Location = new System.Drawing.Point(4, 22);
            this.myGroupsTab.Margin = new System.Windows.Forms.Padding(2);
            this.myGroupsTab.Name = "myGroupsTab";
            this.myGroupsTab.Padding = new System.Windows.Forms.Padding(2);
            this.myGroupsTab.Size = new System.Drawing.Size(692, 285);
            this.myGroupsTab.TabIndex = 2;
            this.myGroupsTab.Text = "My Group";
            // 
            // groupStatsTextBox
            // 
            this.groupStatsTextBox.Location = new System.Drawing.Point(74, 132);
            this.groupStatsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupStatsTextBox.Multiline = true;
            this.groupStatsTextBox.Name = "groupStatsTextBox";
            this.groupStatsTextBox.ReadOnly = true;
            this.groupStatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupStatsTextBox.Size = new System.Drawing.Size(152, 102);
            this.groupStatsTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(74, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Group Stats:";
            // 
            // statsTextBox
            // 
            this.statsTextBox.Location = new System.Drawing.Point(467, 51);
            this.statsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.ReadOnly = true;
            this.statsTextBox.Size = new System.Drawing.Size(150, 173);
            this.statsTextBox.TabIndex = 12;
            // 
            // teammatesListBox
            // 
            this.teammatesListBox.FormattingEnabled = true;
            this.teammatesListBox.Location = new System.Drawing.Point(271, 51);
            this.teammatesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.teammatesListBox.Name = "teammatesListBox";
            this.teammatesListBox.Size = new System.Drawing.Size(147, 173);
            this.teammatesListBox.TabIndex = 10;
            this.teammatesListBox.SelectedIndexChanged += new System.EventHandler(this.teammatesListBox_SelectedIndexChanged);
            // 
            // teammatesLabel
            // 
            this.teammatesLabel.AutoSize = true;
            this.teammatesLabel.BackColor = System.Drawing.Color.Black;
            this.teammatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teammatesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teammatesLabel.Location = new System.Drawing.Point(301, 32);
            this.teammatesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teammatesLabel.Name = "teammatesLabel";
            this.teammatesLabel.Size = new System.Drawing.Size(82, 17);
            this.teammatesLabel.TabIndex = 9;
            this.teammatesLabel.Text = "Teammates";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(2, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 8;
            // 
            // myGroupTextBox
            // 
            this.myGroupTextBox.CausesValidation = false;
            this.myGroupTextBox.Location = new System.Drawing.Point(71, 86);
            this.myGroupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myGroupTextBox.Name = "myGroupTextBox";
            this.myGroupTextBox.ReadOnly = true;
            this.myGroupTextBox.Size = new System.Drawing.Size(144, 20);
            this.myGroupTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(71, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "My Group: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // userTab
            // 
            this.userTab.BackColor = System.Drawing.Color.Gray;
            this.userTab.Controls.Add(this.add_user_button);
            this.userTab.Location = new System.Drawing.Point(4, 22);
            this.userTab.Margin = new System.Windows.Forms.Padding(2);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(2);
            this.userTab.Size = new System.Drawing.Size(692, 285);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "Users";
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(4, 5);
            this.add_user_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(69, 26);
            this.add_user_button.TabIndex = 0;
            this.add_user_button.Text = "Add User";
            this.add_user_button.UseVisualStyleBackColor = true;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // groupsTab
            // 
            this.groupsTab.BackColor = System.Drawing.Color.Gray;
            this.groupsTab.Controls.Add(this.groupsListBox);
            this.groupsTab.Controls.Add(this.removeFromGroup);
            this.groupsTab.Controls.Add(this.label2);
            this.groupsTab.Controls.Add(this.addToGroup);
            this.groupsTab.Controls.Add(this.label1);
            this.groupsTab.Controls.Add(this.usersListBox);
            this.groupsTab.Controls.Add(this.groupsComboBox);
            this.groupsTab.Controls.Add(this.addGroupButton);
            this.groupsTab.Location = new System.Drawing.Point(4, 22);
            this.groupsTab.Margin = new System.Windows.Forms.Padding(2);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Padding = new System.Windows.Forms.Padding(2);
            this.groupsTab.Size = new System.Drawing.Size(692, 285);
            this.groupsTab.TabIndex = 1;
            this.groupsTab.Text = "Groups";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(395, 77);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(164, 147);
            this.groupsListBox.TabIndex = 10;
            // 
            // removeFromGroup
            // 
            this.removeFromGroup.Location = new System.Drawing.Point(311, 147);
            this.removeFromGroup.Margin = new System.Windows.Forms.Padding(2);
            this.removeFromGroup.Name = "removeFromGroup";
            this.removeFromGroup.Size = new System.Drawing.Size(56, 19);
            this.removeFromGroup.TabIndex = 9;
            this.removeFromGroup.Text = "<-- Remove";
            this.removeFromGroup.UseVisualStyleBackColor = true;
            this.removeFromGroup.Click += new System.EventHandler(this.removeFromGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(448, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Group";
            // 
            // addToGroup
            // 
            this.addToGroup.Location = new System.Drawing.Point(311, 124);
            this.addToGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addToGroup.Name = "addToGroup";
            this.addToGroup.Size = new System.Drawing.Size(56, 19);
            this.addToGroup.TabIndex = 7;
            this.addToGroup.Text = "-->";
            this.addToGroup.UseVisualStyleBackColor = true;
            this.addToGroup.Click += new System.EventHandler(this.addToGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(179, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Users";
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(121, 80);
            this.usersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(164, 147);
            this.usersListBox.TabIndex = 5;
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(418, 53);
            this.groupsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(119, 21);
            this.groupsComboBox.TabIndex = 4;
            this.groupsComboBox.SelectedIndexChanged += new System.EventHandler(this.groupsComboBox_SelectedIndexChanged);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(2, 2);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(73, 24);
            this.addGroupButton.TabIndex = 1;
            this.addGroupButton.Text = "Add Group";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // leaderboardTab
            // 
            this.leaderboardTab.BackColor = System.Drawing.Color.Gray;
            this.leaderboardTab.Controls.Add(this.leaderboardComboBox);
            this.leaderboardTab.Controls.Add(this.refreshButton);
            this.leaderboardTab.Controls.Add(this.groupLeaderboardLabel);
            this.leaderboardTab.Controls.Add(this.indLeaderboardLabel);
            this.leaderboardTab.Controls.Add(this.individualLeaderboard);
            this.leaderboardTab.Controls.Add(this.groupLeaderboard);
            this.leaderboardTab.Location = new System.Drawing.Point(4, 22);
            this.leaderboardTab.Margin = new System.Windows.Forms.Padding(2);
            this.leaderboardTab.Name = "leaderboardTab";
            this.leaderboardTab.Padding = new System.Windows.Forms.Padding(2);
            this.leaderboardTab.Size = new System.Drawing.Size(692, 285);
            this.leaderboardTab.TabIndex = 4;
            this.leaderboardTab.Text = "Leaderboard";
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(55, 56);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupLeaderboardLabel
            // 
            this.groupLeaderboardLabel.AutoSize = true;
            this.groupLeaderboardLabel.BackColor = System.Drawing.Color.Black;
            this.groupLeaderboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLeaderboardLabel.ForeColor = System.Drawing.Color.Red;
            this.groupLeaderboardLabel.Location = new System.Drawing.Point(426, 31);
            this.groupLeaderboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLeaderboardLabel.Name = "groupLeaderboardLabel";
            this.groupLeaderboardLabel.Size = new System.Drawing.Size(182, 25);
            this.groupLeaderboardLabel.TabIndex = 3;
            this.groupLeaderboardLabel.Text = "Group Leaderboard";
            // 
            // indLeaderboardLabel
            // 
            this.indLeaderboardLabel.AutoSize = true;
            this.indLeaderboardLabel.BackColor = System.Drawing.Color.Black;
            this.indLeaderboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indLeaderboardLabel.ForeColor = System.Drawing.Color.Red;
            this.indLeaderboardLabel.Location = new System.Drawing.Point(59, 31);
            this.indLeaderboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.indLeaderboardLabel.Name = "indLeaderboardLabel";
            this.indLeaderboardLabel.Size = new System.Drawing.Size(210, 25);
            this.indLeaderboardLabel.TabIndex = 2;
            this.indLeaderboardLabel.Text = "Individual Leaderboard";
            // 
            // individualLeaderboard
            // 
            this.individualLeaderboard.AllowUserToAddRows = false;
            this.individualLeaderboard.AllowUserToDeleteRows = false;
            this.individualLeaderboard.AllowUserToResizeColumns = false;
            this.individualLeaderboard.AllowUserToResizeRows = false;
            this.individualLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.individualLeaderboard.Location = new System.Drawing.Point(0, 57);
            this.individualLeaderboard.Margin = new System.Windows.Forms.Padding(2);
            this.individualLeaderboard.Name = "individualLeaderboard";
            this.individualLeaderboard.ReadOnly = true;
            this.individualLeaderboard.RowHeadersWidth = 4;
            this.individualLeaderboard.RowTemplate.Height = 24;
            this.individualLeaderboard.Size = new System.Drawing.Size(343, 234);
            this.individualLeaderboard.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Steps Taken";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Stairs Climbed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Calories Burned";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupLeaderboard
            // 
            this.groupLeaderboard.AllowUserToAddRows = false;
            this.groupLeaderboard.AllowUserToDeleteRows = false;
            this.groupLeaderboard.AllowUserToResizeColumns = false;
            this.groupLeaderboard.AllowUserToResizeRows = false;
            this.groupLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.groupLeaderboard.Location = new System.Drawing.Point(351, 57);
            this.groupLeaderboard.Margin = new System.Windows.Forms.Padding(2);
            this.groupLeaderboard.Name = "groupLeaderboard";
            this.groupLeaderboard.ReadOnly = true;
            this.groupLeaderboard.RowHeadersWidth = 4;
            this.groupLeaderboard.RowTemplate.Height = 24;
            this.groupLeaderboard.Size = new System.Drawing.Size(343, 234);
            this.groupLeaderboard.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rank";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Steps Taken";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stairs Climbed";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Calories Burned";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.saveChangesButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.endDatePicker);
            this.tabPage1.Controls.Add(this.startDateTimePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 285);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Competition";
            // 
            // leaderboardComboBox
            // 
            this.leaderboardComboBox.FormattingEnabled = true;
            this.leaderboardComboBox.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Competition"});
            this.leaderboardComboBox.Location = new System.Drawing.Point(289, 17);
            this.leaderboardComboBox.Name = "leaderboardComboBox";
            this.leaderboardComboBox.Size = new System.Drawing.Size(121, 21);
            this.leaderboardComboBox.TabIndex = 5;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(80, 61);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(395, 61);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(393, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Competition End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(75, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Competition Start Date";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(303, 108);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 5;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 331);
            this.Controls.Add(this.competitionTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "FitBit Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.competitionTab.ResumeLayout(false);
            this.myStuffTab.ResumeLayout(false);
            this.myStuffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceClimbedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodImage)).EndInit();
            this.myGroupsTab.ResumeLayout(false);
            this.myGroupsTab.PerformLayout();
            this.userTab.ResumeLayout(false);
            this.groupsTab.ResumeLayout(false);
            this.groupsTab.PerformLayout();
            this.leaderboardTab.ResumeLayout(false);
            this.leaderboardTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individualLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLeaderboard)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl competitionTab;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Button removeFromGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.TabPage myGroupsTab;
        private System.Windows.Forms.TextBox myGroupTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage myStuffTab;
        private System.Windows.Forms.ListBox teammatesListBox;
        private System.Windows.Forms.Label teammatesLabel;
        public System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox statsTextBox;
        private System.Windows.Forms.TextBox groupStatsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label myStatsLabel;
        private System.Windows.Forms.TextBox myStatsTextBox;
        private System.Windows.Forms.TabPage leaderboardTab;
        private System.Windows.Forms.DataGridView groupLeaderboard;
        private System.Windows.Forms.Label indLeaderboardLabel;
        private System.Windows.Forms.DataGridView individualLeaderboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label groupLeaderboardLabel;
        private System.Windows.Forms.PictureBox foodImage;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label distanceClimbedLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.PictureBox distanceImage;
        private System.Windows.Forms.TextBox distanceClimbedTextBox;
        private System.Windows.Forms.PictureBox distanceClimbedImage;
        private System.Windows.Forms.Button fitbitLoginButton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox leaderboardComboBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;

    }
}

