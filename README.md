## This programm showed us how Count words and numbers on text

There are I use **Do and While** due to you can play again.
And i use _Calculate()_ mode for Hiding because my code written by private **Access Modifites**
 

     static void Main(string[] args)  
     {
     string isContinue;
        do
        {
            Calculate();

            Finder("Do you want    continue? (" + ")");


             isContinue = Console.ReadLine();

         } while (isContinue == "+");
     }

> After that i used 
 * Foreach => in services 
 ### Codes
 + isDigit() => for numbers
 + IsLetter() => for words



 
 public static int GenerateDigits(string text)
{
        
          int count = 0;
          foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
}
           
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;


  Finally I change Console.WriteLine To my user "Finder" example      
  > *static void Finder(string text)*
>
 > {
 >   
 >   Console.WriteLine(text);
  >
 > }    



 1. How to call code in services to program 

 first write the name of class "CLASS" and dot(.) name Access modifite metods name "GETDiGITS" this is written on program **Finder($"There are {Class.GetDigits(text)}");**      

 >          for exaple
                   
     Finder($"Counter number of letters: {CounterServices.GenerateDigits(text)}");





      internal class CounterServices
    {
     public static int GetDigits(string text)
        {
        }
    }
