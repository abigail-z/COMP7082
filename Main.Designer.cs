namespace COMP7082
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.historyList = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinLoss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.historyTab.SuspendLayout();
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
            // statisticsTab
            // 
            this.statisticsTab.Location = new System.Drawing.Point(4, 22);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(464, 375);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Opponent,
            this.Stage,
            this.WinLoss});
            this.historyList.Location = new System.Drawing.Point(6, 6);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(452, 334);
            this.historyList.TabIndex = 0;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            // 
            // Opponent
            // 
            this.Opponent.Text = "Opponent";
            // 
            // Stage
            // 
            this.Stage.Text = "Stage";
            // 
            // WinLoss
            // 
            this.WinLoss.Text = "Win/Loss";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(383, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(302, 346);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 425);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.historyTab.ResumeLayout(false);
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
    }
}

