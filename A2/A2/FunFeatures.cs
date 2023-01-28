using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public class FunFeatures
    {
        private string name = "";
        private string email = "";


        public void Start()
        {

            Introduce();

            bool repeat = false;

            do
            {

                PredictMyDay();

                CalculateStrengthLength();

                repeat = RunAgain();
            
            } while (repeat);

        }
        private void Introduce()
        {

        }

        void PredictMyDay()
        {

        }

        private bool RunAgain()
        {
            return true;
        }

        void CalculateStrengthLength()
        {

        }

    }
}
