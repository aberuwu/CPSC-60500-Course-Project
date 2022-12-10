namespace WanderinInTheWoodsProjectMain
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.character1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameGrid = new System.Windows.Forms.GroupBox();
            this.character3 = new System.Windows.Forms.PictureBox();
            this.character4 = new System.Windows.Forms.PictureBox();
            this.character2 = new System.Windows.Forms.PictureBox();
            this.forestBackground = new System.Windows.Forms.PictureBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnSimStart = new System.Windows.Forms.Button();
            this.ddlGameMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tckCharacterNumb = new System.Windows.Forms.TrackBar();
            this.lblCharacterNumb = new System.Windows.Forms.Label();
            this.lblCharacter1Steps = new System.Windows.Forms.Label();
            this.lblCharacter2Steps = new System.Windows.Forms.Label();
            this.lblCharacter3Steps = new System.Windows.Forms.Label();
            this.lblCharacter4Steps = new System.Windows.Forms.Label();
            this.lblLongestRun = new System.Windows.Forms.Label();
            this.lblShortestRun = new System.Windows.Forms.Label();
            this.lblAvgRun = new System.Windows.Forms.Label();
            this.gbxSimParams = new System.Windows.Forms.GroupBox();
            this.lblCharacterSpeedValue = new System.Windows.Forms.Label();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblWidthValue = new System.Windows.Forms.Label();
            this.lbllCurrentCharacterValue = new System.Windows.Forms.Label();
            this.tckCharacterSpeed = new System.Windows.Forms.TrackBar();
            this.lblCharacterSpeed = new System.Windows.Forms.Label();
            this.tckGridHeight = new System.Windows.Forms.TrackBar();
            this.lblGridHeight = new System.Windows.Forms.Label();
            this.tckGridWidth = new System.Windows.Forms.TrackBar();
            this.lblGridWidth = new System.Windows.Forms.Label();
            this.lblCharacter1StepsOut = new System.Windows.Forms.Label();
            this.lblCharacter2StepsOut = new System.Windows.Forms.Label();
            this.lblCharacter3StepsOut = new System.Windows.Forms.Label();
            this.lblCharacter4StepsOut = new System.Windows.Forms.Label();
            this.lblLongestRunOut = new System.Windows.Forms.Label();
            this.lblShortestRunOut = new System.Windows.Forms.Label();
            this.lblAvgRunOut = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.confetiImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulationManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.character1)).BeginInit();
            this.gameGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forestBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckCharacterNumb)).BeginInit();
            this.gbxSimParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckCharacterSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckGridHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckGridWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confetiImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // character1
            // 
            this.character1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.character1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.character1.Image = ((System.Drawing.Image)(resources.GetObject("character1.Image")));
            this.character1.Location = new System.Drawing.Point(28, 36);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(52, 50);
            this.character1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character1.TabIndex = 0;
            this.character1.TabStop = false;
            this.character1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.character1_MouseDown);
            this.character1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.character1_MouseMove);
            this.character1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.character1_MouseUp);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameGrid
            // 
            this.gameGrid.BackColor = System.Drawing.Color.Transparent;
            this.gameGrid.Controls.Add(this.character3);
            this.gameGrid.Controls.Add(this.character4);
            this.gameGrid.Controls.Add(this.character2);
            this.gameGrid.Controls.Add(this.character1);
            this.gameGrid.Controls.Add(this.forestBackground);
            this.gameGrid.Location = new System.Drawing.Point(46, 290);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(663, 501);
            this.gameGrid.TabIndex = 1;
            this.gameGrid.TabStop = false;
            this.gameGrid.Text = "The Woods";
            // 
            // character3
            // 
            this.character3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.character3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.character3.Image = ((System.Drawing.Image)(resources.GetObject("character3.Image")));
            this.character3.Location = new System.Drawing.Point(591, 36);
            this.character3.Name = "character3";
            this.character3.Size = new System.Drawing.Size(52, 50);
            this.character3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character3.TabIndex = 5;
            this.character3.TabStop = false;
            this.character3.Visible = false;
            this.character3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.character3_MouseDown);
            this.character3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.character3_MouseMove);
            this.character3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.character3_MouseUp);
            // 
            // character4
            // 
            this.character4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.character4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.character4.Image = ((System.Drawing.Image)(resources.GetObject("character4.Image")));
            this.character4.Location = new System.Drawing.Point(28, 431);
            this.character4.Name = "character4";
            this.character4.Size = new System.Drawing.Size(52, 50);
            this.character4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character4.TabIndex = 4;
            this.character4.TabStop = false;
            this.character4.Visible = false;
            this.character4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.character4_MouseDown);
            this.character4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.character4_MouseMove);
            this.character4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.character4_MouseUp);
            // 
            // character2
            // 
            this.character2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.character2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.character2.Image = ((System.Drawing.Image)(resources.GetObject("character2.Image")));
            this.character2.Location = new System.Drawing.Point(591, 431);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(52, 50);
            this.character2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character2.TabIndex = 2;
            this.character2.TabStop = false;
            this.character2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.character2_MouseDown);
            this.character2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.character2_MouseMove);
            this.character2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.character2_MouseUp);
            // 
            // forestBackground
            // 
            this.forestBackground.Image = ((System.Drawing.Image)(resources.GetObject("forestBackground.Image")));
            this.forestBackground.Location = new System.Drawing.Point(0, 0);
            this.forestBackground.Name = "forestBackground";
            this.forestBackground.Size = new System.Drawing.Size(663, 501);
            this.forestBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.forestBackground.TabIndex = 3;
            this.forestBackground.TabStop = false;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFound.Location = new System.Drawing.Point(192, 260);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(364, 31);
            this.lblFound.TabIndex = 2;
            this.lblFound.Text = "The gang is back together again!";
            this.lblFound.Visible = false;
            // 
            // btnSimStart
            // 
            this.btnSimStart.Location = new System.Drawing.Point(86, 222);
            this.btnSimStart.Name = "btnSimStart";
            this.btnSimStart.Size = new System.Drawing.Size(106, 35);
            this.btnSimStart.TabIndex = 3;
            this.btnSimStart.Text = "Start Simulation";
            this.btnSimStart.UseVisualStyleBackColor = true;
            this.btnSimStart.Click += new System.EventHandler(this.btnSimStart_Click);
            // 
            // ddlGameMode
            // 
            this.ddlGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGameMode.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlGameMode.FormattingEnabled = true;
            this.ddlGameMode.Items.AddRange(new object[] {
            "K-2 (Simple)",
            "3-5 (Intermediate)",
            "6-8 (Advanced)"});
            this.ddlGameMode.Location = new System.Drawing.Point(193, 40);
            this.ddlGameMode.Name = "ddlGameMode";
            this.ddlGameMode.Size = new System.Drawing.Size(180, 32);
            this.ddlGameMode.TabIndex = 4;
            this.ddlGameMode.SelectedIndexChanged += new System.EventHandler(this.ddlGameMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Game Mode";
            // 
            // tckCharacterNumb
            // 
            this.tckCharacterNumb.LargeChange = 1;
            this.tckCharacterNumb.Location = new System.Drawing.Point(140, 22);
            this.tckCharacterNumb.Maximum = 4;
            this.tckCharacterNumb.Minimum = 2;
            this.tckCharacterNumb.Name = "tckCharacterNumb";
            this.tckCharacterNumb.Size = new System.Drawing.Size(104, 45);
            this.tckCharacterNumb.TabIndex = 6;
            this.tckCharacterNumb.Value = 2;
            this.tckCharacterNumb.Scroll += new System.EventHandler(this.tckCharacterNumb_Scroll);
            // 
            // lblCharacterNumb
            // 
            this.lblCharacterNumb.AutoSize = true;
            this.lblCharacterNumb.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterNumb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacterNumb.Location = new System.Drawing.Point(6, 28);
            this.lblCharacterNumb.Name = "lblCharacterNumb";
            this.lblCharacterNumb.Size = new System.Drawing.Size(125, 19);
            this.lblCharacterNumb.TabIndex = 7;
            this.lblCharacterNumb.Text = "# of Characters:";
            // 
            // lblCharacter1Steps
            // 
            this.lblCharacter1Steps.AutoSize = true;
            this.lblCharacter1Steps.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter1Steps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter1Steps.Location = new System.Drawing.Point(9, 86);
            this.lblCharacter1Steps.Name = "lblCharacter1Steps";
            this.lblCharacter1Steps.Size = new System.Drawing.Size(135, 19);
            this.lblCharacter1Steps.TabIndex = 8;
            this.lblCharacter1Steps.Text = "Character 1 Steps:";
            // 
            // lblCharacter2Steps
            // 
            this.lblCharacter2Steps.AutoSize = true;
            this.lblCharacter2Steps.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter2Steps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter2Steps.Location = new System.Drawing.Point(9, 116);
            this.lblCharacter2Steps.Name = "lblCharacter2Steps";
            this.lblCharacter2Steps.Size = new System.Drawing.Size(137, 19);
            this.lblCharacter2Steps.TabIndex = 9;
            this.lblCharacter2Steps.Text = "Character 2 Steps:";
            // 
            // lblCharacter3Steps
            // 
            this.lblCharacter3Steps.AutoSize = true;
            this.lblCharacter3Steps.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter3Steps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter3Steps.Location = new System.Drawing.Point(9, 146);
            this.lblCharacter3Steps.Name = "lblCharacter3Steps";
            this.lblCharacter3Steps.Size = new System.Drawing.Size(136, 19);
            this.lblCharacter3Steps.TabIndex = 10;
            this.lblCharacter3Steps.Text = "Character 3 Steps:";
            this.lblCharacter3Steps.Visible = false;
            // 
            // lblCharacter4Steps
            // 
            this.lblCharacter4Steps.AutoSize = true;
            this.lblCharacter4Steps.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter4Steps.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter4Steps.Location = new System.Drawing.Point(9, 175);
            this.lblCharacter4Steps.Name = "lblCharacter4Steps";
            this.lblCharacter4Steps.Size = new System.Drawing.Size(138, 19);
            this.lblCharacter4Steps.TabIndex = 11;
            this.lblCharacter4Steps.Text = "Character 4 Steps:";
            this.lblCharacter4Steps.Visible = false;
            // 
            // lblLongestRun
            // 
            this.lblLongestRun.AutoSize = true;
            this.lblLongestRun.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestRun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLongestRun.Location = new System.Drawing.Point(205, 86);
            this.lblLongestRun.Name = "lblLongestRun";
            this.lblLongestRun.Size = new System.Drawing.Size(105, 19);
            this.lblLongestRun.TabIndex = 12;
            this.lblLongestRun.Text = "Longest Run:";
            // 
            // lblShortestRun
            // 
            this.lblShortestRun.AutoSize = true;
            this.lblShortestRun.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestRun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblShortestRun.Location = new System.Drawing.Point(205, 116);
            this.lblShortestRun.Name = "lblShortestRun";
            this.lblShortestRun.Size = new System.Drawing.Size(106, 19);
            this.lblShortestRun.TabIndex = 13;
            this.lblShortestRun.Text = "Shortest Run:";
            // 
            // lblAvgRun
            // 
            this.lblAvgRun.AutoSize = true;
            this.lblAvgRun.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgRun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAvgRun.Location = new System.Drawing.Point(205, 146);
            this.lblAvgRun.Name = "lblAvgRun";
            this.lblAvgRun.Size = new System.Drawing.Size(107, 19);
            this.lblAvgRun.TabIndex = 14;
            this.lblAvgRun.Text = "Average Run:";
            // 
            // gbxSimParams
            // 
            this.gbxSimParams.Controls.Add(this.lblCharacterSpeedValue);
            this.gbxSimParams.Controls.Add(this.lblHeightValue);
            this.gbxSimParams.Controls.Add(this.lblWidthValue);
            this.gbxSimParams.Controls.Add(this.lbllCurrentCharacterValue);
            this.gbxSimParams.Controls.Add(this.tckCharacterSpeed);
            this.gbxSimParams.Controls.Add(this.lblCharacterSpeed);
            this.gbxSimParams.Controls.Add(this.tckGridHeight);
            this.gbxSimParams.Controls.Add(this.lblGridHeight);
            this.gbxSimParams.Controls.Add(this.tckGridWidth);
            this.gbxSimParams.Controls.Add(this.lblGridWidth);
            this.gbxSimParams.Controls.Add(this.tckCharacterNumb);
            this.gbxSimParams.Controls.Add(this.lblCharacterNumb);
            this.gbxSimParams.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSimParams.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxSimParams.Location = new System.Drawing.Point(385, 40);
            this.gbxSimParams.Name = "gbxSimParams";
            this.gbxSimParams.Size = new System.Drawing.Size(324, 186);
            this.gbxSimParams.TabIndex = 15;
            this.gbxSimParams.TabStop = false;
            this.gbxSimParams.Text = "Simulation Parameters";
            // 
            // lblCharacterSpeedValue
            // 
            this.lblCharacterSpeedValue.AutoSize = true;
            this.lblCharacterSpeedValue.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterSpeedValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacterSpeedValue.Location = new System.Drawing.Point(248, 135);
            this.lblCharacterSpeedValue.Name = "lblCharacterSpeedValue";
            this.lblCharacterSpeedValue.Size = new System.Drawing.Size(16, 19);
            this.lblCharacterSpeedValue.TabIndex = 17;
            this.lblCharacterSpeedValue.Text = "1";
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.AutoSize = true;
            this.lblHeightValue.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeightValue.Location = new System.Drawing.Point(248, 95);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(17, 19);
            this.lblHeightValue.TabIndex = 16;
            this.lblHeightValue.Text = "3";
            // 
            // lblWidthValue
            // 
            this.lblWidthValue.AutoSize = true;
            this.lblWidthValue.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWidthValue.Location = new System.Drawing.Point(248, 61);
            this.lblWidthValue.Name = "lblWidthValue";
            this.lblWidthValue.Size = new System.Drawing.Size(17, 19);
            this.lblWidthValue.TabIndex = 15;
            this.lblWidthValue.Text = "3";
            // 
            // lbllCurrentCharacterValue
            // 
            this.lbllCurrentCharacterValue.AutoSize = true;
            this.lbllCurrentCharacterValue.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllCurrentCharacterValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbllCurrentCharacterValue.Location = new System.Drawing.Point(248, 22);
            this.lbllCurrentCharacterValue.Name = "lbllCurrentCharacterValue";
            this.lbllCurrentCharacterValue.Size = new System.Drawing.Size(18, 19);
            this.lbllCurrentCharacterValue.TabIndex = 14;
            this.lbllCurrentCharacterValue.Text = "2";
            // 
            // tckCharacterSpeed
            // 
            this.tckCharacterSpeed.Location = new System.Drawing.Point(141, 135);
            this.tckCharacterSpeed.Maximum = 3;
            this.tckCharacterSpeed.Minimum = 1;
            this.tckCharacterSpeed.Name = "tckCharacterSpeed";
            this.tckCharacterSpeed.Size = new System.Drawing.Size(104, 45);
            this.tckCharacterSpeed.TabIndex = 12;
            this.tckCharacterSpeed.Value = 1;
            this.tckCharacterSpeed.Scroll += new System.EventHandler(this.tckCharacterSpeed_Scroll);
            // 
            // lblCharacterSpeed
            // 
            this.lblCharacterSpeed.AutoSize = true;
            this.lblCharacterSpeed.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterSpeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacterSpeed.Location = new System.Drawing.Point(7, 141);
            this.lblCharacterSpeed.Name = "lblCharacterSpeed";
            this.lblCharacterSpeed.Size = new System.Drawing.Size(128, 19);
            this.lblCharacterSpeed.TabIndex = 13;
            this.lblCharacterSpeed.Text = "Character Speed:";
            // 
            // tckGridHeight
            // 
            this.tckGridHeight.Location = new System.Drawing.Point(140, 95);
            this.tckGridHeight.Maximum = 3;
            this.tckGridHeight.Minimum = 1;
            this.tckGridHeight.Name = "tckGridHeight";
            this.tckGridHeight.Size = new System.Drawing.Size(104, 45);
            this.tckGridHeight.TabIndex = 10;
            this.tckGridHeight.Value = 3;
            this.tckGridHeight.Scroll += new System.EventHandler(this.tckGridHeight_Scroll);
            // 
            // lblGridHeight
            // 
            this.lblGridHeight.AutoSize = true;
            this.lblGridHeight.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGridHeight.Location = new System.Drawing.Point(6, 101);
            this.lblGridHeight.Name = "lblGridHeight";
            this.lblGridHeight.Size = new System.Drawing.Size(100, 19);
            this.lblGridHeight.TabIndex = 11;
            this.lblGridHeight.Text = "Grid Height:";
            // 
            // tckGridWidth
            // 
            this.tckGridWidth.Location = new System.Drawing.Point(141, 61);
            this.tckGridWidth.Maximum = 3;
            this.tckGridWidth.Minimum = 1;
            this.tckGridWidth.Name = "tckGridWidth";
            this.tckGridWidth.Size = new System.Drawing.Size(104, 45);
            this.tckGridWidth.TabIndex = 8;
            this.tckGridWidth.Value = 3;
            this.tckGridWidth.Scroll += new System.EventHandler(this.tckGridWidth_Scroll);
            // 
            // lblGridWidth
            // 
            this.lblGridWidth.AutoSize = true;
            this.lblGridWidth.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridWidth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGridWidth.Location = new System.Drawing.Point(7, 67);
            this.lblGridWidth.Name = "lblGridWidth";
            this.lblGridWidth.Size = new System.Drawing.Size(95, 19);
            this.lblGridWidth.TabIndex = 9;
            this.lblGridWidth.Text = "Grid Width:";
            // 
            // lblCharacter1StepsOut
            // 
            this.lblCharacter1StepsOut.AutoSize = true;
            this.lblCharacter1StepsOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter1StepsOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter1StepsOut.Location = new System.Drawing.Point(148, 86);
            this.lblCharacter1StepsOut.Name = "lblCharacter1StepsOut";
            this.lblCharacter1StepsOut.Size = new System.Drawing.Size(42, 19);
            this.lblCharacter1StepsOut.TabIndex = 16;
            this.lblCharacter1StepsOut.Text = "###";
            // 
            // lblCharacter2StepsOut
            // 
            this.lblCharacter2StepsOut.AutoSize = true;
            this.lblCharacter2StepsOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter2StepsOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter2StepsOut.Location = new System.Drawing.Point(148, 116);
            this.lblCharacter2StepsOut.Name = "lblCharacter2StepsOut";
            this.lblCharacter2StepsOut.Size = new System.Drawing.Size(42, 19);
            this.lblCharacter2StepsOut.TabIndex = 17;
            this.lblCharacter2StepsOut.Text = "###";
            // 
            // lblCharacter3StepsOut
            // 
            this.lblCharacter3StepsOut.AutoSize = true;
            this.lblCharacter3StepsOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter3StepsOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter3StepsOut.Location = new System.Drawing.Point(148, 146);
            this.lblCharacter3StepsOut.Name = "lblCharacter3StepsOut";
            this.lblCharacter3StepsOut.Size = new System.Drawing.Size(42, 19);
            this.lblCharacter3StepsOut.TabIndex = 18;
            this.lblCharacter3StepsOut.Text = "###";
            this.lblCharacter3StepsOut.Visible = false;
            // 
            // lblCharacter4StepsOut
            // 
            this.lblCharacter4StepsOut.AutoSize = true;
            this.lblCharacter4StepsOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter4StepsOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCharacter4StepsOut.Location = new System.Drawing.Point(148, 175);
            this.lblCharacter4StepsOut.Name = "lblCharacter4StepsOut";
            this.lblCharacter4StepsOut.Size = new System.Drawing.Size(42, 19);
            this.lblCharacter4StepsOut.TabIndex = 19;
            this.lblCharacter4StepsOut.Text = "###";
            this.lblCharacter4StepsOut.Visible = false;
            // 
            // lblLongestRunOut
            // 
            this.lblLongestRunOut.AutoSize = true;
            this.lblLongestRunOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestRunOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLongestRunOut.Location = new System.Drawing.Point(316, 86);
            this.lblLongestRunOut.Name = "lblLongestRunOut";
            this.lblLongestRunOut.Size = new System.Drawing.Size(42, 19);
            this.lblLongestRunOut.TabIndex = 20;
            this.lblLongestRunOut.Text = "###";
            // 
            // lblShortestRunOut
            // 
            this.lblShortestRunOut.AutoSize = true;
            this.lblShortestRunOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestRunOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblShortestRunOut.Location = new System.Drawing.Point(317, 116);
            this.lblShortestRunOut.Name = "lblShortestRunOut";
            this.lblShortestRunOut.Size = new System.Drawing.Size(42, 19);
            this.lblShortestRunOut.TabIndex = 21;
            this.lblShortestRunOut.Text = "###";
            // 
            // lblAvgRunOut
            // 
            this.lblAvgRunOut.AutoSize = true;
            this.lblAvgRunOut.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgRunOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAvgRunOut.Location = new System.Drawing.Point(316, 146);
            this.lblAvgRunOut.Name = "lblAvgRunOut";
            this.lblAvgRunOut.Size = new System.Drawing.Size(42, 19);
            this.lblAvgRunOut.TabIndex = 22;
            this.lblAvgRunOut.Text = "###";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 35);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset Characters";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // confetiImage
            // 
            this.confetiImage.Image = ((System.Drawing.Image)(resources.GetObject("confetiImage.Image")));
            this.confetiImage.Location = new System.Drawing.Point(-8, 24);
            this.confetiImage.Name = "confetiImage";
            this.confetiImage.Size = new System.Drawing.Size(768, 803);
            this.confetiImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confetiImage.TabIndex = 24;
            this.confetiImage.TabStop = false;
            this.confetiImage.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationManualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulationManualToolStripMenuItem
            // 
            this.simulationManualToolStripMenuItem.Name = "simulationManualToolStripMenuItem";
            this.simulationManualToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.simulationManualToolStripMenuItem.Text = "Simulation Manual";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHint.Location = new System.Drawing.Point(46, 794);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(327, 17);
            this.lblHint.TabIndex = 26;
            this.lblHint.Text = "Hint: Drag and Drop characters to set new starting position";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(754, 815);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAvgRunOut);
            this.Controls.Add(this.lblShortestRunOut);
            this.Controls.Add(this.lblLongestRunOut);
            this.Controls.Add(this.lblCharacter4StepsOut);
            this.Controls.Add(this.lblCharacter3StepsOut);
            this.Controls.Add(this.lblCharacter2StepsOut);
            this.Controls.Add(this.lblCharacter1StepsOut);
            this.Controls.Add(this.gbxSimParams);
            this.Controls.Add(this.lblAvgRun);
            this.Controls.Add(this.lblShortestRun);
            this.Controls.Add(this.lblLongestRun);
            this.Controls.Add(this.lblCharacter4Steps);
            this.Controls.Add(this.lblCharacter3Steps);
            this.Controls.Add(this.lblCharacter2Steps);
            this.Controls.Add(this.lblCharacter1Steps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlGameMode);
            this.Controls.Add(this.btnSimStart);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.gameGrid);
            this.Controls.Add(this.confetiImage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Wandering In The Woods Simulation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.character1)).EndInit();
            this.gameGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forestBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckCharacterNumb)).EndInit();
            this.gbxSimParams.ResumeLayout(false);
            this.gbxSimParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckCharacterSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckGridHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckGridWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confetiImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox character1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox gameGrid;
        private System.Windows.Forms.PictureBox character2;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Button btnSimStart;
        private System.Windows.Forms.ComboBox ddlGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tckCharacterNumb;
        private System.Windows.Forms.Label lblCharacterNumb;
        private System.Windows.Forms.PictureBox forestBackground;
        private System.Windows.Forms.Label lblCharacter1Steps;
        private System.Windows.Forms.Label lblCharacter2Steps;
        private System.Windows.Forms.Label lblCharacter3Steps;
        private System.Windows.Forms.Label lblCharacter4Steps;
        private System.Windows.Forms.Label lblLongestRun;
        private System.Windows.Forms.Label lblShortestRun;
        private System.Windows.Forms.Label lblAvgRun;
        private System.Windows.Forms.GroupBox gbxSimParams;
        private System.Windows.Forms.TrackBar tckGridHeight;
        private System.Windows.Forms.Label lblGridHeight;
        private System.Windows.Forms.TrackBar tckGridWidth;
        private System.Windows.Forms.Label lblGridWidth;
        private System.Windows.Forms.TrackBar tckCharacterSpeed;
        private System.Windows.Forms.Label lblCharacterSpeed;
        private System.Windows.Forms.Label lblCharacter1StepsOut;
        private System.Windows.Forms.Label lblCharacter2StepsOut;
        private System.Windows.Forms.Label lblCharacter3StepsOut;
        private System.Windows.Forms.Label lblCharacter4StepsOut;
        private System.Windows.Forms.Label lblLongestRunOut;
        private System.Windows.Forms.Label lblShortestRunOut;
        private System.Windows.Forms.Label lblAvgRunOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox confetiImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulationManualToolStripMenuItem;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.PictureBox character3;
        private System.Windows.Forms.PictureBox character4;
        private System.Windows.Forms.Label lbllCurrentCharacterValue;
        private System.Windows.Forms.Label lblCharacterSpeedValue;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblWidthValue;
    }
}

