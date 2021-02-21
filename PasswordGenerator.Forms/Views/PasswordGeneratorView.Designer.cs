
namespace PasswordGenerator.Forms.Views
{
    partial class PasswordGeneratorView
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
            this.length8radioButton = new System.Windows.Forms.RadioButton();
            this.length10radioButton = new System.Windows.Forms.RadioButton();
            this.length12radioButton = new System.Windows.Forms.RadioButton();
            this.alphabetCheckBox = new System.Windows.Forms.CheckBox();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.CreatePasswordButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // length8radioButton
            // 
            this.length8radioButton.AutoSize = true;
            this.length8radioButton.Location = new System.Drawing.Point(6, 18);
            this.length8radioButton.Name = "length8radioButton";
            this.length8radioButton.Size = new System.Drawing.Size(53, 16);
            this.length8radioButton.TabIndex = 0;
            this.length8radioButton.TabStop = true;
            this.length8radioButton.Text = "8文字";
            this.length8radioButton.UseVisualStyleBackColor = true;
            // 
            // length10radioButton
            // 
            this.length10radioButton.AutoSize = true;
            this.length10radioButton.Location = new System.Drawing.Point(6, 40);
            this.length10radioButton.Name = "length10radioButton";
            this.length10radioButton.Size = new System.Drawing.Size(59, 16);
            this.length10radioButton.TabIndex = 1;
            this.length10radioButton.TabStop = true;
            this.length10radioButton.Text = "10文字";
            this.length10radioButton.UseVisualStyleBackColor = true;
            // 
            // length12radioButton
            // 
            this.length12radioButton.AutoSize = true;
            this.length12radioButton.Location = new System.Drawing.Point(6, 62);
            this.length12radioButton.Name = "length12radioButton";
            this.length12radioButton.Size = new System.Drawing.Size(59, 16);
            this.length12radioButton.TabIndex = 2;
            this.length12radioButton.TabStop = true;
            this.length12radioButton.Text = "12文字";
            this.length12radioButton.UseVisualStyleBackColor = true;
            // 
            // alphabetCheckBox
            // 
            this.alphabetCheckBox.AutoSize = true;
            this.alphabetCheckBox.Location = new System.Drawing.Point(12, 12);
            this.alphabetCheckBox.Name = "alphabetCheckBox";
            this.alphabetCheckBox.Size = new System.Drawing.Size(83, 16);
            this.alphabetCheckBox.TabIndex = 3;
            this.alphabetCheckBox.Text = "アルファベット";
            this.alphabetCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Location = new System.Drawing.Point(12, 34);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Size = new System.Drawing.Size(48, 16);
            this.numberCheckBox.TabIndex = 4;
            this.numberCheckBox.Text = "数字";
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreatePasswordButton
            // 
            this.CreatePasswordButton.Location = new System.Drawing.Point(71, 103);
            this.CreatePasswordButton.Name = "CreatePasswordButton";
            this.CreatePasswordButton.Size = new System.Drawing.Size(110, 23);
            this.CreatePasswordButton.TabIndex = 5;
            this.CreatePasswordButton.Text = "パスワード作成";
            this.CreatePasswordButton.UseVisualStyleBackColor = true;
            this.CreatePasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 141);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(26, 12);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "XXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.length8radioButton);
            this.groupBox1.Controls.Add(this.length10radioButton);
            this.groupBox1.Controls.Add(this.length12radioButton);
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パスワードの文字数";
            // 
            // PasswordGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.CreatePasswordButton);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.alphabetCheckBox);
            this.Name = "PasswordGeneratorView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton length8radioButton;
        private System.Windows.Forms.RadioButton length10radioButton;
        private System.Windows.Forms.RadioButton length12radioButton;
        private System.Windows.Forms.CheckBox alphabetCheckBox;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.Button CreatePasswordButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}