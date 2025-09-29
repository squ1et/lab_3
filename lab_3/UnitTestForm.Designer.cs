namespace lab_3
{
    partial class UnitTestForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label5 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(296, 228);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(288, 200);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Task 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(229, 246);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 169);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Result: ";
            // 
            // button1
            // 
            button1.Location = new Point(158, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Find count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(35, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(35, 23);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 120);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 3;
            label4.Text = "c:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 88);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 2;
            label3.Text = "b:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 58);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "a: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(268, 15);
            label1.TabIndex = 0;
            label1.Text = "Count number of numbers that are multiple to 27";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(288, 200);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Task 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(180, 15);
            label6.TabIndex = 1;
            label6.Text = "Sum of numbers multiple to 17...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 30);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 2;
            label7.Text = "Enter range";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 30);
            label8.Name = "label8";
            label8.Size = new Size(16, 15);
            label8.TabIndex = 3;
            label8.Text = "a:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(167, 30);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 4;
            label9.Text = "b:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(44, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(190, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(44, 23);
            textBox5.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(190, 160);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Calc sum";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 73);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 8;
            label10.Text = "Result: ";
            // 
            // UnitTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 280);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Name = "UnitTestForm";
            Text = "UnitTestForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button button2;
        private Label label5;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label10;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}