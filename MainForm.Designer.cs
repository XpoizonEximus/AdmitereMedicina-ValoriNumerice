
namespace AdmitereMedicina_ValoriNumerice
{
    partial class MainForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.notknowButton = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(9, 16);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(112, 17);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "questionLabel";
            // 
            // answerButton
            // 
            this.answerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.answerButton.ForeColor = System.Drawing.Color.Green;
            this.answerButton.Location = new System.Drawing.Point(12, 171);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(109, 38);
            this.answerButton.TabIndex = 1;
            this.answerButton.Text = "✓ Răspunde";
            this.answerButton.UseVisualStyleBackColor = true;
            // 
            // notknowButton
            // 
            this.notknowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notknowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notknowButton.Location = new System.Drawing.Point(127, 171);
            this.notknowButton.Name = "notknowButton";
            this.notknowButton.Size = new System.Drawing.Size(109, 38);
            this.notknowButton.TabIndex = 2;
            this.notknowButton.Text = "✘ Nu știu";
            this.notknowButton.UseVisualStyleBackColor = true;
            // 
            // logLabel
            // 
            this.logLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logLabel.AutoSize = true;
            this.logLabel.Enabled = false;
            this.logLabel.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(12, 214);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(45, 12);
            this.logLabel.TabIndex = 3;
            this.logLabel.Text = "logLabel";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(150, 83);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(214, 25);
            this.valueTextBox.TabIndex = 4;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(9, 86);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(61, 17);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Valoare:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(9, 124);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(132, 17);
            this.unitLabel.TabIndex = 6;
            this.unitLabel.Text = "Unitate de măsură:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(150, 121);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(214, 25);
            this.unitTextBox.TabIndex = 7;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.Font = new System.Drawing.Font("Helvetica", 17F);
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(318, 171);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(52, 38);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = " ⚙";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 233);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.notknowButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.questionLabel);
            this.Font = new System.Drawing.Font("Helvetica", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admitere medicina - Valori numerice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button notknowButton;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Button settingsButton;
    }
}

