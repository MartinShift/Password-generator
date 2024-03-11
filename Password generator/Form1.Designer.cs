namespace Password_generator
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
            this.Numberbox = new System.Windows.Forms.CheckBox();
            this.SmallLetterbox = new System.Windows.Forms.CheckBox();
            this.BigLetterBox = new System.Windows.Forms.CheckBox();
            this.SymbolLetterBox = new System.Windows.Forms.CheckBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.Copybutton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numberbox
            // 
            this.Numberbox.AutoSize = true;
            this.Numberbox.Location = new System.Drawing.Point(33, 260);
            this.Numberbox.Name = "Numberbox";
            this.Numberbox.Size = new System.Drawing.Size(73, 20);
            this.Numberbox.TabIndex = 0;
            this.Numberbox.Text = "Цифри";
            this.Numberbox.UseVisualStyleBackColor = true;
            // 
            // SmallLetterbox
            // 
            this.SmallLetterbox.AutoSize = true;
            this.SmallLetterbox.Location = new System.Drawing.Point(33, 295);
            this.SmallLetterbox.Name = "SmallLetterbox";
            this.SmallLetterbox.Size = new System.Drawing.Size(131, 20);
            this.SmallLetterbox.TabIndex = 1;
            this.SmallLetterbox.Text = "Маленькі букви";
            this.SmallLetterbox.UseVisualStyleBackColor = true;
            // 
            // BigLetterBox
            // 
            this.BigLetterBox.AutoSize = true;
            this.BigLetterBox.Location = new System.Drawing.Point(33, 329);
            this.BigLetterBox.Name = "BigLetterBox";
            this.BigLetterBox.Size = new System.Drawing.Size(114, 20);
            this.BigLetterBox.TabIndex = 2;
            this.BigLetterBox.Text = "Великі букви";
            this.BigLetterBox.UseVisualStyleBackColor = true;
            // 
            // SymbolLetterBox
            // 
            this.SymbolLetterBox.AutoSize = true;
            this.SymbolLetterBox.Location = new System.Drawing.Point(33, 366);
            this.SymbolLetterBox.Name = "SymbolLetterBox";
            this.SymbolLetterBox.Size = new System.Drawing.Size(158, 20);
            this.SymbolLetterBox.TabIndex = 3;
            this.SymbolLetterBox.Text = "Спеціальні символи";
            this.SymbolLetterBox.UseVisualStyleBackColor = true;
            // 
            // SymbolTextBox
            // 
            this.SymbolTextBox.Location = new System.Drawing.Point(33, 167);
            this.SymbolTextBox.Multiline = true;
            this.SymbolTextBox.Name = "SymbolTextBox";
            this.SymbolTextBox.Size = new System.Drawing.Size(308, 42);
            this.SymbolTextBox.TabIndex = 5;
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(33, 75);
            this.LengthBox.Multiline = true;
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(308, 42);
            this.LengthBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Довжина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Символи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вибрати із символів:";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Lime;
            this.GenerateButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateButton.Location = new System.Drawing.Point(33, 399);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(141, 39);
            this.GenerateButton.TabIndex = 11;
            this.GenerateButton.Text = "Згенерувати";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.Generate);
            // 
            // Copybutton
            // 
            this.Copybutton.BackColor = System.Drawing.Color.Lime;
            this.Copybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copybutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Copybutton.Location = new System.Drawing.Point(576, 399);
            this.Copybutton.Name = "Copybutton";
            this.Copybutton.Size = new System.Drawing.Size(101, 31);
            this.Copybutton.TabIndex = 12;
            this.Copybutton.Text = "Копіювати";
            this.Copybutton.UseVisualStyleBackColor = false;
            this.Copybutton.Click += new System.EventHandler(this.Copybutton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 16;
            this.ResultBox.Location = new System.Drawing.Point(520, 49);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(234, 308);
            this.ResultBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Lime;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SaveButton.Location = new System.Drawing.Point(385, 284);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 31);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Copybutton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.SymbolTextBox);
            this.Controls.Add(this.SymbolLetterBox);
            this.Controls.Add(this.BigLetterBox);
            this.Controls.Add(this.SmallLetterbox);
            this.Controls.Add(this.Numberbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Numberbox;
        private System.Windows.Forms.CheckBox SmallLetterbox;
        private System.Windows.Forms.CheckBox BigLetterBox;
        private System.Windows.Forms.CheckBox SymbolLetterBox;
        private System.Windows.Forms.TextBox SymbolTextBox;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button Copybutton;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

