using System;
using System.IO;
/// <summary>
/// user defined class
/// </summary>
class UserDefineException: Exception
{

    public UserDefineException(string str)
    {
        Console.WriteLine("In user Defined Class");
       // Console.WriteLine(str);
    }
}

class Program
{
    static void Main()
    {
        String writeText="User Define Exception";
        UserDefineException M = new UserDefineException(writeText);
       //UserDefineException M = new UserDefineException("User Defined Exception");

        try
        {
         throw M;
           //File.WriteAllText("filename1.txt",writeText);

           //string readText=File.ReadAllText("filename1.txt");
           //Console.WriteLine(readText);
        }
        catch (Exception e)
        {
            File.WriteAllText("filename1.txt",e.Message);

            string readText=File.ReadAllText("filename1.txt");
            Console.WriteLine(readText);
           // Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally Block");
        }
    }
}
