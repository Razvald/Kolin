namespace Project.Forms
{
    partial class MainForm
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
            cmbCustomer = new ComboBox();
            cmbProjects = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvArea = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            dgvProfilePoints = new DataGridView();
            label5 = new Label();
            dgvPickets = new DataGridView();
            btnSave = new Button();
            btnGraph = new Button();
            btnRedactCustomer = new Button();
            btnRedactProject = new Button();
            btnRedactArea = new Button();
            btnRedactPickets = new Button();
            btnRedactProfilePoints = new Button();
            btnRedactProfilPP = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfilePoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPickets).BeginInit();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(366, 12);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(197, 31);
            cmbCustomer.TabIndex = 0;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // cmbProjects
            // 
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(366, 49);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(197, 31);
            cmbProjects.TabIndex = 1;
            cmbProjects.SelectedIndexChanged += cmbProjects_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "Заказчик:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 52);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 3;
            label2.Text = "Проект:";
            // 
            // dgvArea
            // 
            dgvArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArea.Location = new Point(12, 134);
            dgvArea.Name = "dgvArea";
            dgvArea.RowTemplate.Height = 25;
            dgvArea.Size = new Size(348, 368);
            dgvArea.TabIndex = 4;
            dgvArea.CellClick += dgvArea_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 5;
            label3.Text = "Площади:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 105);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 6;
            label4.Text = "Точки профиля:";
            // 
            // dgvProfilePoints
            // 
            dgvProfilePoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfilePoints.Location = new Point(366, 134);
            dgvProfilePoints.Name = "dgvProfilePoints";
            dgvProfilePoints.RowTemplate.Height = 25;
            dgvProfilePoints.Size = new Size(360, 156);
            dgvProfilePoints.TabIndex = 7;
            dgvProfilePoints.CellClick += dgvProfilePoints_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 325);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 8;
            label5.Text = "Пикеты:";
            // 
            // dgvPickets
            // 
            dgvPickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPickets.Location = new Point(366, 351);
            dgvPickets.Name = "dgvPickets";
            dgvPickets.RowTemplate.Height = 25;
            dgvPickets.Size = new Size(360, 151);
            dgvPickets.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 31);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGraph
            // 
            btnGraph.Location = new Point(12, 49);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(101, 31);
            btnGraph.TabIndex = 11;
            btnGraph.Text = "График";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += btnGraph_Click;
            // 
            // btnRedactCustomer
            // 
            btnRedactCustomer.Location = new Point(574, 12);
            btnRedactCustomer.Name = "btnRedactCustomer";
            btnRedactCustomer.Size = new Size(152, 31);
            btnRedactCustomer.TabIndex = 12;
            btnRedactCustomer.Text = "Редактировать";
            btnRedactCustomer.UseVisualStyleBackColor = true;
            btnRedactCustomer.Click += btnRedactCustomer_Click;
            // 
            // btnRedactProject
            // 
            btnRedactProject.Location = new Point(574, 49);
            btnRedactProject.Name = "btnRedactProject";
            btnRedactProject.Size = new Size(152, 31);
            btnRedactProject.TabIndex = 13;
            btnRedactProject.Text = "Редактировать";
            btnRedactProject.UseVisualStyleBackColor = true;
            btnRedactProject.Click += btnRedactProject_Click;
            // 
            // btnRedactArea
            // 
            btnRedactArea.Location = new Point(12, 508);
            btnRedactArea.Name = "btnRedactArea";
            btnRedactArea.Size = new Size(152, 31);
            btnRedactArea.TabIndex = 14;
            btnRedactArea.Text = "Редактировать";
            btnRedactArea.UseVisualStyleBackColor = true;
            btnRedactArea.Click += btnRedactArea_Click;
            // 
            // btnRedactPickets
            // 
            btnRedactPickets.Location = new Point(574, 508);
            btnRedactPickets.Name = "btnRedactPickets";
            btnRedactPickets.Size = new Size(152, 31);
            btnRedactPickets.TabIndex = 15;
            btnRedactPickets.Text = "Редактировать";
            btnRedactPickets.UseVisualStyleBackColor = true;
            btnRedactPickets.Click += btnRedactPickets_Click;
            // 
            // btnRedactProfilePoints
            // 
            btnRedactProfilePoints.Location = new Point(574, 296);
            btnRedactProfilePoints.Name = "btnRedactProfilePoints";
            btnRedactProfilePoints.Size = new Size(152, 31);
            btnRedactProfilePoints.TabIndex = 16;
            btnRedactProfilePoints.Text = "Редактировать";
            btnRedactProfilePoints.UseVisualStyleBackColor = true;
            btnRedactProfilePoints.Click += btnRedactProfilePoints_Click;
            // 
            // btnRedactProfilPP
            // 
            btnRedactProfilPP.Location = new Point(366, 296);
            btnRedactProfilPP.Name = "btnRedactProfilPP";
            btnRedactProfilPP.Size = new Size(95, 31);
            btnRedactProfilPP.TabIndex = 17;
            btnRedactProfilPP.Text = "Связать";
            btnRedactProfilPP.UseVisualStyleBackColor = true;
            btnRedactProfilPP.Click += btnRedactProfilPP_Click;
            // 
            // button1
            // 
            button1.Location = new Point(366, 508);
            button1.Name = "button1";
            button1.Size = new Size(202, 31);
            button1.TabIndex = 18;
            button1.Text = "Измерения пикета";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 551);
            Controls.Add(button1);
            Controls.Add(btnRedactProfilPP);
            Controls.Add(btnRedactProfilePoints);
            Controls.Add(btnRedactPickets);
            Controls.Add(btnRedactArea);
            Controls.Add(btnRedactProject);
            Controls.Add(btnRedactCustomer);
            Controls.Add(btnGraph);
            Controls.Add(btnSave);
            Controls.Add(dgvPickets);
            Controls.Add(label5);
            Controls.Add(dgvProfilePoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProjects);
            Controls.Add(cmbCustomer);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfilePoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private ComboBox cmbProjects;
        private Label label1;
        private Label label2;
        private DataGridView dgvArea;
        private Label label3;
        private Label label4;
        private DataGridView dgvProfilePoints;
        private Label label5;
        private DataGridView dgvPickets;
        private Button btnSave;
        private Button btnGraph;
        private Button btnRedactCustomer;
        private Button btnRedactProject;
        private Button btnRedactArea;
        private Button btnRedactPickets;
        private Button btnRedactProfilePoints;
        private Button btnRedactProfilPP;
        private Button button1;
    }
}