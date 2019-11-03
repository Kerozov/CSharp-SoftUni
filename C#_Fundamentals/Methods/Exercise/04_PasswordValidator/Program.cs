using System;

namespace _04_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            Pass1(password);
            Pass2(password);
            Pass3(password);

            if (Pass1(password) ==true&&Pass2(password) ==true&&Pass3(password)==true)
            {
                Console.WriteLine("Password is valid");
            }
             if (Pass1(password) ==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
             if (Pass2(password)==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");

            }
            if (Pass3(password)==false)
            {

                Console.WriteLine("Password must have at least 2 digits");
            }

        }
        static bool Pass1(string password)
        {
            
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                count++;
            }
            if (count<6||count>10)
            {
                
                return false;
               

            }
            else
            {
            return true;

            }
           
        }
        static bool Pass2(string password)
        {
            
            for (int i = 0; i < password.Length; i++)
            {
                char symbol =password[i] ;
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                   
                }


            }
            return true;
        }
        static bool Pass3(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
                if (count  ==2)
                {
                    return true;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    
    }
}
