namespace COMP7082.ViewsControllers
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.historyList = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinLoss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stageBox = new System.Windows.Forms.TextBox();
            this.opponentBox = new System.Windows.Forms.TextBox();
            this.characterBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.historyTab);
            this.tabControl.Controls.Add(this.statisticsTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(472, 401);
            this.tabControl.TabIndex = 0;
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.editButton);
            this.historyTab.Controls.Add(this.removeButton);
            this.historyTab.Controls.Add(this.addButton);
            this.historyTab.Controls.Add(this.historyList);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(464, 375);
            this.historyTab.TabIndex = 0;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(302, 346);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(383, 346);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Opponent,
            this.Stage,
            this.WinLoss,
            this.Timestamp});
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(6, 6);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(452, 334);
            this.historyList.TabIndex = 1;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 80;
            // 
            // Opponent
            // 
            this.Opponent.Text = "Opponent";
            this.Opponent.Width = 80;
            // 
            // Stage
            // 
            this.Stage.Text = "Stage";
            this.Stage.Width = 80;
            // 
            // WinLoss
            // 
            this.WinLoss.Text = "Win/Loss";
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 120;
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.searchButton);
            this.statisticsTab.Controls.Add(this.percentLabel);
            this.statisticsTab.Controls.Add(this.chart);
            this.statisticsTab.Controls.Add(this.statisticList);
            this.statisticsTab.Controls.Add(this.label3);
            this.statisticsTab.Controls.Add(this.label2);
            this.statisticsTab.Controls.Add(this.label1);
            this.statisticsTab.Controls.Add(this.stageBox);
            this.statisticsTab.Controls.Add(this.opponentBox);
            this.statisticsTab.Controls.Add(this.characterBox);
            this.statisticsTab.Location = new System.Drawing.Point(4, 22);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(464, 375);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(240, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(406, 6);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(15, 13);
            this.percentLabel.TabIndex = 6;
            this.percentLabel.Text = "%";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(321, 6);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Name = "Series";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(79, 67);
            this.chart.TabIndex = 0;
            this.chart.TabStop = false;
            this.chart.Text = "chart";
            // 
            // statisticList
            // 
            this.statisticList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.statisticList.FullRowSelect = true;
            this.statisticList.HideSelection = false;
            this.statisticList.Location = new System.Drawing.Point(6, 77);
            this.statisticList.Name = "statisticList";
            this.statisticList.Size = new System.Drawing.Size(452, 292);
            this.statisticList.TabIndex = 5;
            this.statisticList.UseCompatibleStateImageBehavior = false;
            this.statisticList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opponent";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stage";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Win/Loss";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Timestamp";
            this.columnHeader5.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opponent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character";
            // 
            // stageBox
            // 
            this.stageBox.Location = new System.Drawing.Point(215, 22);
            this.stageBox.Name = "stageBox";
            this.stageBox.Size = new System.Drawing.Size(100, 20);
            this.stageBox.TabIndex = 3;
            // 
            // opponentBox
            // 
            this.opponentBox.Location = new System.Drawing.Point(109, 22);
            this.opponentBox.Name = "opponentBox";
            this.opponentBox.Size = new System.Drawing.Size(100, 20);
            this.opponentBox.TabIndex = 2;
            // 
            // characterBox
            // 
            this.characterBox.Location = new System.Drawing.Point(3, 22);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(100, 20);
            this.characterBox.TabIndex = 1;
            // 
            // Main
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 425);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Game History";
            this.tabControl.ResumeLayout(false);
            this.historyTab.ResumeLayout(false);
            this.statisticsTab.ResumeLayout(false);
            this.statisticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.ListView historyList;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Opponent;
        private System.Windows.Forms.ColumnHeader Stage;
        private System.Windows.Forms.ColumnHeader WinLoss;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stageBox;
        private System.Windows.Forms.TextBox opponentBox;
        private System.Windows.Forms.TextBox characterBox;
        private System.Windows.Forms.ListView statisticList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editButton;
    }
}

