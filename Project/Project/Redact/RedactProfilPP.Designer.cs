﻿namespace Project.Redact
{
    partial class RedactProfilPP
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 24;
            label3.Text = "Площадь";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 31);
            comboBox2.TabIndex = 23;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 27);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Создать новый";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 169);
            button1.Name = "button1";
            button1.Size = new Size(205, 37);
            button1.TabIndex = 21;
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
            comboBox1.TabIndex = 20;
            // 
            // RedactProfilPP
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 218);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "RedactProfilPP";
            Text = "RedactProfilPP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private Button button1;
        private ComboBox comboBox1;
    }
}