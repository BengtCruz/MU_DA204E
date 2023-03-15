using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    internal class BMRCalculator
    {
        private byte age;
        private Gender gender;
        private ActivityLevel activityLevel;

        /* Calculations */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public double CalculateBMR(double weight, double height)
        {
            double bmr = (10 * weight) + (6.25 * height) - (5 * age);

            return gender == Gender.Male ? bmr + 5 : bmr - 161;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double ActiveLevelFactor()
        {
            switch (activityLevel)
            {
                case ActivityLevel.Sedentary:
                    return 1.2;
                case ActivityLevel.Lightly_Active:
                    return 1.375;
                case ActivityLevel.Moderately_Active:
                    return 1.550;
                case ActivityLevel.Very_Active:
                    return 1.725;
                case ActivityLevel.Extra_Active:
                    return 1.9;
                default:
                    return 0.0;
            }
        }

        /* Setters */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="genderIn"></param>
        public void SetGender(Gender genderIn) => gender = genderIn;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actvityLvl"></param>
        public void SetActivityLevel(ActivityLevel actvityLvl) => activityLevel = actvityLvl;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ageIn"></param>
        public void SetAge(byte ageIn) => age = ageIn;

        /* Getters */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Gender GetGender() => gender;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActivityLevel GetActivityLevel() => activityLevel;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte GetAge() => age;
    }
}
