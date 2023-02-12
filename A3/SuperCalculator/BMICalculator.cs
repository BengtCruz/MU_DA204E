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
            string cat = "";

            return cat;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateBMI()
        {
            double bmi = 0.0;

            return bmi;
        }

        public string NormalWeight()
        {
            string normalWght = "";
            
            return normalWght;
        }


        /* Setters */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name) => Name = name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        public void SetUnit(UnitTypes unit) => Unit = unit;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height) => Height = height;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        public void SetWeight(double weight) => Weight = weight;

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
