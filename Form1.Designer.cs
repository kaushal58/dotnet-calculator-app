namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.memoryRecallButton = new System.Windows.Forms.Button();
            this.memoryPlusButton = new System.Windows.Forms.Button();
            this.memoryMinusButton = new System.Windows.Forms.Button();
            this.darkModeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(12, 12);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(358, 43);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.Text = "0";
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryClearButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoryClearButton.Location = new System.Drawing.Point(12, 70);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(65, 40);
            this.memoryClearButton.TabIndex = 1;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // memoryRecallButton
            // 
            this.memoryRecallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryRecallButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoryRecallButton.Location = new System.Drawing.Point(83, 70);
            this.memoryRecallButton.Name = "memoryRecallButton";
            this.memoryRecallButton.Size = new System.Drawing.Size(65, 40);
            this.memoryRecallButton.TabIndex = 2;
            this.memoryRecallButton.Text = "MR";
            this.memoryRecallButton.UseVisualStyleBackColor = true;
            this.memoryRecallButton.Click += new System.EventHandler(this.MemoryRecallButton_Click);
            // 
            // memoryPlusButton
            // 
            this.memoryPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryPlusButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoryPlusButton.Location = new System.Drawing.Point(154, 70);
            this.memoryPlusButton.Name = "memoryPlusButton";
            this.memoryPlusButton.Size = new System.Drawing.Size(65, 40);
            this.memoryPlusButton.TabIndex = 3;
            this.memoryPlusButton.Text = "M+";
            this.memoryPlusButton.UseVisualStyleBackColor = true;
            this.memoryPlusButton.Click += new System.EventHandler(this.MemoryPlusButton_Click);
            // 
            // memoryMinusButton
            // 
            this.memoryMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryMinusButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoryMinusButton.Location = new System.Drawing.Point(225, 70);
            this.memoryMinusButton.Name = "memoryMinusButton";
            this.memoryMinusButton.Size = new System.Drawing.Size(65, 40);
            this.memoryMinusButton.TabIndex = 4;
            this.memoryMinusButton.Text = "M-";
            this.memoryMinusButton.UseVisualStyleBackColor = true;
            this.memoryMinusButton.Click += new System.EventHandler(this.MemoryMinusButton_Click);
            // 
            // darkModeButton
            // 
            this.darkModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.darkModeButton.Location = new System.Drawing.Point(296, 70);
            this.darkModeButton.Name = "darkModeButton";
            this.darkModeButton.Size = new System.Drawing.Size(74, 40);
            this.darkModeButton.TabIndex = 5;
            this.darkModeButton.Tag = "accent";
            this.darkModeButton.Text = "Dark";
            this.darkModeButton.UseVisualStyleBackColor = true;
            this.darkModeButton.Click += new System.EventHandler(this.DarkModeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(12, 116);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 60);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backspaceButton.Location = new System.Drawing.Point(103, 116);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(85, 60);
            this.backspaceButton.TabIndex = 7;
            this.backspaceButton.Text = "⌫";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.percentButton.Location = new System.Drawing.Point(194, 116);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(85, 60);
            this.percentButton.TabIndex = 8;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sqrtButton.Location = new System.Drawing.Point(285, 116);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(85, 60);
            this.sqrtButton.TabIndex = 9;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.divideButton.Location = new System.Drawing.Point(285, 182);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(85, 60);
            this.divideButton.TabIndex = 14;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sevenButton.Location = new System.Drawing.Point(12, 182);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(85, 60);
            this.sevenButton.TabIndex = 10;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.eightButton.Location = new System.Drawing.Point(103, 182);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(85, 60);
            this.eightButton.TabIndex = 11;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nineButton.Location = new System.Drawing.Point(194, 182);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(85, 60);
            this.nineButton.TabIndex = 12;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.multiplyButton.Location = new System.Drawing.Point(285, 248);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(85, 60);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.fourButton.Location = new System.Drawing.Point(12, 248);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(85, 60);
            this.fourButton.TabIndex = 15;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.fiveButton.Location = new System.Drawing.Point(103, 248);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(85, 60);
            this.fiveButton.TabIndex = 16;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sixButton.Location = new System.Drawing.Point(194, 248);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(85, 60);
            this.sixButton.TabIndex = 17;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.minusButton.Location = new System.Drawing.Point(285, 314);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(85, 60);
            this.minusButton.TabIndex = 24;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.oneButton.Location = new System.Drawing.Point(12, 314);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(85, 60);
            this.oneButton.TabIndex = 20;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.twoButton.Location = new System.Drawing.Point(103, 314);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(85, 60);
            this.twoButton.TabIndex = 21;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.threeButton.Location = new System.Drawing.Point(194, 314);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(85, 60);
            this.threeButton.TabIndex = 22;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.plusButton.Location = new System.Drawing.Point(285, 380);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(85, 60);
            this.plusButton.TabIndex = 27;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.zeroButton.Location = new System.Drawing.Point(12, 380);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(176, 60);
            this.zeroButton.TabIndex = 25;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.decimalButton.Location = new System.Drawing.Point(194, 380);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(85, 60);
            this.decimalButton.TabIndex = 26;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.equalsButton.Location = new System.Drawing.Point(12, 446);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(358, 60);
            this.equalsButton.TabIndex = 28;
            this.equalsButton.Tag = "accent";
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 519);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.darkModeButton);
            this.Controls.Add(this.memoryMinusButton);
            this.Controls.Add(this.memoryPlusButton);
            this.Controls.Add(this.memoryRecallButton);
            this.Controls.Add(this.memoryClearButton);
            this.Controls.Add(this.displayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button memoryClearButton;
        private System.Windows.Forms.Button memoryRecallButton;
        private System.Windows.Forms.Button memoryPlusButton;
        private System.Windows.Forms.Button memoryMinusButton;
        private System.Windows.Forms.Button darkModeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalsButton;
    }
}
