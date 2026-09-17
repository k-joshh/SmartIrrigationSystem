namespace SmartIrrigationSystem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soilMoistureTrackBar = new System.Windows.Forms.TrackBar();
            this.temperatureTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soilMoistureLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pumpIntensityLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soilMoistureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pumpIntensityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.soilMoistureTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soilMoistureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpIntensityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Irrigation System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soil Moisture:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature:";
            // 
            // soilMoistureTrackBar
            // 
            this.soilMoistureTrackBar.LargeChange = 10;
            this.soilMoistureTrackBar.Location = new System.Drawing.Point(188, 136);
            this.soilMoistureTrackBar.Maximum = 1000;
            this.soilMoistureTrackBar.Name = "soilMoistureTrackBar";
            this.soilMoistureTrackBar.Size = new System.Drawing.Size(226, 50);
            this.soilMoistureTrackBar.TabIndex = 3;
            this.soilMoistureTrackBar.Scroll += new System.EventHandler(this.CrispValueChanged);
            // 
            // temperatureTrackBar
            // 
            this.temperatureTrackBar.LargeChange = 10;
            this.temperatureTrackBar.Location = new System.Drawing.Point(188, 236);
            this.temperatureTrackBar.Maximum = 450;
            this.temperatureTrackBar.Minimum = 100;
            this.temperatureTrackBar.Name = "temperatureTrackBar";
            this.temperatureTrackBar.Size = new System.Drawing.Size(226, 50);
            this.temperatureTrackBar.TabIndex = 4;
            this.temperatureTrackBar.Value = 100;
            this.temperatureTrackBar.Scroll += new System.EventHandler(this.CrispValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(626, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 5);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartIrrigationSystem.Properties.Resources.plant;
            this.pictureBox2.Location = new System.Drawing.Point(765, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartIrrigationSystem.Properties.Resources.water_pump;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(461, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "- - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // soilMoistureLabel
            // 
            this.soilMoistureLabel.AutoSize = true;
            this.soilMoistureLabel.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soilMoistureLabel.Location = new System.Drawing.Point(286, 102);
            this.soilMoistureLabel.Name = "soilMoistureLabel";
            this.soilMoistureLabel.Size = new System.Drawing.Size(29, 17);
            this.soilMoistureLabel.TabIndex = 9;
            this.soilMoistureLabel.Text = "0%";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(285, 203);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(41, 17);
            this.temperatureLabel.TabIndex = 10;
            this.temperatureLabel.Text = "10°C";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(23, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 3);
            this.panel2.TabIndex = 11;
            // 
            // pumpIntensityLabel
            // 
            this.pumpIntensityLabel.AutoSize = true;
            this.pumpIntensityLabel.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpIntensityLabel.Location = new System.Drawing.Point(707, 169);
            this.pumpIntensityLabel.Name = "pumpIntensityLabel";
            this.pumpIntensityLabel.Size = new System.Drawing.Size(49, 17);
            this.pumpIntensityLabel.TabIndex = 12;
            this.pumpIntensityLabel.Text = "0.00%";
            this.pumpIntensityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pump Intensity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Graphs";
            // 
            // soilMoistureChart
            // 
            chartArea4.Name = "ChartArea1";
            this.soilMoistureChart.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.soilMoistureChart.Legends.Add(legend4);
            this.soilMoistureChart.Location = new System.Drawing.Point(34, 391);
            this.soilMoistureChart.Name = "soilMoistureChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.soilMoistureChart.Series.Add(series4);
            this.soilMoistureChart.Size = new System.Drawing.Size(337, 300);
            this.soilMoistureChart.TabIndex = 15;
            this.soilMoistureChart.Text = "chart1";
            // 
            // temperatureChart
            // 
            chartArea5.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend5);
            this.temperatureChart.Location = new System.Drawing.Point(405, 391);
            this.temperatureChart.Name = "temperatureChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.temperatureChart.Series.Add(series5);
            this.temperatureChart.Size = new System.Drawing.Size(337, 300);
            this.temperatureChart.TabIndex = 16;
            this.temperatureChart.Text = "chart1";
            // 
            // pumpIntensityChart
            // 
            chartArea6.Name = "ChartArea1";
            this.pumpIntensityChart.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.pumpIntensityChart.Legends.Add(legend6);
            this.pumpIntensityChart.Location = new System.Drawing.Point(778, 391);
            this.pumpIntensityChart.Name = "pumpIntensityChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.pumpIntensityChart.Series.Add(series6);
            this.pumpIntensityChart.Size = new System.Drawing.Size(337, 300);
            this.pumpIntensityChart.TabIndex = 17;
            this.pumpIntensityChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 720);
            this.Controls.Add(this.pumpIntensityChart);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.soilMoistureChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pumpIntensityLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.soilMoistureLabel);
            this.Controls.Add(this.temperatureTrackBar);
            this.Controls.Add(this.soilMoistureTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soilMoistureTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soilMoistureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpIntensityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar soilMoistureTrackBar;
        private System.Windows.Forms.TrackBar temperatureTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label soilMoistureLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pumpIntensityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart soilMoistureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pumpIntensityChart;
    }
}

