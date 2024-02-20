namespace BasicCalculator
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
            numberBox = new GroupBox();
            numbers = new Label();
            displayPlaceholder = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            acButton = new Button();
            equalButton = new Button();
            deleteButton = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            numberBox.SuspendLayout();
            SuspendLayout();
            // 
            // numberBox
            // 
            numberBox.BackColor = Color.White;
            numberBox.Controls.Add(numbers);
            numberBox.Controls.Add(displayPlaceholder);
            numberBox.Location = new Point(12, 12);
            numberBox.Name = "numberBox";
            numberBox.RightToLeft = RightToLeft.Yes;
            numberBox.Size = new Size(354, 91);
            numberBox.TabIndex = 0;
            numberBox.TabStop = false;
            numberBox.Text = "Display";
            // 
            // numbers
            // 
            numbers.AutoSize = true;
            numbers.Dock = DockStyle.Right;
            numbers.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numbers.Location = new Point(299, 23);
            numbers.Name = "numbers";
            numbers.RightToLeft = RightToLeft.No;
            numbers.Size = new Size(0, 62);
            numbers.TabIndex = 2;
            // 
            // displayPlaceholder
            // 
            displayPlaceholder.AutoSize = true;
            displayPlaceholder.Dock = DockStyle.Right;
            displayPlaceholder.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayPlaceholder.Location = new Point(299, 23);
            displayPlaceholder.Name = "displayPlaceholder";
            displayPlaceholder.RightToLeft = RightToLeft.No;
            displayPlaceholder.Size = new Size(52, 62);
            displayPlaceholder.TabIndex = 1;
            displayPlaceholder.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(12, 109);
            button1.Name = "button1";
            button1.Size = new Size(66, 58);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(84, 109);
            button2.Name = "button2";
            button2.Size = new Size(66, 58);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(156, 109);
            button3.Name = "button3";
            button3.Size = new Size(66, 58);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 173);
            button4.Name = "button4";
            button4.Size = new Size(66, 58);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(84, 173);
            button5.Name = "button5";
            button5.Size = new Size(66, 58);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(156, 173);
            button6.Name = "button6";
            button6.Size = new Size(66, 58);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 237);
            button7.Name = "button7";
            button7.Size = new Size(66, 58);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(84, 237);
            button8.Name = "button8";
            button8.Size = new Size(66, 58);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(156, 237);
            button9.Name = "button9";
            button9.Size = new Size(66, 58);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(12, 301);
            button10.Name = "button10";
            button10.Size = new Size(66, 58);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(84, 301);
            button11.Name = "button11";
            button11.Size = new Size(66, 58);
            button11.TabIndex = 12;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // acButton
            // 
            acButton.Location = new Point(228, 301);
            acButton.Name = "acButton";
            acButton.Size = new Size(66, 58);
            acButton.TabIndex = 13;
            acButton.Text = "AC";
            acButton.UseVisualStyleBackColor = true;
            acButton.Click += acButton_Click;
            // 
            // equalButton
            // 
            equalButton.Location = new Point(300, 173);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(66, 186);
            equalButton.TabIndex = 14;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += equalButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(156, 301);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(66, 58);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "DEL";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(228, 109);
            button12.Name = "button12";
            button12.Size = new Size(66, 58);
            button12.TabIndex = 16;
            button12.Text = "÷";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(300, 109);
            button13.Name = "button13";
            button13.Size = new Size(66, 58);
            button13.TabIndex = 17;
            button13.Text = "×";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(228, 173);
            button14.Name = "button14";
            button14.Size = new Size(66, 58);
            button14.TabIndex = 18;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(228, 237);
            button15.Name = "button15";
            button15.Size = new Size(66, 58);
            button15.TabIndex = 19;
            button15.Text = "+";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 371);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(deleteButton);
            Controls.Add(equalButton);
            Controls.Add(acButton);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numberBox);
            Name = "Form1";
            Text = "Basic Calculator";
            Load += Form1_Load;
            numberBox.ResumeLayout(false);
            numberBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox numberBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button acButton;
        private Button equalButton;
        private Button deleteButton;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label displayPlaceholder;
        private Label numbers;
    }
}
