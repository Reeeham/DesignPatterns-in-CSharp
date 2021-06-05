using System;

namespace IteratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                string name = (string)iter.next();
                Console.WriteLine("Name : " + name); 
            }
            Console.ReadLine();
        }
    }
}
