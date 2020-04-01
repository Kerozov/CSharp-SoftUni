using System;
using System.ComponentModel.DataAnnotations;
using ShoppingSpree.Core;
namespace ShoppingSpree
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var Engine = new Engine();
                Engine.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
