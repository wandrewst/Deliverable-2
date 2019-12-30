using System;

namespace Deliverable_2_
{
    class Deliverable_2_
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Greetings! What is the message to code today? ");

                string input = Console.ReadLine().ToUpper();

                int checksum = 0;
                string message = "";

                for (int i = 0; i < input.Length; i++)
                {
                    int characterVal = (int)input[i];
                    int alphaValue = (characterVal - 64);

                    checksum += characterVal;
                    message += alphaValue.ToString();

                    if (i < input.Length - 1)
                    {
                        message += "-";
                    }
                }

                Console.WriteLine("Your encoded message is " + message);
                Console.WriteLine("Message checksum is " + checksum);

                Console.ReadLine();
            
        } 
    }
}
