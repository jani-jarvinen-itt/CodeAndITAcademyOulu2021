
namespace SäätiedotDemo
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
            this.kaupunkiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lisääButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valitutListBox = new System.Windows.Forms.ListBox();
            this.tuloksetTextBox = new System.Windows.Forms.TextBox();
            this.haeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kaupunkiTextBox
            // 
            this.kaupunkiTextBox.Location = new System.Drawing.Point(12, 29);
            this.kaupunkiTextBox.Name = "kaupunkiTextBox";
            this.kaupunkiTextBox.Size = new System.Drawing.Size(206, 20);
            this.kaupunkiTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Käupungin nimi:";
            // 
            // lisääButton
            // 
            this.lisääButton.Location = new System.Drawing.Point(12, 56);
            this.lisääButton.Name = "lisääButton";
            this.lisääButton.Size = new System.Drawing.Size(105, 23);
            this.lisääButton.TabIndex = 2;
            this.lisääButton.Text = "Lisää";
            this.lisääButton.UseVisualStyleBackColor = true;
            this.lisääButton.Click += new System.EventHandler(this.lisääButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valitut kaupungit:";
            // 
            // valitutListBox
            // 
            this.valitutListBox.FormattingEnabled = true;
            this.valitutListBox.Location = new System.Drawing.Point(16, 122);
            this.valitutListBox.Name = "valitutListBox";
            this.valitutListBox.Size = new System.Drawing.Size(202, 160);
            this.valitutListBox.TabIndex = 4;
            // 
            // tuloksetTextBox
            // 
            this.tuloksetTextBox.Location = new System.Drawing.Point(238, 29);
            this.tuloksetTextBox.Multiline = true;
            this.tuloksetTextBox.Name = "tuloksetTextBox";
            this.tuloksetTextBox.ReadOnly = true;
            this.tuloksetTextBox.Size = new System.Drawing.Size(279, 224);
            this.tuloksetTextBox.TabIndex = 5;
            // 
            // haeButton
            // 
            this.haeButton.Location = new System.Drawing.Point(238, 259);
            this.haeButton.Name = "haeButton";
            this.haeButton.Size = new System.Drawing.Size(117, 23);
            this.haeButton.TabIndex = 6;
            this.haeButton.Text = "Hae säätiedot";
            this.haeButton.UseVisualStyleBackColor = true;
            this.haeButton.Click += new System.EventHandler(this.haeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 287);
            this.Controls.Add(this.haeButton);
            this.Controls.Add(this.tuloksetTextBox);
            this.Controls.Add(this.valitutListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lisääButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaupunkiTextBox);
            this.Name = "Form1";
            this.Text = "Säätiedot v. 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kaupunkiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lisääButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox valitutListBox;
        private System.Windows.Forms.TextBox tuloksetTextBox;
        private System.Windows.Forms.Button haeButton;
    }
}

