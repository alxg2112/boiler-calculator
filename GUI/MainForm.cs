using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            boilerPriceBox.Text = "1652";
            boilerOutputBox.Text = "1,5";
            boilerHeatUpTimeBox.Text = "3,7";
            boilerCapacityBox.Text = "80";
            hotWaterPriceBox.Text = "25,1";
            coldWaterPriceBox.Text = "3,89";
            electricityPriceBox.Text = "0,3084";
            waterConsumedBox.Text = "5";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double boilerOutput;
            double boilerHeatUpTime;
            double boilerCapacity;
            double amountOfWarterConsumed;
            double hotWaterPrice;
            double coldWaterPrice;
            double boilerPrice;
            double electricityPrice;
            double period;

            try
            {
                boilerOutput = double.Parse(boilerOutputBox.Text);
                boilerHeatUpTime = double.Parse(boilerHeatUpTimeBox.Text);
                boilerCapacity = double.Parse(boilerCapacityBox.Text);
                amountOfWarterConsumed = double.Parse(waterConsumedBox.Text);
                hotWaterPrice = double.Parse(hotWaterPriceBox.Text);
                coldWaterPrice = double.Parse(coldWaterPriceBox.Text);
                boilerPrice = double.Parse(boilerPriceBox.Text);
                electricityPrice = double.Parse(electricityPriceBox.Text);
                period = double.Parse(periodBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect input data!");
                return;
            }

            profitBox.Text = String.Format("{0:F3}", Calculator.ElectricityCalculator.GetProfit(boilerOutput, 
            boilerHeatUpTime,
            boilerCapacity, 
            amountOfWarterConsumed, 
            hotWaterPrice, 
            coldWaterPrice,
            boilerPrice,
            electricityPrice,
            period));

            paybackBox.Text = String.Format("{0:F3}", Calculator.ElectricityCalculator.GetPaybackTime(boilerOutput,
            boilerHeatUpTime,
            boilerCapacity,
            amountOfWarterConsumed,
            hotWaterPrice, 
            coldWaterPrice,
            boilerPrice,
            electricityPrice));
        }
    }
}
