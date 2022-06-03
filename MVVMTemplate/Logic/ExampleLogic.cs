using System;
using System.Diagnostics;

namespace Logic
{
    public class ExampleLogic : IExampleLogic
    {
        public string AddNumbersFromString(string number1, string number2)
        {
            int num1;
            bool num1IsDigit = int.TryParse(number1, out num1);
            int num2;
            bool num2IsDigit = int.TryParse(number2, out num2);
            return (num1IsDigit && num2IsDigit) ? (num1 + num2).ToString() : "ERROR";
        }
        public void DontClick()
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ") { UseShellExecute = true });
            }
            catch (Exception)
            {

                throw new Exception("Rickroll failed :( ♥");
            }
            
        }
    }
}
