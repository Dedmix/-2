using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Numbers> numbers = new Queue<Numbers>();
            Console.WriteLine("Список чисел в очереди: ");
            numbers.Enqueue(new Numbers() { Number = 1 });
            numbers.Enqueue(new Numbers() { Number = 5 });
            numbers.Enqueue(new Numbers() { Number = 8 });
            numbers.Enqueue(new Numbers() { Number = 9 });
            numbers.Enqueue(new Numbers() { Number = 10 });

            foreach (Numbers s in numbers)
            {
                Console.WriteLine(s.Number);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Первый в очереди: ");
            Numbers numbers1 = numbers.Peek();
            Console.WriteLine(numbers1.Number);
            Console.WriteLine(" ");

            Queue<Person> persons = new Queue<Person>();
            Console.WriteLine("Список имён в очереди: ");
            persons.Enqueue(new Person() { Name = "Илья" });
            persons.Enqueue(new Person() { Name = "Егор" });
            persons.Enqueue(new Person() { Name = "Дмитрий" });
            persons.Enqueue(new Person() { Name = "Рома" });
            persons.Enqueue(new Person() { Name = "Андрей" });
            foreach (Person D in persons)
            {
                Console.WriteLine(D.Name);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Первый в очереди: ");
            Person person = persons.Dequeue();
            Console.WriteLine(person.Name);
        }

    }
   
}

