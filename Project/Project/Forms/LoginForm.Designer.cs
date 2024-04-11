namespace Project.Forms
{
    partial class LoginForm
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
            txbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbPassword = new TextBox();
            button1 = new Button();
            cmbChange = new ComboBox();
            ckbCollege = new CheckBox();
            SuspendLayout();
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(12, 129);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(306, 32);
            txbLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(12, 206);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(306, 32);
            txbPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 274);
            button1.Name = "button1";
            button1.Size = new Size(306, 62);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbChange
            // 
            cmbChange.FormattingEnabled = true;
            cmbChange.Location = new Point(12, 12);
            cmbChange.Name = "cmbChange";
            cmbChange.Size = new Size(306, 31);
            cmbChange.TabIndex = 5;
            // 
            // ckbCollege
            // 
            ckbCollege.AutoSize = true;
            ckbCollege.Location = new Point(12, 61);
            ckbCollege.Name = "ckbCollege";
            ckbCollege.Size = new Size(262, 27);
            ckbCollege.TabIndex = 6;
            ckbCollege.Text = "Соединение из Колледжа?";
            ckbCollege.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 348);
            Controls.Add(ckbCollege);
            Controls.Add(cmbChange);
            Controls.Add(button1);
            Controls.Add(txbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbLogin);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbLogin;
        private Label label1;
        private Label label2;
        private TextBox txbPassword;
        private Button button1;
        private ComboBox cmbChange;
        private CheckBox ckbCollege;
    }
}