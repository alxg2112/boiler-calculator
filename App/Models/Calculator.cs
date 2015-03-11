using System;
using System.Collections.Generic;
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
        public double BoilerOutput { get; set; }

        /// <summary>
        /// Boiler heat up time (hours)
        /// </summary>
        public double BoilerHeatUpTime { get; set; }

        /// <summary>
        /// Amount of hot water comsumed monthly (cubic meters)
        /// </summary>
        public double HotWaterConsumed { get; set; }

        /// <summary>
        /// Hot water price ($ / cubic meter)
        /// </summary>
        public double HotWaterPrice { get; set; }

        /// <summary>
        /// Cold water price ($ / cubic meter)
        /// </summary>
        public double ColdWaterPrice { get; set; }

        /// <summary>
        /// Boiler price ($)
        /// </summary>
        public double BoilerPrice { get; set; }

        /// <summary>
        /// Boiler capacity (liters)
        /// </summary>
        public double BoilerCapacity { get; set; }

        /// <summary>
        /// Electricity price ($ / kiloWatt)
        /// </summary>
        public double ElectricityPrice { get; set; }

        /// <summary>
        /// Period (months)
        /// </summary>
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