namespace SitecTZ
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
            buttonOpenAppealsFile = new Button();
            openAppealsFileDialog1 = new OpenFileDialog();
            labelFileNameOFAppeals = new Label();
            labelFileNameOfRKK = new Label();
            buttonOpenRKKFile = new Button();
            openRKKFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnNameOfResponsible = new DataGridViewTextBoxColumn();
            ColumnNumberOfRKK = new DataGridViewTextBoxColumn();
            ColumnNumberOfAppeals = new DataGridViewTextBoxColumn();
            ColumnNumberSummary = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            labelNumberOfAppeals = new Label();
            labelNumberOfRKK = new Label();
            labelNumberOfSummery = new Label();
            label8 = new Label();
            comboBoxSort = new ComboBox();
            label9 = new Label();
            buttonUpdate = new Button();
            label10 = new Label();
            labelTimeOfAppeals = new Label();
            labelTimeOfRKK = new Label();
            label13 = new Label();
            labelTimeOfUpdate = new Label();
            label15 = new Label();
            labelTimeofALL = new Label();
            label17 = new Label();
            buttonSave = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenAppealsFile
            // 
            buttonOpenAppealsFile.Location = new Point(12, 545);
            buttonOpenAppealsFile.Name = "buttonOpenAppealsFile";
            buttonOpenAppealsFile.Size = new Size(175, 23);
            buttonOpenAppealsFile.TabIndex = 0;
            buttonOpenAppealsFile.Text = "Открыть файл обращений";
            buttonOpenAppealsFile.UseVisualStyleBackColor = true;
            buttonOpenAppealsFile.Click += buttonOpenAppealsFile_Click;
            // 
            // openAppealsFileDialog1
            // 
            openAppealsFileDialog1.FileName = "openFileDialog1";
            openAppealsFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            // 
            // labelFileNameOFAppeals
            // 
            labelFileNameOFAppeals.AutoSize = true;
            labelFileNameOFAppeals.Location = new Point(12, 571);
            labelFileNameOFAppeals.Name = "labelFileNameOFAppeals";
            labelFileNameOFAppeals.Size = new Size(175, 15);
            labelFileNameOFAppeals.TabIndex = 1;
            labelFileNameOFAppeals.Text = "Файл обращений не добавлен";
            // 
            // labelFileNameOfRKK
            // 
            labelFileNameOfRKK.AutoSize = true;
            labelFileNameOfRKK.Location = new Point(12, 683);
            labelFileNameOfRKK.Name = "labelFileNameOfRKK";
            labelFileNameOfRKK.Size = new Size(131, 15);
            labelFileNameOfRKK.TabIndex = 3;
            labelFileNameOfRKK.Text = "Файл РКК не добавлен";
            // 
            // buttonOpenRKKFile
            // 
            buttonOpenRKKFile.Location = new Point(12, 657);
            buttonOpenRKKFile.Name = "buttonOpenRKKFile";
            buttonOpenRKKFile.Size = new Size(175, 23);
            buttonOpenRKKFile.TabIndex = 2;
            buttonOpenRKKFile.Text = "Открыть файл РКК";
            buttonOpenRKKFile.UseVisualStyleBackColor = true;
            buttonOpenRKKFile.Click += buttonOpenRKKFile_Click;
            // 
            // openRKKFileDialog1
            // 
            openRKKFileDialog1.FileName = "openFileDialog1";
            openRKKFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnNameOfResponsible, ColumnNumberOfRKK, ColumnNumberOfAppeals, ColumnNumberSummary });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(880, 527);
            dataGridView1.TabIndex = 4;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "№ п.п.";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Width = 30;
            // 
            // ColumnNameOfResponsible
            // 
            ColumnNameOfResponsible.HeaderText = "Ответственный исполнитель";
            ColumnNameOfResponsible.Name = "ColumnNameOfResponsible";
            ColumnNameOfResponsible.ReadOnly = true;
            ColumnNameOfResponsible.Width = 400;
            // 
            // ColumnNumberOfRKK
            // 
            ColumnNumberOfRKK.HeaderText = "Количество неисполненных входящих документов";
            ColumnNumberOfRKK.Name = "ColumnNumberOfRKK";
            ColumnNumberOfRKK.ReadOnly = true;
            // 
            // ColumnNumberOfAppeals
            // 
            ColumnNumberOfAppeals.HeaderText = "Количество неисполненных письменных обращений граждан";
            ColumnNumberOfAppeals.Name = "ColumnNumberOfAppeals";
            ColumnNumberOfAppeals.ReadOnly = true;
            // 
            // ColumnNumberSummary
            // 
            ColumnNumberSummary.HeaderText = "Общее количество документов и обращений";
            ColumnNumberSummary.Name = "ColumnNumberSummary";
            ColumnNumberSummary.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 586);
            label3.Name = "label3";
            label3.Size = new Size(196, 30);
            label3.TabIndex = 5;
            label3.Text = "Всего неисполненых письменных\r\nобращений:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 701);
            label4.Name = "label4";
            label4.Size = new Size(194, 15);
            label4.TabIndex = 6;
            label4.Text = "Всего неисполненых документов:";
            // 
            // labelNumberOfAppeals
            // 
            labelNumberOfAppeals.AutoSize = true;
            labelNumberOfAppeals.Location = new Point(12, 616);
            labelNumberOfAppeals.Name = "labelNumberOfAppeals";
            labelNumberOfAppeals.Size = new Size(12, 15);
            labelNumberOfAppeals.TabIndex = 7;
            labelNumberOfAppeals.Text = "-";
            // 
            // labelNumberOfRKK
            // 
            labelNumberOfRKK.AutoSize = true;
            labelNumberOfRKK.Location = new Point(12, 716);
            labelNumberOfRKK.Name = "labelNumberOfRKK";
            labelNumberOfRKK.Size = new Size(12, 15);
            labelNumberOfRKK.TabIndex = 8;
            labelNumberOfRKK.Text = "-";
            // 
            // labelNumberOfSummery
            // 
            labelNumberOfSummery.AutoSize = true;
            labelNumberOfSummery.Location = new Point(12, 742);
            labelNumberOfSummery.Name = "labelNumberOfSummery";
            labelNumberOfSummery.Size = new Size(12, 15);
            labelNumberOfSummery.TabIndex = 10;
            labelNumberOfSummery.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 757);
            label8.Name = "label8";
            label8.Size = new Size(201, 30);
            label8.TabIndex = 9;
            label8.Text = "Всего неисполненых документов и\r\nобращений:";
            // 
            // comboBoxSort
            // 
            comboBoxSort.AllowDrop = true;
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "по фамилии ответственного исполнителя", "по количеству РКК", "по количеству обращений", "по общему количеству документов" });
            comboBoxSort.Location = new Point(613, 571);
            comboBoxSort.MaxDropDownItems = 4;
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(279, 23);
            comboBoxSort.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.No;
            label9.Location = new Point(613, 549);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 12;
            label9.Text = "Сортировка:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(613, 600);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(157, 23);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Обновить таблицу";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 631);
            label10.Name = "label10";
            label10.Size = new Size(193, 15);
            label10.TabIndex = 14;
            label10.Text = "Время затраченное на операцию:";
            // 
            // labelTimeOfAppeals
            // 
            labelTimeOfAppeals.AutoSize = true;
            labelTimeOfAppeals.Location = new Point(211, 631);
            labelTimeOfAppeals.Name = "labelTimeOfAppeals";
            labelTimeOfAppeals.Size = new Size(12, 15);
            labelTimeOfAppeals.TabIndex = 15;
            labelTimeOfAppeals.Text = "-";
            // 
            // labelTimeOfRKK
            // 
            labelTimeOfRKK.AutoSize = true;
            labelTimeOfRKK.Location = new Point(219, 772);
            labelTimeOfRKK.Name = "labelTimeOfRKK";
            labelTimeOfRKK.Size = new Size(12, 15);
            labelTimeOfRKK.TabIndex = 17;
            labelTimeOfRKK.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 727);
            label13.Name = "label13";
            label13.Size = new Size(193, 15);
            label13.TabIndex = 16;
            label13.Text = "Время затраченное на операцию:";
            // 
            // labelTimeOfUpdate
            // 
            labelTimeOfUpdate.AutoSize = true;
            labelTimeOfUpdate.Location = new Point(812, 631);
            labelTimeOfUpdate.Name = "labelTimeOfUpdate";
            labelTimeOfUpdate.Size = new Size(12, 15);
            labelTimeOfUpdate.TabIndex = 19;
            labelTimeOfUpdate.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(613, 631);
            label15.Name = "label15";
            label15.Size = new Size(193, 15);
            label15.TabIndex = 18;
            label15.Text = "Время затраченное на операцию:";
            // 
            // labelTimeofALL
            // 
            labelTimeofALL.AutoSize = true;
            labelTimeofALL.Location = new Point(812, 657);
            labelTimeofALL.Name = "labelTimeofALL";
            labelTimeofALL.Size = new Size(12, 15);
            labelTimeofALL.TabIndex = 21;
            labelTimeofALL.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(613, 657);
            label17.Name = "label17";
            label17.Size = new Size(184, 15);
            label17.TabIndex = 20;
            label17.Text = "Суммарное затраченное время:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(767, 768);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 23);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Сохранить отчет";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 801);
            Controls.Add(buttonSave);
            Controls.Add(labelTimeofALL);
            Controls.Add(label17);
            Controls.Add(labelTimeOfUpdate);
            Controls.Add(label15);
            Controls.Add(labelTimeOfRKK);
            Controls.Add(label13);
            Controls.Add(labelTimeOfAppeals);
            Controls.Add(label10);
            Controls.Add(buttonUpdate);
            Controls.Add(label9);
            Controls.Add(comboBoxSort);
            Controls.Add(labelNumberOfSummery);
            Controls.Add(label8);
            Controls.Add(labelNumberOfRKK);
            Controls.Add(labelNumberOfAppeals);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(labelFileNameOfRKK);
            Controls.Add(buttonOpenRKKFile);
            Controls.Add(labelFileNameOFAppeals);
            Controls.Add(buttonOpenAppealsFile);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenAppealsFile;
        private OpenFileDialog openAppealsFileDialog1;
        private Label labelFileNameOFAppeals;
        private Label labelFileNameOfRKK;
        private Button buttonOpenRKKFile;
        private OpenFileDialog openRKKFileDialog1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label labelNumberOfAppeals;
        private Label labelNumberOfRKK;
        private Label labelNumberOfSummery;
        private Label label8;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnNameOfResponsible;
        private DataGridViewTextBoxColumn ColumnNumberOfRKK;
        private DataGridViewTextBoxColumn ColumnNumberOfAppeals;
        private DataGridViewTextBoxColumn ColumnNumberSummary;
        private ComboBox comboBoxSort;
        private Label label9;
        private Button buttonUpdate;
        private Label label10;
        private Label labelTimeOfAppeals;
        private Label labelTimeOfRKK;
        private Label label13;
        private Label labelTimeOfUpdate;
        private Label label15;
        private Label labelTimeofALL;
        private Label label17;
        private Button buttonSave;
        private SaveFileDialog saveFileDialog1;
    }
}