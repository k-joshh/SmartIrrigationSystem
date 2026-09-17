using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartIrrigationSystem
{
    public partial class Form1 : Form
    {
        double[] SoilMoisture_Low = { 0.0, 0.0, 20.0, 40.0 };
        double[] SoilMoisture_Medium = { 20.0, 50.0, 75.0 };
        double[] SoilMoisture_High = { 60.0, 80.0, 100.0, 100.0 };

        double[] Temperature_Low = { 10.0, 10.0, 18.0, 25.0 };
        double[] Temperature_Medium = { 20.0, 28.0, 36.0 };
        double[] Temperature_High = { 30.0, 38.0, 45.0, 45.0 };

        double[] Pump_Off = { 0.0, 0.0, 10.0, 25.0 };
        double[] Pump_Low = { 15.0, 35.0, 55.0 };
        double[] Pump_Med = { 45.0, 65.0, 85.0 };
        double[] Pump_High = { 75.0, 90.0, 100.0, 100.0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupFuzzyChart();
            PlotMembershipFunctions();
            AddCursorSeries();

            UpdateGUI();
        }

        private void SetupFuzzyChart()
        {
            // Soil Moisture Chart Setup
            soilMoistureChart.ChartAreas.Clear();
            soilMoistureChart.Series.Clear();

            ChartArea area = new ChartArea("Soil Moisture");

            area.AxisX.Title = "Soil Moisture (%)";
            area.AxisX.Minimum = 0.0;
            area.AxisX.Maximum = 100.0;

            area.AxisY.Title = "Membership Degree (μ)";
            area.AxisY.Minimum = 0.0;
            area.AxisY.Maximum = 1.0;
            area.AxisY.Interval = 0.2;

            soilMoistureChart.ChartAreas.Add(area);

            // Temperature Chart Setup
            temperatureChart.ChartAreas.Clear();
            temperatureChart.Series.Clear();

            ChartArea area2 = new ChartArea("Temperature");

            area2.AxisX.Title = "Temperature (°C)";
            area2.AxisX.Minimum = 10.0;
            area2.AxisX.Maximum = 45.0;
            area2.AxisX.Interval = 5.0;

            area2.AxisY.Title = "Membership Degree (μ)";
            area2.AxisY.Minimum = 0.0;
            area2.AxisY.Maximum = 1.0;
            area2.AxisY.Interval = 0.2;

            temperatureChart.ChartAreas.Add(area2);

            // Pump Intensity Chart Setup
            pumpIntensityChart.ChartAreas.Clear();
            pumpIntensityChart.Series.Clear();

            ChartArea area3 = new ChartArea("Pump Intensity");

            area3.AxisX.Title = "Pump Intensity (%)";
            area3.AxisX.Minimum = 0.0;
            area3.AxisX.Maximum = 100.0;

            area3.AxisY.Title = "Membership Degree (μ)";
            area3.AxisY.Minimum = 0.0;
            area3.AxisY.Maximum = 1.0;
            area3.AxisY.Interval = 0.2;

            pumpIntensityChart.ChartAreas.Add(area3);

            // Aggregated Area
            Series aggregatedArea = new Series("Aggregated Area")
            {
                ChartType = SeriesChartType.Area,
                Color = Color.FromArgb(120, Color.LightGray),
                BorderWidth = 1
            };
            pumpIntensityChart.Series.Add(aggregatedArea);

            //Centroid Line
            Series centroidLine = new Series("Centroid Line")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Black,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Dash,
                IsVisibleInLegend = false
            };
            pumpIntensityChart.Series.Add(centroidLine);
        }

        private void PlotMembershipFunctions()
        {
            // Plotting Soil Moisture
            Series low = CreateSeries("Low", Color.Red);
            Series med = CreateSeries("Medium", Color.Green);
            Series high = CreateSeries("High", Color.Blue);

            double step = 0.5;
            
            for (double x = 0.0; x <= 100.0; x += step)
            {
                double chLow = TrapezoidalMembershipFunction(x, SoilMoisture_Low[0], SoilMoisture_Low[1], SoilMoisture_Low[2], SoilMoisture_Low[3]);
                double chMed = TriangularMembershipFunction(x, SoilMoisture_Medium[0], SoilMoisture_Medium[1], SoilMoisture_Medium[2]);
                double chHigh = TrapezoidalMembershipFunction(x, SoilMoisture_High[0], SoilMoisture_High[1], SoilMoisture_High[2], SoilMoisture_High[3]);

                low.Points.AddXY(x, chLow);
                med.Points.AddXY(x, chMed);
                high.Points.AddXY(x, chHigh);
            }

            soilMoistureChart.Series.Add(low);
            soilMoistureChart.Series.Add(med);
            soilMoistureChart.Series.Add(high);

            // Plotting Temperature
            Series low2 = CreateSeries("Low", Color.Purple);
            Series med2 = CreateSeries("Medium", Color.Yellow);
            Series high2 = CreateSeries("High", Color.Orange);

            for (double x = 10.0; x <= 45.0; x += step)
            {
                double chLow = TrapezoidalMembershipFunction(x, Temperature_Low[0], Temperature_Low[1], Temperature_Low[2], Temperature_Low[3]);
                double chMed = TriangularMembershipFunction(x, Temperature_Medium[0], Temperature_Medium[1], Temperature_Medium[2]);
                double chHigh = TrapezoidalMembershipFunction(x, Temperature_High[0], Temperature_High[1], Temperature_High[2], Temperature_High[3]);

                low2.Points.AddXY(x, chLow);
                med2.Points.AddXY(x, chMed);
                high2.Points.AddXY(x, chHigh);
            }

            temperatureChart.Series.Add(low2);
            temperatureChart.Series.Add(med2);
            temperatureChart.Series.Add(high2);

            // Plotting Pump Intensity
            Series off = CreateSeries("Off", Color.Gold);
            Series low3 = CreateSeries("Low", Color.Brown);
            Series med3 = CreateSeries("Medium", Color.SkyBlue);
            Series high3 = CreateSeries("High", Color.Indigo);

            for (double x = 0.0; x <= 100.0; x += step)
            {
                double chOff = TrapezoidalMembershipFunction(x, Pump_Off[0], Pump_Off[1], Pump_Off[2], Pump_Off[3]);
                double chLow = TriangularMembershipFunction(x, Pump_Low[0], Pump_Low[1], Pump_Low[2]);
                double chMed = TriangularMembershipFunction(x, Pump_Med[0], Pump_Med[1], Pump_Med[2]);
                double chHigh = TrapezoidalMembershipFunction(x, Pump_High[0], Pump_High[1], Pump_High[2], Pump_High[3]);

                off.Points.AddXY(x, chOff);
                low3.Points.AddXY(x, chLow);
                med3.Points.AddXY(x, chMed);
                high3.Points.AddXY(x, chHigh);
            }

            pumpIntensityChart.Series.Add(off);
            pumpIntensityChart.Series.Add(low3);
            pumpIntensityChart.Series.Add(med3);
            pumpIntensityChart.Series.Add(high3);
        }


        private Series CreateSeries(string name, Color color)
        {
            return new Series(name)
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = color
            };
        }

        // Add a vertical cursor line series to both input charts
        private void AddCursorSeries()
        {
            Series smCursor = new Series("CurrentMoisture")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Black,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Dash,
                IsVisibleInLegend = false
            };
            soilMoistureChart.Series.Add(smCursor);

            Series tempCursor = new Series("CurrentTemp")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Black,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Dash,
                IsVisibleInLegend = false
            };
            temperatureChart.Series.Add(tempCursor);
        }

        private void UpdateGUI()
        {
            double smVal = soilMoistureTrackBar.Value / 10.0;
            double tempVal = temperatureTrackBar.Value / 10.0;

            soilMoistureLabel.Text = $"{smVal:F1}%";
            temperatureLabel.Text = $"{tempVal:F1}°C";

            double[,] membershipValues = Fuzzification(smVal, tempVal);
            double[] firingStrengths = GetFiringStrengths(membershipValues);
            double crispValue = Defuzzification(firingStrengths);

            soilMoistureChart.Series["CurrentMoisture"].Points.Clear();
            soilMoistureChart.Series["CurrentMoisture"].Points.AddXY(smVal, 0.0);
            soilMoistureChart.Series["CurrentMoisture"].Points.AddXY(smVal, 1.0);

            temperatureChart.Series["CurrentTemp"].Points.Clear();
            temperatureChart.Series["CurrentTemp"].Points.AddXY(tempVal, 0.0);
            temperatureChart.Series["CurrentTemp"].Points.AddXY(tempVal, 1.0);

            pumpIntensityLabel.Text = $"{crispValue:F2}%";
        }

        // Function for getting the membership values for soil moisture and temperature
        private double[,] Fuzzification(double SoilMoisture, double Temperature)
        {   
            // Values for soil moisture
            double smLow = TrapezoidalMembershipFunction(SoilMoisture, SoilMoisture_Low[0], SoilMoisture_Low[1], SoilMoisture_Low[2], SoilMoisture_Low[3]);
            double smMed = TriangularMembershipFunction(SoilMoisture, SoilMoisture_Medium[0], SoilMoisture_Medium[1], SoilMoisture_Medium[2]);
            double smHigh = TrapezoidalMembershipFunction(SoilMoisture, SoilMoisture_High[0], SoilMoisture_High[1], SoilMoisture_High[2], SoilMoisture_High[3]);

            // Values for temperature
            double tempLow = TrapezoidalMembershipFunction(Temperature, Temperature_Low[0], Temperature_Low[1], Temperature_Low[2], Temperature_Low[3]);
            double tempMed = TriangularMembershipFunction(Temperature, Temperature_Medium[0], Temperature_Medium[1], Temperature_Medium[2]);
            double tempHigh = TrapezoidalMembershipFunction(Temperature, Temperature_High[0], Temperature_High[1], Temperature_High[2], Temperature_High[3]);

            return new double[,] { {smLow, smMed, smHigh}, { tempLow, tempMed, tempHigh} };
        }

        // Function for rule evaluation

        // RULE EVALUATION (outcome pump intensity: off, low, medium, or high)
        // Rule 1: IF soil moisture is high then pump is almost off
        // Rule 2: IF soil moisture is medium AND temp is low then pump is off
        // Rule 3: IF soil moisture is medium AND temp is medium then pump is low
        // Rule 4: IF soil moisture is medium AND temp is high then pump is medium
        // Rule 5: IF soil moisture is low then pump is high

        private double[] GetFiringStrengths(double[,] membershipValues)
        {
            double rule_strength1 = membershipValues[0, 2];
            double rule_strength2 = Math.Min(membershipValues[0, 1], membershipValues[1, 0]);
            double rule_strength3 = Math.Min(membershipValues[0, 1], membershipValues[1, 1]);
            double rule_strength4 = Math.Min(membershipValues[0, 1], membershipValues[1, 2]);
            double rule_strength5 = membershipValues[0, 0];

            return new double[] { Math.Max(rule_strength1, rule_strength2), rule_strength3, rule_strength4, rule_strength5 };
        }

        // function for defuzzification
        // returns one action or event???
        // Dedined outputs: pumpOff, pumpLow, pumpMed, pumpHigh (0% - 100% intensity)

        private double Defuzzification(double[] firingStrengths)
        {
            double crispValue = 0.0;
            double sumDenominator = 0.0;
            double sumNumerator = 0.0;
            double step = 0.5;

            pumpIntensityChart.Series["Aggregated Area"].Points.Clear();
            pumpIntensityChart.Series["Centroid Line"].Points.Clear();

            for (double y = 0.0; y <= 100.0; y += step)
            {
                double outOff = TrapezoidalMembershipFunction(y, Pump_Off[0], Pump_Off[1], Pump_Off[2], Pump_Off[3]);
                double outLow = TriangularMembershipFunction(y, Pump_Low[0], Pump_Low[1], Pump_Low[2]);
                double outMed = TriangularMembershipFunction(y, Pump_Med[0], Pump_Med[1], Pump_Med[2]);
                double outHigh = TrapezoidalMembershipFunction(y, Pump_High[0], Pump_High[1], Pump_High[2], Pump_High[3]);

                double clippedOff = Math.Min(firingStrengths[0], outOff);
                double clippedLow = Math.Min(firingStrengths[1], outLow);
                double clippedMed = Math.Min(firingStrengths[2], outMed);
                double clippedHigh = Math.Min(firingStrengths[3], outHigh);

                double aggregatedY = Math.Max(clippedOff, Math.Max(clippedLow, Math.Max(clippedMed, clippedHigh)));

                pumpIntensityChart.Series["Aggregated Area"].Points.AddXY(y, aggregatedY);

                sumNumerator += y * aggregatedY * step;
                sumDenominator += aggregatedY * step;
            }

            if (sumDenominator > 0.0)
            {
                crispValue = sumNumerator / sumDenominator;

                pumpIntensityChart.Series["Centroid Line"].Points.AddXY(crispValue, 0.0);
                pumpIntensityChart.Series["Centroid Line"].Points.AddXY(crispValue, 1.0);
            }

            Console.WriteLine("\n--- Mamdani Defuzzification Result (Centroid) ---");

            Console.WriteLine($"Calculated Crisp Fan Speed Output: {crispValue:F2}%");

            return crispValue;
        }

        // triangular membership function
        private double TriangularMembershipFunction(double x, double a, double b, double c)
        {
            if (x <= a || x >= c)
                return 0;
            else if (x == b)
                return 1;
            else if (x > a && x < b)
                return (x - a) / (b - a);
            else // if (x > b && x < c)
                return (c - x) / (c - b);
        }

        // trapezoidal membership function
        private double TrapezoidalMembershipFunction(double x, double a, double b, double c, double d)
        {
            if (x >= b && x <= c)
                return 1;
            else if (x <= a || x >= d)
                return 0;
            else if (x > a && x < b)
                return (x - a) / (b - a);
            else // if (x > c && x < d)
                return (d - x) / (d - c);
        }

        private void CrispValueChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }
    }
}
