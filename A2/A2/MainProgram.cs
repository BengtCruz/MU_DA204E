namespace A2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            //Console.Title = "Strings, selection and iteration in C#";
            
            /* Grade C: FunFeature */

            //FunFeatures funObj = new FunFeatures();
            //funObj.Start();

            //ContinueToNextPart();

            /* Grade C: MathWork */

            //Console.Title = "Lets work with numbers!";
            //MathWork calc = new MathWork();
            //calc.Start();

            //ContinueToNextPart();

            /* Grade B: TemperatureConverter */

            Console.Title = "Temperature Converter";
            TemperatureConverter tempConv = new TemperatureConverter();
            tempConv.Start();


            ContinueToNextPart();

            /* Grade A: */
        }

        private static void ContinueToNextPart()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }
    }
}