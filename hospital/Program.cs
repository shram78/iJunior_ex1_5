using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.
Пользователь вводит кол-во людей в очереди.
Фиксированное время приема одного человека всегда равно 10 минутам.
Пример ввода: Введите кол-во старушек: 14
Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."*/

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перед тобой очередь в поликлинику. Сколько старушек ты насчитал? ");
            int listOfOldWomen = Convert.ToInt32(Console.ReadLine());

            int timeOfWaiting = listOfOldWomen * 10; //фиксированной время в очереди 10 min*количество старушек
            int hourWaiting = timeOfWaiting / 60; // получаем значения ожидания в часах
            int minutesWaiting = timeOfWaiting % 60; // получаем значение ожидания минут

            Console.WriteLine($"Прикинув, ты понимаешь, что тебе надо простоять в очереди" +
                              $" {hourWaiting} часов и {minutesWaiting} минут");
            Console.ReadLine();
        }
    }
}