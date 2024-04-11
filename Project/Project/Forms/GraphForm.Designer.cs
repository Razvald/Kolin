namespace Project.Forms
{
    partial class GraphForm
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
            plt = new ScottPlot.WinForms.FormsPlot();
            cmb = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // plt
            // 
            plt.DisplayScale = 1F;
            plt.Location = new Point(12, 81);
            plt.Name = "plt";
            plt.Size = new Size(606, 402);
            plt.TabIndex = 0;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(12, 12);
            cmb.Name = "cmb";
            cmb.Size = new Size(219, 31);
            cmb.TabIndex = 1;
            cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(255, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 2;
            button1.Text = "Вернуть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 495);
            Controls.Add(button1);
            Controls.Add(cmb);
            Controls.Add(plt);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "GraphForm";
            Text = "GraphForm";
            Load += GraphForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plt;
        private ComboBox cmb;
        private Button button1;
    }
}