using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ElectricityCalculator
    {
        /// <summary>
        /// Gets profit of using boiler over paying for hot water.
        /// </summary>
        /// <param name="boilerOutput">Output of the boiler (kiloWatts)</param>
        /// <param name="boilerHeatUpTime">Heat up time of the boiler (hours)</param>
        /// <param name="boilerCapacity">Capacity of the boiler (liters)</param>
        /// <param name="amountOfWaterConsumed">Amount of water consumed monthly (cublic meters)</param>
        /// <param name="hotWaterPrice">Price of hot water ($ per cublic meter)</param>
        /// <param name="coldWaterPrice">Price of cold water ($ per cublic meter)</param>
        /// <param name="boilerPrice">Price of boiler</param>
        /// <param name="electricityPrice">Price of electricity ($ per kiloWatt)</param>
        /// <param name="period">Period (months)</param>
        /// <returns>Money profit of using boiler for given period</returns>
        public static double GetProfit(double boilerOutput, 
            double boilerHeatUpTime,
            double boilerCapacity, 
            double amountOfWaterConsumed, 
            double hotWaterPrice,
            double coldWaterPrice,
            double boilerPrice,
            double electricityPrice,
            double period)
        {
            var power = ((amountOfWaterConsumed * 1000) / boilerCapacity) * (boilerOutput * boilerHeatUpTime);
            var powerCost = power * electricityPrice;
            var totalBoilerUsageCost = powerCost + amountOfWaterConsumed * coldWaterPrice;
            var waterHeapUpCost = amountOfWaterConsumed * hotWaterPrice;
            return (waterHeapUpCost - totalBoilerUsageCost) * period - boilerPrice;
        }

        /// <summary>
        /// Gets payback time of boiler.
        /// </summary>
        /// <param name="boilerOutput">Output of the boiler (kiloWatts)</param>
        /// <param name="boilerHeatUpTime">Heat up time of the boiler (hours)</param>
        /// <param name="boilerCapacity">Capacity of the boiler (liters)</param>
        /// <param name="amountOfWaterConsumed">Amount of water consumed monthly (cublic meters)</param>
        /// <param name="hotWaterPrice">Price of hot water ($ per cublic meter)</param>
        /// <param name="coldWaterPrice">Price of cold water ($ per cublic meter)</param>
        /// <param name="boilerPrice">Price of boiler</param>
        /// <param name="electricityPrice">Price of electricity ($ per kiloWatt)</param>
        /// <returns>Money profit of using boiler for given period</returns>
        public static double GetPaybackTime(double boilerOutput,
            double boilerHeatUpTime,
            double boilerCapacity,
            double amountOfWaterConsumed,
            double hotWaterPrice,
            double coldWaterPrice,
            double boilerPrice,
            double electricityPrice)
        {
            var power = ((amountOfWaterConsumed * 1000) / boilerCapacity) * (boilerOutput * boilerHeatUpTime);
            var powerCost = power * electricityPrice;
            var totalBoilerUsageCost = powerCost + amountOfWaterConsumed * coldWaterPrice;
            var waterHeapUpCost = amountOfWaterConsumed * hotWaterPrice;
            return boilerPrice / (waterHeapUpCost - totalBoilerUsageCost);
        }
    }
}
