namespace CurrencyCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.InputNumericBox = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(281, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(94, 23);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(508, 12);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(158, 23);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "0.00 USD";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(381, 12);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(121, 23);
            this.CurrencyComboBox.TabIndex = 3;
            // 
            // InputNumericBox
            // 
            this.InputNumericBox.DecimalPlaces = 4;
            this.InputNumericBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.InputNumericBox.InterceptArrowKeys = false;
            this.InputNumericBox.Location = new System.Drawing.Point(9, 12);
            this.InputNumericBox.Maximum = new decimal(new int[] {
            -1925794617,
            -140462611,
            4294,
            0});
            this.InputNumericBox.Name = "InputNumericBox";
            this.InputNumericBox.Size = new System.Drawing.Size(160, 23);
            this.InputNumericBox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "EUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 50);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InputNumericBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ConvertButton;
        private TextBox OutputTextBox;
        private ComboBox CurrencyComboBox;
        private NumericUpDown InputNumericBox;
        private TextBox textBox1;
    }
}