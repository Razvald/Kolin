namespace Project.Redact
{
    partial class RedactProject
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
            checkBox1 = new CheckBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 27);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Создать новый";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(205, 37);
            button1.TabIndex = 12;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 31);
            comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 10;
            label2.Text = "Локация";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 9;
            label1.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 32);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 32);
            textBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 31);
            comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 15;
            label3.Text = "Заказчик";
            // 
            // RedactProject
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 382);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "RedactProject";
            Text = "RedactProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label3;
    }
}