namespace GenerateExcelData
{
    partial class Form1
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelExcelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SimpleCheck = new System.Windows.Forms.CheckBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Elements = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.GCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartElement = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementsCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Location = new System.Drawing.Point(554, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 29);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.ProgressBar);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Набор данных";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CancelExcelButton);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.SimpleCheck);
            this.panel2.Controls.Add(this.OpenButton);
            this.panel2.Controls.Add(this.Elements);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Time);
            this.panel2.Controls.Add(this.GCode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.StartElement);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ElementsCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.FilePath);
            this.panel2.Controls.Add(this.OpenFileButton);
            this.panel2.Controls.Add(this.GenerateButton);
            this.panel2.Location = new System.Drawing.Point(11, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 271);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Удалить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CancelExcelButton
            // 
            this.CancelExcelButton.Enabled = false;
            this.CancelExcelButton.Location = new System.Drawing.Point(171, 240);
            this.CancelExcelButton.Name = "CancelExcelButton";
            this.CancelExcelButton.Size = new System.Drawing.Size(112, 23);
            this.CancelExcelButton.TabIndex = 39;
            this.CancelExcelButton.Text = "Отмена";
            this.CancelExcelButton.UseVisualStyleBackColor = true;
            this.CancelExcelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Одинаковые данные";
            // 
            // SimpleCheck
            // 
            this.SimpleCheck.AutoSize = true;
            this.SimpleCheck.Location = new System.Drawing.Point(167, 156);
            this.SimpleCheck.Name = "SimpleCheck";
            this.SimpleCheck.Size = new System.Drawing.Size(15, 14);
            this.SimpleCheck.TabIndex = 36;
            this.SimpleCheck.UseVisualStyleBackColor = true;
            this.SimpleCheck.CheckedChanged += new System.EventHandler(this.SimpleCheck_CheckedChanged);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(332, 240);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(111, 23);
            this.OpenButton.TabIndex = 35;
            this.OpenButton.Text = "Открыть файл";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.Open_Click);
            // 
            // Elements
            // 
            this.Elements.Location = new System.Drawing.Point(439, 193);
            this.Elements.Name = "Elements";
            this.Elements.ReadOnly = true;
            this.Elements.Size = new System.Drawing.Size(80, 20);
            this.Elements.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Сгенерировано (записей)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Время (сек.)";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(167, 193);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(68, 20);
            this.Time.TabIndex = 31;
            // 
            // GCode
            // 
            this.GCode.Location = new System.Drawing.Point(167, 105);
            this.GCode.Name = "GCode";
            this.GCode.Size = new System.Drawing.Size(352, 20);
            this.GCode.TabIndex = 26;
            this.GCode.Text = "Name #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Шаблон Названия";
            // 
            // StartElement
            // 
            this.StartElement.Location = new System.Drawing.Point(439, 73);
            this.StartElement.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.StartElement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartElement.Name = "StartElement";
            this.StartElement.Size = new System.Drawing.Size(80, 20);
            this.StartElement.TabIndex = 18;
            this.StartElement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Начать с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество записей";
            // 
            // ElementsCount
            // 
            this.ElementsCount.Location = new System.Drawing.Point(167, 71);
            this.ElementsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ElementsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ElementsCount.Name = "ElementsCount";
            this.ElementsCount.Size = new System.Drawing.Size(97, 20);
            this.ElementsCount.TabIndex = 9;
            this.ElementsCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите файл для сохранения";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(11, 30);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(508, 20);
            this.FilePath.TabIndex = 7;
            this.FilePath.Text = "C:\\test.xlsx";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(528, 28);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "Выбрать";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(11, 240);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(111, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(3, 298);
            this.ProgressBar.MarqueeAnimationSpeed = 10;
            this.ProgressBar.Maximum = 25;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(627, 22);
            this.ProgressBar.Step = 20;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 33);
            this.panel1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "excel файл (*.xlsx) | *.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(633, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация тестовых данных";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementsCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ElementsCount;
        private System.Windows.Forms.NumericUpDown StartElement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Elements;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox SimpleCheck;
        private System.Windows.Forms.Button CancelExcelButton;
        private System.Windows.Forms.Button button1;
    }
}

