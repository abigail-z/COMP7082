namespace COMP7082.ViewsControllers
{
    partial class EditDialog
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
            this.characterBox = new System.Windows.Forms.TextBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.opponentBox = new System.Windows.Forms.TextBox();
            this.stageBox = new System.Windows.Forms.TextBox();
            this.winRadio = new System.Windows.Forms.RadioButton();
            this.lossRadio = new System.Windows.Forms.RadioButton();
            this.opponentLabel = new System.Windows.Forms.Label();
            this.stageLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.resultBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // characterBox
            // 
            this.characterBox.Location = new System.Drawing.Point(72, 12);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(200, 20);
            this.characterBox.TabIndex = 0;
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(13, 15);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(53, 13);
            this.characterLabel.TabIndex = 1;
            this.characterLabel.Text = "Character";
            // 
            // opponentBox
            // 
            this.opponentBox.Location = new System.Drawing.Point(72, 38);
            this.opponentBox.Name = "opponentBox";
            this.opponentBox.Size = new System.Drawing.Size(200, 20);
            this.opponentBox.TabIndex = 1;
            // 
            // stageBox
            // 
            this.stageBox.Location = new System.Drawing.Point(71, 64);
            this.stageBox.Name = "stageBox";
            this.stageBox.Size = new System.Drawing.Size(201, 20);
            this.stageBox.TabIndex = 2;
            // 
            // winRadio
            // 
            this.winRadio.AutoSize = true;
            this.winRadio.Location = new System.Drawing.Point(45, 19);
            this.winRadio.Name = "winRadio";
            this.winRadio.Size = new System.Drawing.Size(44, 17);
            this.winRadio.TabIndex = 2;
            this.winRadio.Text = "Win";
            this.winRadio.UseVisualStyleBackColor = true;
            // 
            // lossRadio
            // 
            this.lossRadio.AutoSize = true;
            this.lossRadio.Location = new System.Drawing.Point(126, 19);
            this.lossRadio.Name = "lossRadio";
            this.lossRadio.Size = new System.Drawing.Size(47, 17);
            this.lossRadio.TabIndex = 2;
            this.lossRadio.Text = "Loss";
            this.lossRadio.UseVisualStyleBackColor = true;
            // 
            // opponentLabel
            // 
            this.opponentLabel.AutoSize = true;
            this.opponentLabel.Location = new System.Drawing.Point(12, 41);
            this.opponentLabel.Name = "opponentLabel";
            this.opponentLabel.Size = new System.Drawing.Size(54, 13);
            this.opponentLabel.TabIndex = 1;
            this.opponentLabel.Text = "Opponent";
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Location = new System.Drawing.Point(30, 67);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(35, 13);
            this.stageLabel.TabIndex = 1;
            this.stageLabel.Text = "Stage";
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.winRadio);
            this.resultBox.Controls.Add(this.lossRadio);
            this.resultBox.Location = new System.Drawing.Point(71, 90);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(201, 47);
            this.resultBox.TabIndex = 3;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(116, 146);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditDialog
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(298, 181);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.opponentLabel);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.stageBox);
            this.Controls.Add(this.opponentBox);
            this.Controls.Add(this.characterBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditDialog";
            this.Text = "Add";
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox characterBox;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox opponentBox;
        private System.Windows.Forms.TextBox stageBox;
        private System.Windows.Forms.RadioButton winRadio;
        private System.Windows.Forms.RadioButton lossRadio;
        private System.Windows.Forms.Label opponentLabel;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}