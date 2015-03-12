using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Calculator
    {
        public int ID { get; set; }

        /// <summary>
        /// Boiler output (kiloWatts)
        /// </summary>
        [DisplayName("Boiler output:")]
        public double BoilerOutput { get; set; }

        /// <summary>
        /// Boiler heat up time (hours)
        /// </summary>
        [DisplayName("Boiler heat up time:")]
        public double BoilerHeatUpTime { get; set; }

        /// <summary>
        /// Amount of hot water comsumed monthly (cubic meters)
        /// </summary>
        [DisplayName("Hot water consumed:")]
        public double HotWaterConsumed { get; set; }

        /// <summary>
        /// Hot water price ($ / cubic meter)
        /// </summary>
        [DisplayName("Hot water price:")]
        public double HotWaterPrice { get; set; }

        /// <summary>
        /// Cold water price ($ / cubic meter)
        /// </summary>
        [DisplayName("Cold water price:")]
        public double ColdWaterPrice { get; set; }

        /// <summary>
        /// Boiler price ($)
        /// </summary>
        [DisplayName("Boiler price:")]
        public double BoilerPrice { get; set; }

        /// <summary>
        /// Boiler capacity (liters)
        /// </summary>
        [DisplayName("Boiler capacity:")]
        public double BoilerCapacity { get; set; }

        /// <summary>
        /// Electricity price ($ / kiloWatt)
        /// </summary>
        [DisplayName("Elecricity price:")]
        public double ElectricityPrice { get; set; }

        /// <summary>
        /// Period (months)
        /// </summary>
        [DisplayName("Period:")]
        public double Period { get; set; }

        /// <summary>
        /// Profit of using boiler over paying for hot water
        /// </summary>
        public double Profit
        {
            get
            {
                var power = ((HotWaterConsumed * 1000) / BoilerCapacity) * (BoilerOutput * BoilerHeatUpTime);
                var powerCost = power * ElectricityPrice;
                var totalBoilerUsageCost = powerCost + HotWaterConsumed * ColdWaterPrice;
                var waterHeapUpCost = HotWaterConsumed * HotWaterPrice;
                return (waterHeapUpCost - totalBoilerUsageCost) * Period - BoilerPrice;
            }
        }

        /// <summary>
        /// Payback time of boiler
        /// </summary>
        public double PaybackTime
        {
            get
            {
                var power = ((HotWaterConsumed * 1000) / BoilerCapacity) * (BoilerOutput * BoilerHeatUpTime);
                var powerCost = power * ElectricityPrice;
                var totalBoilerUsageCost = powerCost + HotWaterConsumed * ColdWaterPrice;
                var waterHeapUpCost = HotWaterConsumed * HotWaterPrice;
                return BoilerPrice / (waterHeapUpCost - totalBoilerUsageCost);
            }
        }
    }

    public class CalculatorDbContext : DbContext
    {
        public DbSet<Calculator> Calculators { get; set; }
    }
}