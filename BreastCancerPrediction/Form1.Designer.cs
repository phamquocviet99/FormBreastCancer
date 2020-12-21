namespace BreastCancerPrediction
{
    partial class BreastCancer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelaccuracy = new System.Windows.Forms.Label();
            this.lableresult = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbinvasive = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbinsitu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbbenign = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbnormal = new System.Windows.Forms.Label();
            this.lablemodel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_predict = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.rbdensenet201 = new System.Windows.Forms.RadioButton();
            this.rbdensenet121 = new System.Windows.Forms.RadioButton();
            this.rbxeption = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lablemodel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(11, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1685, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.pb);
            this.panel6.Location = new System.Drawing.Point(3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(479, 469);
            this.panel6.TabIndex = 30;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(-1, -3);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(480, 475);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 8;
            this.pb.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.labelaccuracy);
            this.panel5.Controls.Add(this.lableresult);
            this.panel5.Location = new System.Drawing.Point(485, 479);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 99);
            this.panel5.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Result :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Accuracy :";
            // 
            // labelaccuracy
            // 
            this.labelaccuracy.AutoSize = true;
            this.labelaccuracy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaccuracy.Location = new System.Drawing.Point(143, 52);
            this.labelaccuracy.Name = "labelaccuracy";
            this.labelaccuracy.Size = new System.Drawing.Size(117, 27);
            this.labelaccuracy.TabIndex = 19;
            this.labelaccuracy.Text = "Accuracy :";
            // 
            // lableresult
            // 
            this.lableresult.AutoSize = true;
            this.lableresult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableresult.Location = new System.Drawing.Point(117, 16);
            this.lableresult.Name = "lableresult";
            this.lableresult.Size = new System.Drawing.Size(85, 27);
            this.lableresult.TabIndex = 18;
            this.lableresult.Text = "Result :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbinvasive);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lbinsitu);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbbenign);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbnormal);
            this.panel4.Location = new System.Drawing.Point(754, 478);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(711, 100);
            this.panel4.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "Normal : ";
            // 
            // lbinvasive
            // 
            this.lbinvasive.AutoSize = true;
            this.lbinvasive.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinvasive.Location = new System.Drawing.Point(539, 52);
            this.lbinvasive.Name = "lbinvasive";
            this.lbinvasive.Size = new System.Drawing.Size(105, 27);
            this.lbinvasive.TabIndex = 27;
            this.lbinvasive.Text = "Invasive :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Benign :";
            // 
            // lbinsitu
            // 
            this.lbinsitu.AutoSize = true;
            this.lbinsitu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinsitu.Location = new System.Drawing.Point(539, 17);
            this.lbinsitu.Name = "lbinsitu";
            this.lbinsitu.Size = new System.Drawing.Size(81, 27);
            this.lbinsitu.TabIndex = 26;
            this.lbinsitu.Text = "InSitu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "InSitu :";
            // 
            // lbbenign
            // 
            this.lbbenign.AutoSize = true;
            this.lbbenign.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbenign.Location = new System.Drawing.Point(197, 54);
            this.lbbenign.Name = "lbbenign";
            this.lbbenign.Size = new System.Drawing.Size(117, 27);
            this.lbbenign.TabIndex = 25;
            this.lbbenign.Text = "Accuracy :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Invasive :";
            // 
            // lbnormal
            // 
            this.lbnormal.AutoSize = true;
            this.lbnormal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnormal.Location = new System.Drawing.Point(197, 17);
            this.lbnormal.Name = "lbnormal";
            this.lbnormal.Size = new System.Drawing.Size(102, 27);
            this.lbnormal.TabIndex = 24;
            this.lbnormal.Text = "Normal : ";
            // 
            // lablemodel
            // 
            this.lablemodel.AutoSize = true;
            this.lablemodel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablemodel.Location = new System.Drawing.Point(236, 507);
            this.lablemodel.Name = "lablemodel";
            this.lablemodel.Size = new System.Drawing.Size(114, 35);
            this.lablemodel.TabIndex = 17;
            this.lablemodel.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model :";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Moccasin;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.DimGray;
            this.btn_close.Location = new System.Drawing.Point(1471, 507);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(204, 48);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PChart);
            this.panel3.Controls.Add(this.CChart);
            this.panel3.Location = new System.Drawing.Point(485, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 475);
            this.panel3.TabIndex = 1;
            // 
            // PChart
            // 
            this.PChart.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.Name = "ChartArea1";
            this.PChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PChart.Legends.Add(legend1);
            this.PChart.Location = new System.Drawing.Point(3, 2);
            this.PChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PChart.Name = "PChart";
            this.PChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Percent %";
            this.PChart.Series.Add(series1);
            this.PChart.Size = new System.Drawing.Size(536, 469);
            this.PChart.TabIndex = 3;
            this.PChart.Text = "Cchart";
            // 
            // CChart
            // 
            this.CChart.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea2.Name = "ChartArea1";
            this.CChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CChart.Legends.Add(legend2);
            this.CChart.Location = new System.Drawing.Point(527, 2);
            this.CChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CChart.Name = "CChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Percent %";
            this.CChart.Series.Add(series2);
            this.CChart.Size = new System.Drawing.Size(663, 469);
            this.CChart.TabIndex = 2;
            this.CChart.Text = "Cchart";
            // 
            // btn_predict
            // 
            this.btn_predict.BackColor = System.Drawing.Color.Moccasin;
            this.btn_predict.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_predict.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_predict.ForeColor = System.Drawing.Color.DimGray;
            this.btn_predict.Location = new System.Drawing.Point(418, 10);
            this.btn_predict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(204, 48);
            this.btn_predict.TabIndex = 3;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = false;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Moccasin;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.DimGray;
            this.btn_add.Location = new System.Drawing.Point(13, 10);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(165, 48);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Browser image ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Moccasin;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.DimGray;
            this.btn_clear.Location = new System.Drawing.Point(194, 10);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(209, 48);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // rbdensenet201
            // 
            this.rbdensenet201.AutoSize = true;
            this.rbdensenet201.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdensenet201.Location = new System.Drawing.Point(19, 14);
            this.rbdensenet201.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdensenet201.Name = "rbdensenet201";
            this.rbdensenet201.Size = new System.Drawing.Size(124, 23);
            this.rbdensenet201.TabIndex = 9;
            this.rbdensenet201.TabStop = true;
            this.rbdensenet201.Text = "Densenet201";
            this.rbdensenet201.UseVisualStyleBackColor = true;
            // 
            // rbdensenet121
            // 
            this.rbdensenet121.AutoSize = true;
            this.rbdensenet121.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdensenet121.Location = new System.Drawing.Point(197, 14);
            this.rbdensenet121.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdensenet121.Name = "rbdensenet121";
            this.rbdensenet121.Size = new System.Drawing.Size(124, 23);
            this.rbdensenet121.TabIndex = 10;
            this.rbdensenet121.TabStop = true;
            this.rbdensenet121.Text = "Densenet121";
            this.rbdensenet121.UseVisualStyleBackColor = true;
            // 
            // rbxeption
            // 
            this.rbxeption.AutoSize = true;
            this.rbxeption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxeption.Location = new System.Drawing.Point(365, 14);
            this.rbxeption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbxeption.Name = "rbxeption";
            this.rbxeption.Size = new System.Drawing.Size(97, 23);
            this.rbxeption.TabIndex = 11;
            this.rbxeption.TabStop = true;
            this.rbxeption.Text = "Xception";
            this.rbxeption.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.rbxeption);
            this.panel2.Controls.Add(this.rbdensenet121);
            this.panel2.Controls.Add(this.rbdensenet201);
            this.panel2.Location = new System.Drawing.Point(1200, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 47);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(982, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose the model :";
            // 
            // BreastCancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1708, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BreastCancer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classification BreastCancer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.DataVisualization.Charting.Chart CChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbxeption;
        private System.Windows.Forms.RadioButton rbdensenet121;
        private System.Windows.Forms.RadioButton rbdensenet201;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelaccuracy;
        private System.Windows.Forms.Label lableresult;
        private System.Windows.Forms.Label lablemodel;
        private System.Windows.Forms.Label lbbenign;
        private System.Windows.Forms.Label lbnormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbinvasive;
        private System.Windows.Forms.Label lbinsitu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}

