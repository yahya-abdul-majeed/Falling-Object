
namespace simulation_modelling_1_prj
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.ValStep = new System.Windows.Forms.NumericUpDown();
            this.Step = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.ValWeight = new System.Windows.Forms.NumericUpDown();
            this.ValSize = new System.Windows.Forms.NumericUpDown();
            this.ValSpeed = new System.Windows.Forms.NumericUpDown();
            this.ValAngle = new System.Windows.Forms.NumericUpDown();
            this.ValHeight = new System.Windows.Forms.NumericUpDown();
            this.Size = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.speedtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResultsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValHeight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LaunchBtn);
            this.panel1.Controls.Add(this.ValStep);
            this.panel1.Controls.Add(this.Step);
            this.panel1.Controls.Add(this.Weight);
            this.panel1.Controls.Add(this.ValWeight);
            this.panel1.Controls.Add(this.ValSize);
            this.panel1.Controls.Add(this.ValSpeed);
            this.panel1.Controls.Add(this.ValAngle);
            this.panel1.Controls.Add(this.ValHeight);
            this.panel1.Controls.Add(this.Size);
            this.panel1.Controls.Add(this.Speed);
            this.panel1.Controls.Add(this.Angle);
            this.panel1.Controls.Add(this.Height);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 100);
            this.panel1.TabIndex = 0;
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.Location = new System.Drawing.Point(624, 34);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(75, 23);
            this.LaunchBtn.TabIndex = 1;
            this.LaunchBtn.Text = "Launch";
            this.LaunchBtn.UseVisualStyleBackColor = true;
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // ValStep
            // 
            this.ValStep.DecimalPlaces = 1;
            this.ValStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ValStep.Location = new System.Drawing.Point(449, 67);
            this.ValStep.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ValStep.Name = "ValStep";
            this.ValStep.Size = new System.Drawing.Size(120, 22);
            this.ValStep.TabIndex = 12;
            this.ValStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Location = new System.Drawing.Point(375, 72);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(37, 17);
            this.Step.TabIndex = 11;
            this.Step.Text = "Step";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(375, 42);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(52, 17);
            this.Weight.TabIndex = 10;
            this.Weight.Text = "Weight";
            // 
            // ValWeight
            // 
            this.ValWeight.Location = new System.Drawing.Point(449, 38);
            this.ValWeight.Name = "ValWeight";
            this.ValWeight.Size = new System.Drawing.Size(120, 22);
            this.ValWeight.TabIndex = 9;
            this.ValWeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ValWeight.ValueChanged += new System.EventHandler(this.ValWeight_ValueChanged);
            // 
            // ValSize
            // 
            this.ValSize.Location = new System.Drawing.Point(449, 11);
            this.ValSize.Name = "ValSize";
            this.ValSize.Size = new System.Drawing.Size(120, 22);
            this.ValSize.TabIndex = 8;
            this.ValSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ValSpeed
            // 
            this.ValSpeed.Location = new System.Drawing.Point(117, 70);
            this.ValSpeed.Name = "ValSpeed";
            this.ValSpeed.Size = new System.Drawing.Size(120, 22);
            this.ValSpeed.TabIndex = 7;
            this.ValSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ValAngle
            // 
            this.ValAngle.Location = new System.Drawing.Point(117, 42);
            this.ValAngle.Name = "ValAngle";
            this.ValAngle.Size = new System.Drawing.Size(120, 22);
            this.ValAngle.TabIndex = 6;
            this.ValAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ValHeight
            // 
            this.ValHeight.Location = new System.Drawing.Point(117, 13);
            this.ValHeight.Name = "ValHeight";
            this.ValHeight.Size = new System.Drawing.Size(120, 22);
            this.ValHeight.TabIndex = 5;
            this.ValHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(375, 13);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(35, 17);
            this.Size.TabIndex = 3;
            this.Size.Text = "Size";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(30, 67);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(49, 17);
            this.Speed.TabIndex = 2;
            this.Speed.Text = "Speed";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Location = new System.Drawing.Point(30, 40);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(44, 17);
            this.Angle.TabIndex = 1;
            this.Angle.Text = "Angle";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(30, 13);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(49, 17);
            this.Height.TabIndex = 0;
            this.Height.Text = "Height";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.speedtxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 225);
            this.panel2.TabIndex = 1;
            // 
            // speedtxt
            // 
            this.speedtxt.Location = new System.Drawing.Point(845, 67);
            this.speedtxt.Name = "speedtxt";
            this.speedtxt.Size = new System.Drawing.Size(66, 22);
            this.speedtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(937, 225);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ResultsTable);
            this.panel3.Location = new System.Drawing.Point(0, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 128);
            this.panel3.TabIndex = 2;
            // 
            // ResultsTable
            // 
            this.ResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.ResultsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsTable.Location = new System.Drawing.Point(0, 0);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.RowHeadersWidth = 51;
            this.ResultsTable.RowTemplate.Height = 24;
            this.ResultsTable.Size = new System.Drawing.Size(937, 128);
            this.ResultsTable.TabIndex = 0;
            this.ResultsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Factors";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Test1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Test2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Test3";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Test4";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Test5";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Test6";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(955, 495);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValHeight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.NumericUpDown ValWeight;
        private System.Windows.Forms.NumericUpDown ValSize;
        private System.Windows.Forms.NumericUpDown ValSpeed;
        private System.Windows.Forms.NumericUpDown ValAngle;
        private System.Windows.Forms.NumericUpDown ValHeight;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown ValStep;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox speedtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ResultsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}