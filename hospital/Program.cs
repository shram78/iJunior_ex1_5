using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перед тобой очередь в поликлинику. Сколько старушек ты насчитал? ");
            int listOfOldWomen = Convert.ToInt32(Console.ReadLine());
            int hourWaiting = listOfOldWomen * 10 / 60; 
            int minutesWaiting = listOfOldWomen * 10 % 60; 
            Console.WriteLine($"Прикинув, ты понимаешь, что тебе надо простоять в очереди" +
                              $" {hourWaiting} часов и {minutesWaiting} минут");
            Console.ReadLine();
        }
    }
}