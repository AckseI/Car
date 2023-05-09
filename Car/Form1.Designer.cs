namespace Car
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
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            maxSpeed = new DataGridViewTextBoxColumn();
            weight = new DataGridViewTextBoxColumn();
            isDamage = new DataGridViewCheckBoxColumn();
            color = new DataGridViewTextBoxColumn();
            sits = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            resetButton = new Button();
            button8 = new Button();
            richTextBox1 = new RichTextBox();
            button9 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(109, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Да";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Макс. скорость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Повреждена ?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 43);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Вес машины";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 126);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Кол-во мест";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 97);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "Цвет машины";
            // 
            // button1
            // 
            button1.Location = new Point(48, 168);
            button1.Name = "button1";
            button1.Size = new Size(129, 51);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maxSpeed, weight, isDamage, color, sits });
            dataGridView1.Location = new Point(233, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 11;
            // 
            // maxSpeed
            // 
            maxSpeed.HeaderText = "Макс. скорость";
            maxSpeed.Name = "maxSpeed";
            // 
            // weight
            // 
            weight.HeaderText = "Вес машины";
            weight.Name = "weight";
            // 
            // isDamage
            // 
            isDamage.HeaderText = "Повреждена ?";
            isDamage.Name = "isDamage";
            // 
            // color
            // 
            color.HeaderText = "Цвет машины";
            color.Name = "color";
            // 
            // sits
            // 
            sits.HeaderText = "Кол-во мест";
            sits.Name = "sits";
            // 
            // button2
            // 
            button2.Location = new Point(310, 7);
            button2.Name = "button2";
            button2.Size = new Size(129, 51);
            button2.TabIndex = 12;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(582, 7);
            button3.Name = "button3";
            button3.Size = new Size(129, 51);
            button3.TabIndex = 13;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(248, 239);
            button4.Name = "button4";
            button4.Size = new Size(129, 51);
            button4.TabIndex = 14;
            button4.Text = "Бабл";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 368);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 15;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 368);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 16;
            label7.Text = "Время сортировки: ";
            // 
            // button5
            // 
            button5.Location = new Point(11, 314);
            button5.Name = "button5";
            button5.Size = new Size(129, 51);
            button5.TabIndex = 17;
            button5.Text = "Заполнение";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(431, 239);
            button6.Name = "button6";
            button6.Size = new Size(129, 51);
            button6.TabIndex = 18;
            button6.Text = "Метод Шелла";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(618, 239);
            button7.Name = "button7";
            button7.Size = new Size(129, 51);
            button7.TabIndex = 19;
            button7.Text = "Патимейкер";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(647, 314);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(129, 51);
            resetButton.TabIndex = 20;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(796, 11);
            button8.Name = "button8";
            button8.Size = new Size(129, 51);
            button8.TabIndex = 21;
            button8.Text = "Перебор";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(796, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(297, 239);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // button9
            // 
            button9.Location = new Point(943, 11);
            button9.Name = "button9";
            button9.Size = new Size(129, 51);
            button9.TabIndex = 23;
            button9.Text = "Динамика";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 285);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(890, 84);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 389);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button9);
            Controls.Add(richTextBox1);
            Controls.Add(button8);
            Controls.Add(resetButton);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn maxSpeed;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewCheckBoxColumn isDamage;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn sits;
        private Button button4;
        private Label label6;
        private Label label7;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button resetButton;
        private Button button8;
        private RichTextBox richTextBox1;
        private Button button9;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
