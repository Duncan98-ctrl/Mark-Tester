using System;

namespace Mark_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            
            while(loop)
            {
                Console.WriteLine("<---- Welcome to Mark Tester ---->");

                Console.Write("Enter the total: ");
                float total = Int32.Parse(Console.ReadLine());
                Console.WriteLine(total);

                Console.Write("Enter studentMark: ");
                float studentMark = Int32.Parse(Console.ReadLine());
                Console.WriteLine(studentMark);

                float number = (studentMark / total) * 100;
                Console.WriteLine(number);

                Console.WriteLine("Student Mark is " + number);

                Console.Write("Do you want to enter a new student mark? Y/N: ");
                string answer = Console.ReadLine();

                if(answer == "Y" || answer == "y")
                {
                    loop = true;
                }
                else if(answer == "N" || answer == "n")
                {
                    loop = false;
                }
                
                Consoole.WriteLine("This Change was made!")

                //New Feature will be created here!!!
            }
        }
    }
}
