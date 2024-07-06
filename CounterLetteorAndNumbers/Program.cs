using CounterLetteorAndNumber.Service;

namespace CounterLetterAndNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isContinue;
            do
            {
                Calculate();

                Finder("Do you want continue? if yes + ");
                isContinue = Console.ReadLine();

            } 
            while (isContinue == "+");
        }
              private static void Calculate()
              {
                   Finder("The are your text \n");
                   Console.Write("Write the text : \n");

                   string text = Console.ReadLine();

                  Finder("The text have Letter and Number:");
                  Finder($"Counter number of letters: {CounterServices.GenerateDigits(text)}");
                  Finder($"Counter number of numbers: {CounterServices.GenerateLetters(text)}");
                  Finder($"Counter other simbols:     {CounterServices.GenerateAll(text)}");

              }
              static void Finder(string text)  
              {
                 Console.WriteLine(text);
              }
         
    }
}
