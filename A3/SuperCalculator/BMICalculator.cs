using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    internal class BMICalculator
    {
        private string Name = "Unknown";
        private UnitTypes Unit;
        private double Height = 0.0;
        private double Weight = 0.0;


        /* Calculate Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BmiWeightCat()
        {

            double twoDecimals = Math.Pow(10.0, 2);
            double bmi = Math.Truncate(twoDecimals * CalculateBMI()) / twoDecimals;

            if (bmi >= 18.5)
            {
                if (bmi >= 18.5 && bmi <= 24.99)
                    return "Normal Weight";
                else if (bmi >= 25.0 && bmi <= 29.99)
                    return "Overweight (Pre-obesiy)";
                else if (bmi >= 30.0 && bmi <= 34.99)
                    return "Overweight (Obesity class I)";
                else if (bmi >= 35.0 && bmi <= 39.99)
                    return "Overweight (Obesity class II)";
                else
                    return "Overweight (Obesity class III)";
            }
            else return "Underweight";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateBMI() => (Unit == UnitTypes.Metric) ? Weight / Math.Pow(Height, 2) : 703.0 *(Weight/ Math.Pow(Height, 2));


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string NormalWeight() => (Unit == UnitTypes.Metric) ? $"{18.5 * Math.Pow(Height, 2):.00} and {24.9 * Math.Pow(Height, 2):.00} Kg" : $"{(18.5 / 703.0) * Math.Pow(Height, 2):.00} and {(24.9 / 703.0) * Math.Pow(Height, 2):.00} lbs";


        /* Setters */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name) { if(!string.IsNullOrEmpty(name)) Name = name; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        public void SetUnit(UnitTypes unit) => Unit = unit;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height) { if (height > 0) Height = height; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(double weight) { if (weight > 0) Weight = weight; }

        /* Getters */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UnitTypes GetUnit() => Unit;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetName() => Name;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetHeight() => Height;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetWeight() => Weight;

    }
}
